using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatabaseBETA
{
    public class UnitOfWork //: IDisposable
    {
        private static UnitOfWork instance = null;
        private static readonly object locker = new object();

        private List<SqlCommand> commands = new List<SqlCommand>();

        private SqlConnection con = Database.Instance.Connection;
        private SqlTransaction transaction;
        public bool localTransActive = false;

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

        public void Add(SqlCommand command)
        {
            try
            {
                if (!localTransActive)
                {
                    Debug.WriteLine("ADD CON");
                    transaction = con.BeginTransaction();
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
                    MessageBox.Show("Error occured in sql command. Please make sure given inputs are correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    Debug.WriteLine("Queries successfully writen into a database");
                }
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

                    Debug.WriteLine("Rollback successful");
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Rollback error");
                Debug.WriteLine(ex.ToString());
                MessageBox.Show("Rollback error! \nTerminating transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                localTransActive = false;
                con.Close();
            }
        }

        public static void Log(List<SqlCommand> commands, bool rollback)
        {
            string messageLog;
            for (int i = 0;i < commands.Count; i++)
            {
                messageLog = DateTime.Now.ToString() + " " + commands[i].CommandText + Environment.NewLine;
                if (!rollback)
                {
                    File.AppendAllText("commit_log.txt", messageLog);
                }
                else
                {
                    File.AppendAllText("rollback_log.txt", messageLog);
                }
            }
        }

        //BAD
        public int RetrieveId(SqlCommand insertCommand)
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                int id;
                SqlCommand cmd = new SqlCommand(insertCommand.CommandText+"select SCOPE_IDENTITY();", con);
                cmd.Transaction = transaction;
                using (cmd)
                {
                    object result = cmd.ExecuteScalar();
                    id = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
                return id;
            }
            return 0;
        }
    }
}
