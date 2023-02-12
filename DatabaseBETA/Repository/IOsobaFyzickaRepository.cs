using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface IOsobaFyzickaRepository
    {
        IEnumerable<OsobaFyzicka> GetAll();
        OsobaFyzicka GetById(int id);
        int InsertRetrieveId(OsobaFyzicka osobaFyzicka);
        void Update(OsobaFyzicka osobaFyzicka, int id);
        void Delete(int id);
    }
}
