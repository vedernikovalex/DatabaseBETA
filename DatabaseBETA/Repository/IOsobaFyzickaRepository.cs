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
        void Insert(OsobaFyzicka osobaFyzicka);
        void Update(OsobaFyzicka osobaFyzicka);
        void Delete(OsobaFyzicka osobaFyzicka);
    }
}
