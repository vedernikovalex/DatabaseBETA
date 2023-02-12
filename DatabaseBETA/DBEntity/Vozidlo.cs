using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class Vozidlo
    {
        public int id;
        public int kategorie_vozidla_id;
        public string tovarni_znacka;
        public string obchodni_oznaceni;
        public string VIN;
        public string cislo_technickeho_prukazu;
        public int najeto_km;
        public string registracni_znacka;
        public DateTime datum_prvni_registrace;
        public string barva;
        //kategorie vozidla
        public string kategorie_vozidla_nazev;

        public Vozidlo() { }

        public Vozidlo(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.kategorie_vozidla_id = reader.GetInt32(1);
            this.tovarni_znacka = reader.GetString(2);
            this.obchodni_oznaceni = reader.GetString(3);
            this.VIN = reader.GetString(4);
            this.cislo_technickeho_prukazu = reader.GetString(5);
            this.najeto_km = reader.GetInt32(6);
            this.registracni_znacka = reader.GetString(7);
            this.datum_prvni_registrace = reader.IsDBNull(8) ? DateTime.MinValue : reader.GetDateTime(8);
            this.barva = reader.GetString(9);
            //kategorie_vozidla
            this.kategorie_vozidla_nazev = reader.GetString(10);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.Vozidlo();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["kategorie_vozidla_id"] = kategorie_vozidla_id;
            row["tovarni_znacka"] = tovarni_znacka;
            row["obchodni_oznaceni"] = obchodni_oznaceni;
            row["VIN"] = VIN;
            row["cislo_technickeho_prukazu"] = cislo_technickeho_prukazu;
            row["najeto_km"] = najeto_km;
            row["registracni_znacka"] = registracni_znacka;
            row["datum_prvni_registrace"] = datum_prvni_registrace;
            row["barva"] = barva;
            //kategorie_vozidla
            row["kategorie_vozidla_nazev"] = kategorie_vozidla_nazev;
            dt.Rows.Add(row);

            return dt;
        }
    }
}
