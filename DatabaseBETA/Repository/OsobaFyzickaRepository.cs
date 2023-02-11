using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class OsobaFyzickaRepository : IOsobaFyzickaRepository, IDisposable
    {
        private string command;
        private GenericRepository<OsobaFyzicka> repository = new GenericRepository<OsobaFyzicka>();

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

        public IEnumerable<OsobaFyzicka> GetAll()
        {
            command = "select * from Osoba_Fyzicka;";
            return repository.GetAll(command);
        }

        public OsobaFyzicka GetById(int id)
        {
            command = string.Format("select * from Osoba_Fyzicka where id = {0};", id);
            return repository.GetById(command);
        }

        public void Insert(OsobaFyzicka osobaFyzicka)
        {
            command = string.Format("insert into Osoba_Fyzicka(jmeno,prijmeni) values ({0},{1});", osobaFyzicka.jmeno,osobaFyzicka.prijmeni);
            repository.Insert(command);
        }

        public void Update(OsobaFyzicka osobaFyzicka)
        {
            command = string.Format("update Osoba_Fyzicka(jmeno,prijmeni) values ({0},{1}) where id={2};", osobaFyzicka.id);
            repository.Update(command);
        }

        public void Delete(OsobaFyzicka osobaFyzicka)
        {
            command = string.Format("delete from Osoba_Fyzicka where id={0} ;", osobaFyzicka.id);
            repository.Delete(command);
        }
    }
}
