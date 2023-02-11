using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public static class DatabaseTables
    {
        public static DataTable ProvozovatelVozidlaTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("osoba_fyzicka_id", typeof(int));
            dt.Columns.Add("osoba_pravnicka_id", typeof(int));
            dt.Columns.Add("adresa_ulice", typeof(string));
            dt.Columns.Add("adresa_cislo_popisne", typeof(string));
            dt.Columns.Add("adresa_psc", typeof(int));
            dt.Columns.Add("adresa_obec", typeof(string));
            dt.Columns.Add("telefonni_cislo", typeof(int));
            dt.Columns.Add("email", typeof(string));
            dt.Columns.Add("adresa_mesto", typeof(string));

            return dt;
        }

        public static DataTable OsobaFyzicka()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("jmeno", typeof(string));
            dt.Columns.Add("prijmeni", typeof(string));

            return dt;
        }

        public static DataTable OsobaPravnicka()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("nazev_firmy", typeof(string));

            return dt;
        }

        public static DataTable Kontrola()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("vozidlo_id", typeof(int));
            dt.Columns.Add("druh_id", typeof(int));
            dt.Columns.Add("plny_rozsah", typeof(bool));
            dt.Columns.Add("datum", typeof(DateTime));
            dt.Columns.Add("poznamka", typeof(string));
            dt.Columns.Add("technik_id", typeof(int));
            dt.Columns.Add("provozovatel_vozidla_id", typeof(int));

            return dt;
        }
    }
}
