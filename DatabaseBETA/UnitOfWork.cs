using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Transactions;
using System.Configuration;

namespace DatabaseBETA
{
    /// <summary>
    /// Unit of work singleton class
    /// Represents "transaction"
    /// </summary>
    public class UnitOfWork //: IDisposable
    {
        private static UnitOfWork instance = null;
        private static readonly object locker = new object();

        /// <summary>
        /// List of commands to be commited or rollbacked
        /// </summary>
        private List<SqlCommand> commands = new List<SqlCommand>();

        private SqlConnection con = Database.Instance.Connection;
        private SqlTransaction transaction;

        /// <summary>
        /// Isolation level of database
        /// </summary>
        public System.Data.IsolationLevel isolationLevel = IsolationLevelParse(ConfigurationManager.AppSettings["isolationLevel"]);
        /// <summary>
        /// If transaction is being currently used
        /// </summary>
        public bool localTransActive = false;

        /// <summary>
        /// Instance of singleton
        /// </summary>
        public static UnitOfWork Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new UnitOfWork();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Method to add SQL COMMAND into transaction
        /// Opens connection and starts new transaction if it doesnt exist
        /// Inserts command into transaction 
        /// Executed command (waiting for next action)
        /// </summary>
        /// <param name="command"> Command to be executed in transaction </param>
        public void Add(SqlCommand command)
        {
            try
            {
                if (!localTransActive)
                {
                    con.Open();
                    Debug.WriteLine("ADD CON");
                    transaction = con.BeginTransaction(isolationLevel);
                    localTransActive = true;
                }
                command.Connection = con;
                command.Transaction = transaction;

                commands.Add(command);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Error occured in sql command!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ObjectDisposedException ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("No server connection could be established at the moment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Unknown error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unknown error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Commit method
        /// Commits current transaction if exists
        /// Logs commited queries into txt file
        /// </summary>
        public void Commit()
        {
            try
            {
                if (localTransActive)
                {
                    transaction.Commit();

                    localTransActive = false;

                    con.Close();
                    Log(commands, false);
                    commands.Clear();
                    MessageBox.Show("Commit successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Debug.WriteLine("Queries successfully writen into a database");
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Error occured in sql command!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Commit error");
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("Rollback start");
                MessageBox.Show("Commit error! \nRollback start.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Rollback();
            }
        }

        /// <summary>
        /// Rollback method
        /// Rollback current transaction if exists
        /// Logs ever rollbacked query into txt file
        /// </summary>
        public void Rollback()
        {
            try
            {
                if (localTransActive)
                {
                    transaction.Rollback();

                    localTransActive = false;

                    con.Close();
                    Log(commands, true);
                    commands.Clear();
                    MessageBox.Show("Rollback successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Debug.WriteLine("Rollback successful");
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Error occured in sql command!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Rollback error");
                Debug.WriteLine(ex.ToString());
                MessageBox.Show("Rollback error! \nTerminating transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                localTransActive = false;
                con.Close();
            }
        }

        /// <summary>
        /// Logging method
        /// Logs all given sqlcommands by looping and appending into file that was determined before by boolean
        /// </summary>
        /// <param name="commands"> List of commands to be logged </param>
        /// <param name="rollback"> If its going to log into rollback or commit file </param>
        public static void Log(List<SqlCommand> commands, bool rollback)
        {
            string messageLog;
            string appendPath = rollback ? "rollback_log.txt" : "commit_log.txt";
            for (int i = 0;i < commands.Count; i++)
            {
                try
                {
                    messageLog = DateTime.Now.ToString() + " " + commands[i].CommandText + Environment.NewLine;
                    File.AppendAllText(appendPath, messageLog);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        //BAD
        /// <summary>
        /// Method for retrieving ID's of newly inputed rows
        /// 
        /// </summary>
        /// <param name="insertCommand"> Command of insert from which will be retrieved </param>
        /// <returns> Retrieved ID </returns>
        public int RetrieveId(SqlCommand insertCommand)
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    int id;
                    SqlCommand cmd = new SqlCommand(insertCommand.CommandText + "select SCOPE_IDENTITY();", con);
                    cmd.Transaction = transaction;
                    using (cmd)
                    {
                        object result = cmd.ExecuteScalar();
                        id = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                    return id;
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Error occured in sql command!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Unknown error occured in ID retrieve!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return 0;
        }

        /// <summary>
        /// Setting isolation level manualy outside of class
        /// Used for unit tests
        /// </summary>
        /// <param name="lvl"> New isolation level </param>
        public void SetIsolationLevel(System.Data.IsolationLevel lvl)
        {
            isolationLevel = lvl;
        }

        /// <summary>
        /// Parsing string to IsolationLevel
        /// R
        /// </summary>
        /// <param name="input"></param>
        /// <returns> Returns IsolationLevel unspecified if input incorrect </returns>
        public static System.Data.IsolationLevel IsolationLevelParse(string input)
        {
            if (Enum.TryParse(input, out System.Data.IsolationLevel level))
            {
                return level;
            }
            else
            {
                return System.Data.IsolationLevel.Unspecified;
            }
        }
    }
}
