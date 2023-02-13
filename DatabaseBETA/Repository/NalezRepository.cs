using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class NalezRepository : INalezRepository, IDisposable
    {
        private SqlCommand command;
        private string cmdString;
        private SqlConnection con = Database.Instance.Connection;

        private GenericRepository<Nalez> repository = new GenericRepository<Nalez>();


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

        public IEnumerable<Nalez> GetAll()
        {
            cmdString = "select n.kontrola_ID,n.zavada_ID,z.kategorie,z.popis from Nalez n inner join Zavada z on z.ID = n.zavada_ID order by n.kontrola_ID";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        public Nalez GetById(int id)
        {
            cmdString = "select n.kontrola_ID,n.zavada_ID,z.kategorie,z.popis from Nalez n inner join Zavada z on z.ID = n.zavada_ID where n.kontrola_ID = @id order by n.kontrola_ID;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        public void Insert(Nalez nalez)
        {
            cmdString = "insert into Nalez(kontrola_ID, zavada_ID) values (@kontrola_ID, @zavada_ID);";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("kontrola_ID", nalez.kontrola_id);
            command.Parameters.AddWithValue("zavada_ID", nalez.zavada_id);
            repository.Insert(command);
        }

        public void Update(Nalez nalez, int id)
        {
            cmdString = "update Nalez set kontrola_ID=@kontrola_ID, zavada_ID=@zavada_ID where id=@id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("kontrola_ID", nalez.kontrola_id);
            command.Parameters.AddWithValue("zavada_ID", nalez.zavada_id);
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
