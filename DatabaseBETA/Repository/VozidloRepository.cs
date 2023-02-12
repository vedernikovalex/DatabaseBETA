using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class VozidloRepository
    {
        private string command;
        private GenericRepository<Vozidlo> repository = new GenericRepository<Vozidlo>();

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

        public IEnumerable<Vozidlo> GetAll()
        {
            command = "select v.ID,v.kategorie_vozidla_ID,v.tovarni_znacka,v.obchodni_oznaceni,v.VIN,v.cislo_technickeho_prukazu,v.najeto_km,v.registracni_znacka,v.datum_prvni_registrace,v.barva,k.nazev from Vozidlo v inner join Kategorie_Vozidla k on k.id = v.kategorie_vozidla_ID;";
            return repository.GetAll(command);
        }

        public Vozidlo GetById(int id)
        {
            command = string.Format("select v.ID,v.kategorie_vozidla_ID,v.tovarni_znacka,v.obchodni_oznaceni,v.VIN,v.cislo_technickeho_prukazu,v.najeto_km,v.registracni_znacka,v.datum_prvni_registrace,v.barva,k.nazev from Vozidlo v inner join Kategorie_Vozidla k on k.id = v.kategorie_vozidla_ID where v.ID = {0};", id);
            return repository.GetById(command);
        }

        public void Insert(Vozidlo vozidlo)
        {
            command = string.Format("insert into Vozidlo(kategorie_vozidla_id,tovarni_znacka,obchodni_oznaceni,VIN,cislo_technickeho_prukazu,najeto_km,registracni_znacka,datum_prvni_registrace,barva) values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9});", vozidlo.kategorie_vozidla_id,vozidlo.tovarni_znacka,vozidlo.obchodni_oznaceni,vozidlo.VIN,vozidlo.cislo_technickeho_prukazu,vozidlo.najeto_km,vozidlo.registracni_znacka,vozidlo.datum_prvni_registrace,vozidlo.barva );
            repository.Insert(command);
        }

        public void Update(Vozidlo vozidlo)
        {
            command = string.Format("update Vozidlo(kategorie_vozidla_id,tovarni_znacka,obchodni_oznaceni,VIN,cislo_technickeho_prukazu,najeto_km,registracni_znacka,datum_prvni_registrace,barva) values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) where id={0};", vozidlo.id, vozidlo.kategorie_vozidla_id, vozidlo.tovarni_znacka, vozidlo.obchodni_oznaceni, vozidlo.VIN, vozidlo.cislo_technickeho_prukazu, vozidlo.najeto_km, vozidlo.registracni_znacka, vozidlo.datum_prvni_registrace, vozidlo.barva);
            repository.Update(command);
        }

        public void Delete(Vozidlo vozidlo)
        {
            command = string.Format("delete from Vozidlo where id={0} ;", vozidlo.id);
            repository.Delete(command);
        }

    }
}
