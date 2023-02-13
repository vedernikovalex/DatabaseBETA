using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseBETA
{
    public class Zavada
    {
        public int id;
        public char kategorie;
        public string popis;
        //Nalez
        //public int nalez_id;
        //public int kontrola_id;

        public Zavada()
        {

        }

        public Zavada(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.kategorie = char.Parse(reader.GetString(1));
            this.popis = reader.GetString(2);
            //nalez
            //this.nalez_id = reader.GetInt32(4);
            //this.kontrola_id = reader.GetInt32(3);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.Zavada();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["kategorie"] = kategorie;
            row["popis"] = popis;
            //nalez
            //row["nalez_id"] = nalez_id;
            //row["kontrola_id"] = kontrola_id;

            dt.Rows.Add(row);

            return dt;
        }
    }
}
