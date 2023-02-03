using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class UnitOfWork : IDisposable
    {
        private static UnitOfWork instance = null;
        private static readonly object locker = new object();

        private SqlConnection con = Database.Instance.GetDBConnection();
        public List<string> queries = new List<string>();

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

        public void Commit()
        {

        }

    }
}
