using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class ZavadaRepository : IZavadaRepository, IDisposable
    {
        private SqlCommand command;
        private string cmdString;
        private SqlConnection con = Database.Instance.Connection;

        private GenericRepository<Zavada> repository = new GenericRepository<Zavada>() ;


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

        public IEnumerable<Zavada> GetAll()
        {
            cmdString = "select z.ID,z.kategorie,z.popis,n.ID,n.kontrola_ID from Zavada z inner join Nalez n on z.ID = n.zavada_ID";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        public Zavada GetById(int id)
        {
            cmdString = "select z.ID,z.kategorie,z.popis,n.ID,n.kontrola_ID from Zavada z inner join Nalez n on z.ID = n.zavada_ID where n.kontrola_ID = @id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        public void Insert(Zavada zavada)
        {
            cmdString = "insert into Zavada(kategorie, popis) values (@kategorie, @popis);";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("kategorie", zavada.kategorie);
            command.Parameters.AddWithValue("popis", zavada.popis);
            repository.Insert(command);
        }

        public void Update(Zavada zavada, int id)
        {
            cmdString = "insert into Zavada(kategorie, popis) values (@kategorie, @popis) where id=@id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("kategorie", zavada.kategorie);
            command.Parameters.AddWithValue("popis", zavada.popis);
            command.Parameters.AddWithValue("id", id);
            repository.Update(command);
        }

        public void Delete(int id)
        {
            cmdString = "delete from Zavada where id=@id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            repository.Delete(command);
        }
    }
}
