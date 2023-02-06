using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface IProvozovatelVozidlaRepository
    {
        IEnumerable<ProvozovatelVozidla> GetAll();
        ProvozovatelVozidla GetById(int id);
        void Insert(ProvozovatelVozidla provozovatel);
        void Update(ProvozovatelVozidla provozovatel);
        void Delete(ProvozovatelVozidla provozovatel);
    }
}
