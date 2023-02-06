using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class GenericRepository<T> where T : class, new()
    {
        private SqlConnection con = Database.Instance.Connection;
        private SqlCommand cmd;

        public IEnumerable<T> GetAll(string command)
        {
            con.Open();
            cmd = new SqlCommand(command,con);
            using (cmd)
            {
                using (var reader = cmd.ExecuteReader())
                {
                    var data = new List<T>();
                    while (reader.Read())
                    {
                        data.Add((T)Activator.CreateInstance(typeof(T), reader));
                    }
                    con.Close();

                    IEnumerable<T> result = data;
                    return result;
                }
            }
        }

        public T GetById(string command)
        {
            con.Open();
            cmd = new SqlCommand(command, con);
            using (cmd)
            {
                using (var reader = cmd.ExecuteReader())
                {
                    var data = new T();
                    while (reader.Read())
                    {
                        data = (T)Activator.CreateInstance(typeof(T), reader);
                    }
                    con.Close();

                    T result = data;
                    return result;
                }
            }
        }

        public void Insert(string command)
        {
            con.Open();
            cmd = new SqlCommand(command, con);
            using (cmd)
            {
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Update(string command)
        {
            con.Open();
            cmd = new SqlCommand(command, con);
            using (cmd)
            {
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Delete(string command)
        {
            con.Open();
            cmd = new SqlCommand(command, con);
            using (cmd)
            {
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
