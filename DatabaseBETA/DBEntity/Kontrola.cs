using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DatabaseBETA
{
    public class Kontrola
    {
        public int id;
        public int vozidlo_id;
        public int druh_id;
        public bool plny_rozsah;
        public DateTime datum;
        public string poznamka;
        public int technik_id;
        public int provozovatel_vozidla_id;

        public Kontrola() { }

        public Kontrola(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.vozidlo_id = reader.GetInt32(1);
            this.druh_id = reader.GetInt32(2);
            int rozsah = reader.GetInt32(3);
            this.plny_rozsah = rozsah == 1 ? true : false;
            this.datum = reader.GetDateTime(4);
            this.poznamka = reader.IsDBNull(5) ? "" : reader.GetString(5);
            this.technik_id = reader.GetInt32(6);
            this.provozovatel_vozidla_id = reader.GetInt32(7);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.Kontrola();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["vozidlo_id"] = vozidlo_id;
            row["druh_id"] = druh_id;
            row["plny_rozsah"] = plny_rozsah;
            row["datum"] = datum;
            row["poznamka"] = poznamka;
            row["technik_id"] = technik_id;
            row["provozovatel_vozidla_id"] = provozovatel_vozidla_id;
            dt.Rows.Add(row);

            return dt;
        }
    }
}
