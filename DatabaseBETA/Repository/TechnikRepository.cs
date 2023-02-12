using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class TechnikRepository : ITechnikRepository, IDisposable
    {
        private SqlCommand command;
        private string cmdString;
        private SqlConnection con = Database.Instance.Connection;
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
            cmdString = "select * from Technik;";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        public Technik GetById(int id)
        {
            cmdString = "select * from Technik where id=@id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        public void Insert(Technik technik)
        {
            cmdString = "insert into Technik(jmeno,prijmeni,nadrizeny_technik) values (@jmeno,@prijmeni,@nadrizeny_technik);";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("jmeno", technik.jmeno);
            command.Parameters.AddWithValue("prijmeni", technik.prijmeni);
            command.Parameters.AddWithValue("nadrizeny_technik", technik.nadrizeny_technik);
            repository.Insert(command);
        }

        public void Update(Technik technik, int id)
        {
            cmdString = "insert into Technik(jmeno,prijmeni,nadrizeny_technik) values (@jmeno,@prijmeni,@nadrizeny_technik) where id=@id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("jmeno", technik.jmeno);
            command.Parameters.AddWithValue("prijmeni", technik.prijmeni);
            command.Parameters.AddWithValue("nadrizeny_technik", technik.nadrizeny_technik);
            command.Parameters.AddWithValue("id", id);
            repository.Update(command);
        }

        public void Delete(int id)
        {
            cmdString = "delete from Technik where id=@id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            repository.Delete(command);
        }

    }
}
