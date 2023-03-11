using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    /// <summary>
    /// Database singleton class
    /// contains SqlConnection
    /// Builds ConnectionString in its constructor
    /// </summary>
    public sealed class Database : IDatabase
    {
        private static Database instance = null;
        private static readonly object locker = new object();

        private SqlConnection con;
        private string connectionString;

        private string databaseName = ConfigurationManager.AppSettings["databaseName"];
        private string databaseSource = ConfigurationManager.AppSettings["databaseSource"];

        /// <summary>
        /// Initializing connection string as windows login
        /// </summary>
        public Database()
        {

        }

        /// <summary>
        /// Initializing connection string as user login
        /// </summary>
        public Database(string login, string password)
        {
            con = ConnectionStringBuilder(login, password);
            con.Open();
            Debug.WriteLine(con.ConnectionString);
        }

        public SqlConnection Connection
        {
            get {
                Debug.WriteLine(con.ConnectionString); 
                return con; }
        }

        public static Database Instance
        {
            get
            {
                lock(locker)
                {
                    if(instance == null)
                    {
                        instance = new Database();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Initializing connection string as user login
        /// </summary>
        private SqlConnection ConnectionStringBuilder(string login, string password)
        {
            string connectionString = "Data Source=193.85.203.188;Initial Catalog=vedernikov;User ID=vedernikov;Password=_20alex04_;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
