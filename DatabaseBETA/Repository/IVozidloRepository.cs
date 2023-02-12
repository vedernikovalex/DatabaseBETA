using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface IVozidloRepository
    {
        IEnumerable<Vozidlo> GetAll();
        Vozidlo GetById(int id);
        void Insert(Vozidlo vozidlo);
        void Update(Vozidlo vozidlo, int id);
        void Delete(int id);
    }
}
