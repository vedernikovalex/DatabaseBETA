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
        public int druh_kontroly_id;
        public int technik_id;
        public int provozovatel_vozidla_id;
        public bool plny_rozsah;
        public DateTime datum;
        public string poznamka;
        //druh_kontroly
        public string nazev_kontroly;

        public Kontrola() { }

        public Kontrola(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.vozidlo_id = reader.GetInt32(1);
            this.druh_kontroly_id = reader.GetInt32(2);
            this.technik_id = reader.GetInt32(3);
            this.provozovatel_vozidla_id = reader.GetInt32(4);
            this.plny_rozsah = reader.GetBoolean(5);
            this.datum = reader.GetDateTime(6);
            this.poznamka = reader.IsDBNull(7) ? "" : reader.GetString(7);
            //druh_kontroly
            this.nazev_kontroly = reader.GetString(8);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.Kontrola();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["vozidlo_id"] = vozidlo_id;
            row["druh_kontroly_id"] = druh_kontroly_id;
            row["technik_id"] = technik_id;
            row["provozovatel_vozidla_id"] = provozovatel_vozidla_id;
            row["plny_rozsah"] = plny_rozsah;
            row["datum"] = datum;
            row["poznamka"] = poznamka;
            //druh_kontroly
            row["nazev_kontroly"] = nazev_kontroly;
            dt.Rows.Add(row);

            return dt;
        }
    }
}
