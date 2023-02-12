using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class OsobaPravnickaRepository : IOsobaPravnickaRepository, IDisposable
    {
        private SqlCommand command;
        private string cmdString;

        private GenericRepository<OsobaPravnicka> repository = new GenericRepository<OsobaPravnicka>();
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

        public IEnumerable<OsobaPravnicka> GetAll()
        {
            cmdString = "select * from Osoba_Pravnicka;";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        public OsobaPravnicka GetById(int id)
        {
            cmdString = "select * from Osoba_Pravnicka where id = @id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        public int InsertRetrieveId(OsobaPravnicka osobaPravnicka)
        {
            cmdString = "insert into Osoba_Pravnicka(nazev_firmy) values ('@nazev_firmy'); ";
            command.Parameters.AddWithValue("nazev_firmy", osobaPravnicka.nazev_firmy);
            int id = repository.InsertRetrieveId(command);
            return id;
        }

        public void Update(OsobaPravnicka osobaPravnicka, int id)
        {
            cmdString = "insert into Osoba_Pravnicka(nazev_firmy) values ('@nazev_firmy') where id=@id; ";
            command.Parameters.AddWithValue("nazev_firmy", osobaPravnicka.nazev_firmy);
            command.Parameters.AddWithValue("id", id);
            repository.Update(command);
        }

        public void Delete(int id)
        {
            cmdString = "delete from Osoba_Pravnicka where id= @id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            repository.Delete(command);
        }
    }
}
