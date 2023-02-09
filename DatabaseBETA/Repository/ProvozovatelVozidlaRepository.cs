using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class ProvozovatelVozidlaRepository : IProvozovatelVozidlaRepository
    {
        private bool disposed = false;
        private string command, command2;

        private GenericRepository<ProvozovatelVozidla> repository = new GenericRepository<ProvozovatelVozidla>();

        public IEnumerable<ProvozovatelVozidla> GetAll()
        {
            command = "select * from Provozovatel_Vozidla;";
            return repository.GetAll(command);
        }

        public ProvozovatelVozidla GetById(int id)
        {
            command = string.Format("select * from Provozovatel_Vozidla where id = {0};", id);
            return repository.GetById(command);
        }

        public void Insert(ProvozovatelVozidla provozovatel)
        {
            command = string.Format("insert into Provozovatel_Vozidla(osoba_fyzicka_id,osoba_pravnicka_id,adresa_ulice,adresa_cislo_popisne,adresa_psc,adresa_obec,telefonni_cislo,email,adresa_mesto) values ({0},{1},{2},{3},{4},{5},{6},{7},{8});", provozovatel.osoba_fyzicka_id, provozovatel.osoba_pravnicka_id, provozovatel.adresa_ulice, provozovatel.adresa_cislo_popisne, provozovatel.adresa_psc, provozovatel.adresa_obec, provozovatel.telefonni_cislo, provozovatel.email, provozovatel.adresa_mesto);
            repository.Insert(command);
        }

        public void Update(ProvozovatelVozidla provozovatel)
        {
            command = string.Format("update Provozovatel_Vozidla(osoba_fyzicka_id,osoba_pravnicka_id,adresa_ulice,adresa_cislo_popisne,adresa_psc,adresa_obec,telefonni_cislo,email,adresa_mesto) values ({0},{1},{2},{3},{4},{5},{6},{7},{8}) where id={9};", provozovatel.osoba_fyzicka_id, provozovatel.osoba_pravnicka_id, provozovatel.adresa_ulice, provozovatel.adresa_cislo_popisne, provozovatel.adresa_psc, provozovatel.adresa_obec, provozovatel.telefonni_cislo, provozovatel.email, provozovatel.adresa_mesto, provozovatel.id);
            repository.Update(command);
        }

        public void Delete(ProvozovatelVozidla provozovatel)
        {
            command = string.Format("delete from Provozovatel_Vozidla where id={0} ;", provozovatel.id);
            repository.Delete(command);
        }
    }
}
