using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    /// <summary>
    /// Class representing methods of basic CRUD functionality 
    /// Building SQLCOMMANDS with predefined parameters
    /// IDiposable
    /// </summary>
    public class KontrolaRepository : IKontrolaRepository, IDisposable
    {
        private SqlCommand command;
        private string cmdString;
        private SqlConnection con = Database.Instance.Connection;
        /// <summary>
        /// Generic repository initialization with current Entity class to execute methods
        /// </summary>
        private GenericRepository<Kontrola> repository = new GenericRepository<Kontrola>();

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

        /// <summary>
        /// Get all method
        /// building sqlcommand
        /// </summary>
        /// <returns> Result of sqlcommand </returns>
        public IEnumerable<Kontrola> GetAll()
        {
            cmdString = "select k.ID,k.vozidlo_ID,k.druh_kontroly_ID,k.technik_ID,k.provozovatel_vozidla_ID,k.plny_rozsah,k.datum,k.poznamka,d.nazev from Kontrola k inner join Druh_Kontroly d on k.druh_kontroly_ID = d.ID;";
            command = new SqlCommand(cmdString, con);
            return repository.GetAll(command);
        }

        /// <summary>
        /// Get by id method
        /// building sqlcommand with input parameter
        /// </summary>
        /// <returns> Result of sqlcommand </returns>
        public Kontrola GetById(int id)
        {
            cmdString = "select k.ID,k.vozidlo_ID,k.druh_kontroly_ID,k.technik_ID,k.provozovatel_vozidla_ID,k.plny_rozsah,k.datum,k.poznamka,d.nazev from Kontrola k inner join Druh_Kontroly d on k.druh_kontroly_ID = d.ID where k.id = @id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            return repository.GetById(command);
        }

        /// <summary>
        /// Insert into table 
        /// building sqlcommand with input parameter as current entity
        /// </summary>
        public void Insert(Kontrola kontrola)
        {
            cmdString = "INSERT INTO Kontrola(vozidlo_ID, druh_kontroly_ID, technik_ID, provozovatel_vozidla_ID, plny_rozsah, datum, poznamka) VALUES (@vozidlo_ID, @druh_kontroly_ID, @technik_ID, @provozovatel_vozidla_ID, @plny_rozsah, @datum, @poznamka);";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("vozidlo_ID", kontrola.vozidlo_id);
            command.Parameters.AddWithValue("druh_kontroly_ID", kontrola.druh_kontroly_id);
            command.Parameters.AddWithValue("technik_ID", kontrola.technik_id);
            command.Parameters.AddWithValue("provozovatel_vozidla_ID", kontrola.provozovatel_vozidla_id);
            command.Parameters.AddWithValue("plny_rozsah", kontrola.plny_rozsah);
            command.Parameters.AddWithValue("datum", kontrola.datum);
            command.Parameters.AddWithValue("poznamka", string.IsNullOrWhiteSpace(kontrola.poznamka) ? (object)DBNull.Value : kontrola.poznamka);
            repository.Insert(command);
        }

        /// <summary>
        /// Update existing entity in table by id 
        /// building sqlcommand with input parameter as current entity and id
        /// </summary>
        public void Update(Kontrola kontrola, int id)
        {
            cmdString = "update Kontrola set vozidlo_ID=@vozidlo_ID, druh_kontroly_ID=@druh_kontroly_ID, technik_ID=@technik_ID, provozovatel_vozidla_ID=@provozovatel_vozidla_ID, plny_rozsah=@plny_rozsah, datum=@datum, poznamka=@poznamka where id=@id;";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("vozidlo_ID", kontrola.vozidlo_id);
            command.Parameters.AddWithValue("druh_kontroly_ID", kontrola.druh_kontroly_id);
            command.Parameters.AddWithValue("technik_ID", kontrola.technik_id);
            command.Parameters.AddWithValue("provozovatel_vozidla_ID", kontrola.provozovatel_vozidla_id);
            command.Parameters.AddWithValue("plny_rozsah", kontrola.plny_rozsah);
            command.Parameters.AddWithValue("datum", kontrola.datum);
            command.Parameters.AddWithValue("poznamka", string.IsNullOrWhiteSpace(kontrola.poznamka) ? (object)DBNull.Value : kontrola.poznamka);
            command.Parameters.AddWithValue("id", id);
            repository.Update(command);
        }

        /// <summary>
        /// Deletinon from table of current entity by id 
        /// building sqlcommand with input parameter as current entity id
        /// </summary>
        public void Delete(int id)
        {
            cmdString = "delete from Kontrola where id=@id; ";
            command = new SqlCommand(cmdString, con);
            command.Parameters.AddWithValue("id", id);
            repository.Delete(command);
        }

    }
}
