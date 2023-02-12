using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class ProvozovatelVozidla
    {
        public int id;
        public int osoba_fyzicka_id = 0;
        public int osoba_pravnicka_id = 0;
        public string adresa_ulice;
        public string adresa_cislo_popisne;
        public int adresa_psc;
        public string adresa_obec;
        public int telefonni_cislo;
        public string email;
        public string adresa_mesto;

        public ProvozovatelVozidla()
        {

        }

        public ProvozovatelVozidla(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.osoba_fyzicka_id = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
            this.osoba_pravnicka_id = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
            this.adresa_ulice =  reader.GetString(3);
            this.adresa_cislo_popisne =  reader.GetString(4);
            this.adresa_psc =  reader.GetInt32(5);
            this.adresa_obec =  reader.GetString(6);
            this.telefonni_cislo =  reader.GetInt32(7);
            this.email =  reader.GetString(8);
            this.adresa_mesto =  reader.GetString(9);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.ProvozovatelVozidlaTable();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["osoba_fyzicka_id"] = osoba_fyzicka_id;
            row["osoba_pravnicka_id"] = osoba_pravnicka_id;
            row["adresa_ulice"] = adresa_ulice;
            row["adresa_cislo_popisne"] = adresa_cislo_popisne;
            row["adresa_psc"] = adresa_psc;
            row["adresa_obec"] = adresa_obec;
            row["telefonni_cislo"] = telefonni_cislo;
            row["email"] = email;
            row["adresa_mesto"] = adresa_mesto;
            dt.Rows.Add(row);

            return dt;
        }
    }
}
