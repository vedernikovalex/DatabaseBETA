using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class ZavadaRepository : IZavadaRepository//, IDisposable
    {
        private string command;
        
        private GenericRepository<Zavada> repository = new GenericRepository<Zavada>() ;

        public IEnumerable<Zavada> GetAll()
        {
            command = "select z.ID,z.kategorie,z.popis,n.ID,n.kontrola_ID from Zavada z inner join Nalez n on z.ID = n.zavada_ID;";
            return repository.GetAll(command);
        }

        public Zavada GetById(int id)
        {
            command = string.Format("select z.ID,z.kategorie,z.popis,n.ID,n.kontrola_ID from Zavada z inner join Nalez n on z.ID = n.zavada_ID where n.kontrola_ID = {0};", id);
            return repository.GetById(command);
        }

        public void Insert(Zavada zavada)
        {
            command = string.Format("insert into Zavada(kategorie, popis) values ({0},{1});",zavada.kategorie,zavada.popis);
            repository.Insert(command);
        }

        public void Update(Zavada zavada)
        {
            command = string.Format("update Zavada(kategorie, popis) values ({0},{1}) where id={2};", zavada.kategorie, zavada.popis, zavada.id);
            repository.Update(command);
        }

        public void Delete(Zavada zavada)
        {
            command = string.Format("delete from Zavada where id={0} ;", zavada.id);
            repository.Delete(command);
        }
    }
}
