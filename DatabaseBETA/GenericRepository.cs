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
    /// <summary>
    /// Generic repository class for creating a way to comunicate with UnitOfWork
    /// Using gerneric data type of class to accept any class of entity whatsoever 
    /// 
    /// </summary>
    /// <typeparam name="T"> Class of entity </typeparam>
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

        /// <summary>
        /// Method for retrieving all records from target table using SQL COMMAND
        /// Using SqlReader to get all parameters from received data table
        /// </summary>
        /// <param name="cmd"> Executable command with select from target table </param>
        /// <returns> Enumetable result of target entity filled with data </returns>
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

        /// <summary>
        /// Method for retrieving all records from target table using SQL COMMAND
        /// Using SqlReader to get all parameters from received data table
        /// </summary>
        /// <param name="cmd"> Executable command with select from target table </param>
        /// <returns> Target entity filled with data </returns>
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

        /// <summary>
        /// Executes command by sending to transaction
        /// </summary>
        /// <param name="cmd"> Executable command with insert from target table </param>
        public void Insert(SqlCommand cmd)
        {

            using (cmd)
            {
                UnitOfWork.Instance.Add(cmd);
            }
        }

        /// <summary>
        /// Executes command by sending to transaction
        /// </summary>
        /// <param name="cmd"> Executable command with insert from target table </param>
        /// <returns> Retrieved id </returns>
        public int InsertRetrieveId(SqlCommand cmd)
        {

            using (cmd)
            {
                return UnitOfWork.Instance.RetrieveId(cmd);
            }
        }

        /// <summary>
        /// Executes command by sending to transaction
        /// </summary>
        /// <param name="cmd"> Executable command with update from target table </param>
        public void Update(SqlCommand cmd)
        {

            using (cmd)
            {
                UnitOfWork.Instance.Add(cmd);
            }
        }

        /// <summary>
        /// Executes command by sending to transaction
        /// </summary>
        /// <param name="cmd"> Executable command with delete from target table </param>
        public void Delete(SqlCommand cmd)
        {

            using (cmd)
            {
                UnitOfWork.Instance.Add(cmd);
            }
        }
    }
}
