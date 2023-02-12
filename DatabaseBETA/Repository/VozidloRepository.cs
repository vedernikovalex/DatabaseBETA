using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class VozidloRepository
    {
        private SqlCommand command;
        private string cmdString;
        private SqlConnection con = Database.Instance.Connection;
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
            cmdString = "select v.ID,v.kategorie_vozidla_ID,v.tovarni_znacka,v.obchodni_oznaceni,v.VIN,v.cislo_technickeho_prukazu,v.najeto_km,v.registracni_znacka,v.datum_prvni_registrace,v.barva,k.nazev from Vozidlo v inner join Kategorie_Vozidla k on k.id = v.kategorie_vozidla_ID;";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        public Vozidlo GetById(int id)
        {
            cmdString = "select v.ID,v.kategorie_vozidla_ID,v.tovarni_znacka,v.obchodni_oznaceni,v.VIN,v.cislo_technickeho_prukazu,v.najeto_km,v.registracni_znacka,v.datum_prvni_registrace,v.barva,k.nazev from Vozidlo v inner join Kategorie_Vozidla k on k.id = v.kategorie_vozidla_ID where v.ID =@id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        public void Insert(Vozidlo vozidlo)
        {
            cmdString = "insert into Vozidlo(kategorie_vozidla_id,tovarni_znacka,obchodni_oznaceni,VIN,cislo_technickeho_prukazu,najeto_km,registracni_znacka,datum_prvni_registrace,barva) values (@kategorie_vozidla_id,@tovarni_znacka,@obchodni_oznaceni,@VIN,@cislo_technickeho_prukazu,@najeto_km,@registracni_znacka,@datum_prvni_registrace,@barva);";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("kategorie_vozidla_id", vozidlo.kategorie_vozidla_id);
            command.Parameters.AddWithValue("tovarni_znacka", vozidlo.tovarni_znacka);
            command.Parameters.AddWithValue("obchodni_oznaceni", vozidlo.obchodni_oznaceni);
            command.Parameters.AddWithValue("VIN", vozidlo.VIN);
            command.Parameters.AddWithValue("cislo_technickeho_prukazu", vozidlo.cislo_technickeho_prukazu);
            command.Parameters.AddWithValue("najeto_km", vozidlo.najeto_km);
            command.Parameters.AddWithValue("registracni_znacka", vozidlo.registracni_znacka);
            command.Parameters.AddWithValue("datum_prvni_registrace", vozidlo.datum_prvni_registrace == DateTime.MinValue ? (object)DBNull.Value : vozidlo.datum_prvni_registrace);
            command.Parameters.AddWithValue("barva", vozidlo.barva);
            repository.Insert(command);
        }

        public void Update(Vozidlo vozidlo, int id)
        {
            cmdString = "insert into Vozidlo(kategorie_vozidla_id,tovarni_znacka,obchodni_oznaceni,VIN,cislo_technickeho_prukazu,najeto_km,registracni_znacka,datum_prvni_registrace,barva) values (@kategorie_vozidla_id,@tovarni_znacka,@obchodni_oznaceni,@VIN,@cislo_technickeho_prukazu,@najeto_km,@registracni_znacka,@datum_prvni_registrace,@barva) where id=@id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("kategorie_vozidla_id", vozidlo.kategorie_vozidla_id);
            command.Parameters.AddWithValue("tovarni_znacka", vozidlo.tovarni_znacka);
            command.Parameters.AddWithValue("obchodni_oznaceni", vozidlo.obchodni_oznaceni);
            command.Parameters.AddWithValue("VIN", vozidlo.VIN);
            command.Parameters.AddWithValue("cislo_technickeho_prukazu", vozidlo.cislo_technickeho_prukazu);
            command.Parameters.AddWithValue("najeto_km", vozidlo.najeto_km);
            command.Parameters.AddWithValue("registracni_znacka", vozidlo.registracni_znacka);
            command.Parameters.AddWithValue("datum_prvni_registrace", vozidlo.datum_prvni_registrace == DateTime.MinValue ? (object)DBNull.Value : vozidlo.datum_prvni_registrace);
            command.Parameters.AddWithValue("barva", vozidlo.barva);
            command.Parameters.AddWithValue("id", id);
            repository.Update(command);
        }

        public void Delete(int id)
        {
            cmdString = "delete from Vozidlo where id=@id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            repository.Delete(command);
        }

    }
}
