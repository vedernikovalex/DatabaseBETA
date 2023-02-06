﻿using System;
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
        
        private GenericRepository<Zavada> repository = new GenericRepository<Zavada>() ;

        public IEnumerable<Zavada> GetAll()
        {
            command = "select * from Zavady_vozidla;";
            return repository.GetAll(command);
        }

        public Zavada GetById(int id)
        {
            command = string.Format("select * from Zavady_vozidla where 'Identifikacni cislo zavady' = {0};",id);
            return repository.GetById(command);
        }

        public void Insert(Zavada zavada)
        {
            command = string.Format("insert into Zavada(kategorie, popis) values ({0},{1});",zavada.Category,zavada.Description);
            repository.Insert(command);
        }

        public void Update(Zavada zavada)
        {
            command = string.Format("update Zavada(kategorie, popis) values ({0},{1}) where id={2};", zavada.Category, zavada.Description, zavada.Id);
            repository.Update(command);
        }

        public void Delete(Zavada zavada)
        {
            command = string.Format("delete from Zavada where id={0} ;", zavada.Id);
            repository.Delete(command);
        }
    }
}
