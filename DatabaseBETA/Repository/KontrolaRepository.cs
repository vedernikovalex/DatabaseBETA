using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class KontrolaRepository : IKontrolaRepository, IDisposable
    {
        private string command;
        private GenericRepository<Kontrola> repository = new GenericRepository<Kontrola>();

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

        public IEnumerable<Kontrola> GetAll()
        {
            command = "select * from Kontrola;";
            return repository.GetAll(command);
        }

        public Kontrola GetById(int id)
        {
            command = string.Format("select * from Kontrola where id = {0};", id);
            return repository.GetById(command);
        }

        public void Insert(Kontrola kontrola)
        {
            command = string.Format("insert into Kontrola(vozidlo_ID,druh_ID,plny_rozsah,datum,poznamka,technik_ID,provozovael_vozidla_ID) values ({0},{1},{2},{3},{4},{5},{6});", kontrola.vozidlo_id,kontrola.druh_id,kontrola.plny_rozsah,kontrola.datum,kontrola.poznamka,kontrola.technik_id,kontrola.provozovatel_vozidla_id);
            repository.Insert(command);
        }

        public void Update(Kontrola kontrola)
        {
            command = string.Format("update Kontrola(vozidlo_ID,druh_ID,plny_rozsah,datum,poznamka,technik_ID,provozovael_vozidla_ID) values ({1},{2},{3},{4},{5},{6},{7}) where id={0};", kontrola.id, kontrola.vozidlo_id, kontrola.druh_id, kontrola.plny_rozsah, kontrola.datum, kontrola.poznamka, kontrola.technik_id, kontrola.provozovatel_vozidla_id);
            repository.Update(command);
        }

        public void Delete(Kontrola kontrola)
        {
            command = string.Format("delete from Kontrola where id={0} ;", kontrola.id);
            repository.Delete(command);
        }

    }
}
