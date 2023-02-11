using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class OsobaPravnickaRepository : IOsobaPravnickaRepository, IDisposable
    {
        private string command;
        private GenericRepository<OsobaPravnicka> repository = new GenericRepository<OsobaPravnicka>();

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

        public IEnumerable<OsobaPravnicka> GetAll()
        {
            command = "select * from Osoba_Pravnicka;";
            return repository.GetAll(command);
        }

        public OsobaPravnicka GetById(int id)
        {
            command = string.Format("select * from Osoba_Pravnicka where id = {0};", id);
            return repository.GetById(command);
        }

        public void Insert(OsobaPravnicka osobaPravnicka)
        {
            command = string.Format("insert into Osoba_Pravnicka(nazev_firmy) values ({0});", osobaPravnicka.nazev_firmy);
            repository.Insert(command);
        }

        public void Update(OsobaPravnicka osobaPravnicka)
        {
            command = string.Format("update Osoba_Fyzicka(nazev_firmy) values ({0}) where id={1};", osobaPravnicka.id);
            repository.Update(command);
        }

        public void Delete(OsobaPravnicka osobaPravnicka)
        {
            command = string.Format("delete from Osoba_Pravnicka where id={0} ;", osobaPravnicka.id);
            repository.Delete(command);
        }
    }
}
