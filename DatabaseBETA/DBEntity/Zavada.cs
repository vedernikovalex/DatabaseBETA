using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class Zavada
    {
        public int id;
        public string category;
        public string description;

        //Nalez tabulka
        public int nalez_id;
        public int kontrola_id;

        public Zavada()
        {

        }

        public Zavada(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.category = reader.GetString(1);
            this.description = reader.GetString(2);
            //get nalez_id (table id)
            this.nalez_id = reader.GetInt32(4); // WRONG ID
            this.kontrola_id = reader.GetInt32(3);
        }

        public override string? ToString()
        {
            return string.Format("ID: {0} | Category: {1} | Description: {2} | Nalez_id: {3} | Kontrola_id: {4} ",id,category,description,nalez_id,kontrola_id);
        }
    }
}
