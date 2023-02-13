using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class ProvozovatelVozidlaRepository : IProvozovatelVozidlaRepository , IDisposable
    {
        private SqlCommand command;
        private string cmdString;

        private GenericRepository<ProvozovatelVozidla> repository = new GenericRepository<ProvozovatelVozidla>();
        private SqlConnection con = Database.Instance.Connection;
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

        public IEnumerable<ProvozovatelVozidla> GetAll()
        {
            cmdString = "select * from Provozovatel_Vozidla;";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        public ProvozovatelVozidla GetById(int id)
        {
            cmdString = "select* from Provozovatel_Vozidla where id = @id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        public void Insert(ProvozovatelVozidla provozovatel)
        {
            cmdString = "INSERT INTO Provozovatel_Vozidla (osoba_fyzicka_id, osoba_pravnicka_id, adresa_ulice, adresa_cislo_popisne, adresa_psc, adresa_obec, telefonni_cislo, email, adresa_mesto) VALUES (@osoba_fyzicka_id, @osoba_pravnicka_id, @adresa_ulice, @adresa_cislo_popisne, @adresa_psc, @adresa_obec, @telefonni_cislo, @email, @adresa_mesto);";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("osoba_fyzicka_id", provozovatel.osoba_fyzicka_id != 0 ? (object)provozovatel.osoba_fyzicka_id : DBNull.Value);
            command.Parameters.AddWithValue("osoba_pravnicka_id", provozovatel.osoba_pravnicka_id != 0 ? (object)provozovatel.osoba_pravnicka_id : DBNull.Value);
            command.Parameters.AddWithValue("adresa_ulice", provozovatel.adresa_ulice);
            command.Parameters.AddWithValue("adresa_cislo_popisne", provozovatel.adresa_cislo_popisne);
            command.Parameters.AddWithValue("adresa_psc", provozovatel.adresa_psc);
            command.Parameters.AddWithValue("adresa_obec", provozovatel.adresa_obec);
            command.Parameters.AddWithValue("telefonni_cislo", provozovatel.telefonni_cislo);
            command.Parameters.AddWithValue("email", provozovatel.email);
            command.Parameters.AddWithValue("adresa_mesto", provozovatel.adresa_mesto);
            repository.Insert(command);
        }

        public void Update(ProvozovatelVozidla provozovatel, int id)
        {
            cmdString = "update Provozovatel_Vozidla set osoba_fyzicka_id=@osoba_fyzicka_id, osoba_pravnicka_id=@osoba_pravnicka_id, adresa_ulice=@adresa_ulice, adresa_cislo_popisne=@adresa_cislo_popisne, adresa_psc=@adresa_psc, adresa_obec=@adresa_obec, telefonni_cislo=@telefonni_cislo, email=@email, adresa_mesto=@adresa_mesto where id = @id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("osoba_fyzicka_id", provozovatel.osoba_fyzicka_id != 0 ? (object)provozovatel.osoba_fyzicka_id : DBNull.Value);
            command.Parameters.AddWithValue("osoba_pravnicka_id", provozovatel.osoba_pravnicka_id != 0 ? (object)provozovatel.osoba_pravnicka_id : DBNull.Value);
            command.Parameters.AddWithValue("adresa_ulice", provozovatel.adresa_ulice);
            command.Parameters.AddWithValue("adresa_cislo_popisne", provozovatel.adresa_cislo_popisne);
            command.Parameters.AddWithValue("adresa_psc", provozovatel.adresa_psc);
            command.Parameters.AddWithValue("adresa_obec", provozovatel.adresa_obec);
            command.Parameters.AddWithValue("telefonni_cislo", provozovatel.telefonni_cislo);
            command.Parameters.AddWithValue("email", provozovatel.email);
            command.Parameters.AddWithValue("adresa_mesto", provozovatel.adresa_mesto);

            command.Parameters.AddWithValue("id", id);
            repository.Update(command);
        }

        public void Delete(int id)
        {
            cmdString = "delete from Provozovatel_Vozidla where id = @id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            repository.Delete(command);
        }
    }
}
