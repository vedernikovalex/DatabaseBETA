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
        private SqlConnection con2;

        private SqlConnectionStringBuilder conStrBuilder = new SqlConnectionStringBuilder();
        private string connectionString;

        private string databaseName = ConfigurationManager.AppSettings["databaseName"];
        private string databaseSource = ConfigurationManager.AppSettings["databaseSource"];

        /// <summary>
        /// Initializing connection string as windows login
        /// </summary>
        public Database()
        {
            ConnectionStringBuilder();
        }

        /// <summary>
        /// Initializing connection string as user login
        /// </summary>
        public Database(string login, string password)
        {
            ConnectionStringBuilder(login, password);
        }

        public SqlConnection Connection
        {
            get { return con; }
        }

        public SqlConnection Connection2
        {
            get { return con2; }
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
        /// Initializing connection string as windows login
        /// </summary>
        private void ConnectionStringBuilder()
        {
            conStrBuilder.DataSource = @databaseName;
            conStrBuilder.InitialCatalog = databaseSource;
            conStrBuilder.IntegratedSecurity = true;
            connectionString = conStrBuilder.ConnectionString;
            con = new SqlConnection(connectionString);
            con2 = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Initializing connection string as user login
        /// </summary>
        private void ConnectionStringBuilder(string login, string password)
        {
            conStrBuilder.DataSource = @databaseName;
            conStrBuilder.InitialCatalog = databaseSource;
            conStrBuilder.UserID= login;
            conStrBuilder.Password= password;
            connectionString = conStrBuilder.ConnectionString;
            con = new SqlConnection(connectionString);
            con2 = new SqlConnection(connectionString);
        }
    }
}
