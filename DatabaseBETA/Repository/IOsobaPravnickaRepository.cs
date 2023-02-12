using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface IOsobaPravnickaRepository
    {
        IEnumerable<OsobaPravnicka> GetAll();
        OsobaPravnicka GetById(int id);
        int InsertRetrieveId(OsobaPravnicka osobaPravnicka);
        void Update(OsobaPravnicka osobaPravnicka, int id);
        void Delete(int id);
    }
}
