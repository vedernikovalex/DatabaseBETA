using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class OsobaFyzickaRepository : IOsobaFyzickaRepository, IDisposable
    {
        private SqlCommand command;
        private string cmdString;
        private SqlConnection con = Database.Instance.Connection;

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
            cmdString = "select * from Osoba_Fyzicka;";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        public OsobaFyzicka GetById(int id)
        {
            cmdString = "select * from Osoba_Fyzicka where id = @id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        public int InsertRetrieveId(OsobaFyzicka osobaFyzicka)
        {
            cmdString = "insert into Osoba_Fyzicka(jmeno,prijmeni) values ('@jmeno','@prijmeni'); ";
            command.Parameters.AddWithValue("jmeno", osobaFyzicka.jmeno);
            command.Parameters.AddWithValue("prijmeni", osobaFyzicka.prijmeni);
            int id = repository.InsertRetrieveId(command);
            return id;
        }

        public void Update(OsobaFyzicka osobaFyzicka, int id)
        {
            cmdString = "insert into Osoba_Fyzicka(jmeno,prijmeni) values ('@jmeno','@prijmeni') where id = @id; ";
            command.Parameters.AddWithValue("jmeno", osobaFyzicka.jmeno);
            command.Parameters.AddWithValue("prijmeni", osobaFyzicka.prijmeni);
            command.Parameters.AddWithValue("id", id);
            repository.Update(command);
        }

        public void Delete(int id)
        {
            cmdString = "delete from Osoba_Fyzicka where id= @id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            repository.Delete(command);
        }
    }
}
