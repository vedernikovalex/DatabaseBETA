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
        private bool localTransActive = false;

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
            if (!localTransActive)
            {
                con.Open();
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
            catch(Exception ex) 
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void Commit(SqlTransaction transaction)
        {
            try
            {
                transaction.Commit();

                localTransActive = false;

                con.Close();
                Log(commands, true);
                commands.Clear();

                Debug.WriteLine("Queries successfully writen to a database");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Commit error");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Rollback start");
                Rollback(transaction);
            }
        }

        public void Rollback(SqlTransaction transaction)
        {
            try
            {
                transaction.Rollback();

                localTransActive = false;

                con.Close();
                Log(commands, true);
                commands.Clear();

                Debug.WriteLine("Rollback successful");
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Rollback error");
                Debug.WriteLine(ex.Message);

                localTransActive = false;
                con.Close();
            }
        }

        public static void Log(List<SqlCommand> commands, bool rollback)
        {
            string messageLog;
            for (int i = 0;i < commands.Count; i++)
            {
                messageLog = DateTime.Now.ToString() + commands[i].CommandText + Environment.NewLine;
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
    }
}
