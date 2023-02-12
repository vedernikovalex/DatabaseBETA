using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface ITechnikRepository
    {
        IEnumerable<Technik> GetAll();
        Technik GetById(int id);
        void Insert(Technik technik);
        void Update(Technik technik, int id);
        void Delete(int id);
    }
}
