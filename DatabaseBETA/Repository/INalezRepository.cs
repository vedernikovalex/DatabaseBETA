using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface INalezRepository
    {
        IEnumerable<Nalez> GetAll();
        Nalez GetById(int id);
        void Insert(Nalez nalez);
        void Update(Nalez nalez, int id);
        void Delete(int id);
    }
}
