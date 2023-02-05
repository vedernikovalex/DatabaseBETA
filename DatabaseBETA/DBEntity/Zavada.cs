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
        private int id;
        private string category;
        private string description;

        //Nalez tabulka
        private int nalez_id;
        private int kontrola_id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //nalez
        public int Nalez_id
        {
            get { return nalez_id; }
            set { nalez_id = value; }
        }

        public int Kontrola_id
        {
            get { return kontrola_id; }
            set { kontrola_id = value; }
        }

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
