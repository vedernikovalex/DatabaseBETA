using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public interface IZavadaRepository
    {
        IEnumerable<Zavada> GetAll();
        Zavada GetById(int id);
        void Insert(Zavada zavada);
        void Update(Zavada zavada);
        void Delete(Zavada zavada);
    }
}
