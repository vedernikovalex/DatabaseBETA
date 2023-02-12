using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class TechnikRepository : ITechnikRepository, IDisposable
    {
        private string command;
        private GenericRepository<Technik> repository = new GenericRepository<Technik>();

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    repository.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Technik> GetAll()
        {
            command = "select * from Technik;";
            return repository.GetAll(command);
        }

        public Technik GetById(int id)
        {
            command = string.Format("select * from Technik where id = {0};", id);
            return repository.GetById(command);
        }

        public void Insert(Technik technik)
        {
            command = string.Format("insert into Technik(jmeno,prijmeni,nadrizeny_technik) values ({0},{1});", technik.jmeno, technik.prijmeni, technik.nadrizeny_technik);
            repository.Insert(command);
        }

        public void Update(Technik technik)
        {
            command = string.Format("update Technik(jmeno,prijmeni,nadrizeny_technik) values ({1},{2},{3}) where id={0};", technik.id, technik.jmeno, technik.prijmeni, technik.nadrizeny_technik);
            repository.Update(command);
        }

        public void Delete(Technik technik)
        {
            command = string.Format("delete from Technik where id={0} ;", technik.id);
            repository.Delete(command);
        }

    }
}
