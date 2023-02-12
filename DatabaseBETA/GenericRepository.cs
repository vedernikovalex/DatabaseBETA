using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class GenericRepository<T> where T : class, new()
    {
        private SqlConnection con = Database.Instance.Connection;
        private SqlCommand cmd;

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<T> GetAll(SqlCommand cmd)
        {
            con.Open();
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

        public T GetById(SqlCommand cmd)
        {
            con.Open();
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

        public void Insert(SqlCommand cmd)
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            using (cmd)
            {
                UnitOfWork.Instance.Add(cmd);
            }
        }

        public int InsertRetrieveId(SqlCommand cmd)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            using (cmd)
            {
                return UnitOfWork.Instance.RetrieveId(cmd);
            }
        }

        public void Update(SqlCommand cmd)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            using (cmd)
            {
                UnitOfWork.Instance.Add(cmd);
            }
        }

        public void Delete(SqlCommand cmd)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            using (cmd)
            {
                UnitOfWork.Instance.Add(cmd);
            }
        }
    }
}
