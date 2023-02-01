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
    public sealed class Database : IDatabase
    {
        private static Database instance = null;
        private static readonly object locker = new object();

        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlCommand, output, loginCredentials, passwordCredentials;

        private SqlConnectionStringBuilder conStrBuilder = new SqlConnectionStringBuilder();
        private string connectionString;

        private ArrayList entities = new ArrayList();

        public Database()
        {
            ConnectionStringBuilder();
        }

        public static Database Instance
        {
            get
            {
                lock(locker)
                {
                    if(instance == null)
                    {
                        instance= new Database();
                    }
                    return instance;
                }
            }
        }

        private void ConnectionStringBuilder()
        {
            conStrBuilder.DataSource = @"(LocalDb)\beta";
            conStrBuilder.InitialCatalog = "technicka_kontrola";
            conStrBuilder.IntegratedSecurity = true;
            connectionString= conStrBuilder.ConnectionString;
        }

        public void Connect()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Debug.WriteLine(con.State);
                    sqlCommand = "select * from Kontrola;";
                    command = new SqlCommand(sqlCommand, con);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        output = output + reader.GetValue(0);
                    }
                    MessageBox.Show(output);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        public SqlConnection GetDBConnection()
        {
            SqlConnection con = new SqlConnection();
            return con;
        }
    }
}
