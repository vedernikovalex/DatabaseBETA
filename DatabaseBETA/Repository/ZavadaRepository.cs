using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class ZavadaRepository : IZavadaRepository, IDisposable
    {
        private bool disposed = false;
        string command;

        public IEnumerable<Zavada> GetAll()
        {
            command = "select * from Zavady_vozidla;";
            return 
        }
    }
}
