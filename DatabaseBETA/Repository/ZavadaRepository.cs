using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class ZavadaRepository : IZavadaRepository//, IDisposable
    {
        private bool disposed = false;
        private string command, command2;
        
        private GenericRepository<Zavada> repository = new GenericRepository<Zavada>();

        public IEnumerable<Zavada> GetAll()
        {
            command = "select * from Zavady_vozidla;";
            return repository.GetAll(command);
        }

        public Zavada GetById()
        {
            command = "select * from Zavady_vozidla where 'Identifikacni cislo zavady';";
            return repository.GetById(command);
        }

        public void Insert(Zavada zavada)
        {
            command = string.Format("insert into Zavada(kategorie, popis) values ({0},{1});",zavada.Category,zavada.Description);
            command2 = string.Format("insert into Nalez(kontrola_ID, zavada_ID) values({0},{1});",zavada.Kontrola_id,zavada.Id);
        }

        public void Update(Zavada zavada)
        {

        }

        public void Delete(Zavada zavada)
        {

        }
    }
}
