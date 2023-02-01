using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class UnitOfWork : IDisposable
    {
        private Database database = new Database();
    }
}
