using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface IKontrolaRepository
    {
        IEnumerable<Kontrola> GetAll();
        Kontrola GetById(int id);
        void Insert(Kontrola kontrola);
        void Update(Kontrola kontrola, int id);
        void Delete(int id);
    }
}
