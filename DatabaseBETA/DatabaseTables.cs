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
            dt.Columns.Add("druh_kontroly_id", typeof(int));
            dt.Columns.Add("technik_id", typeof(int));
            dt.Columns.Add("provozovatel_vozidla_id", typeof(int));
            dt.Columns.Add("plny_rozsah", typeof(bool));
            dt.Columns.Add("datum", typeof(DateTime));
            dt.Columns.Add("poznamka", typeof(string));
            //druh_kontroly
            dt.Columns.Add("nazev_kontroly", typeof(string));

            return dt;
        }

        public static DataTable Technik()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("jmeno", typeof(string));
            dt.Columns.Add("prijmeni", typeof(string));
            dt.Columns.Add("nadrizeny_technik", typeof(int));

            return dt;
        }

        public static DataTable Vozidlo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("kategorie_vozidla_id", typeof(int));
            dt.Columns.Add("tovarni_znacka", typeof(string));
            dt.Columns.Add("obchodni_oznaceni", typeof(string));
            dt.Columns.Add("VIN", typeof(string));
            dt.Columns.Add("cislo_technickeho_prukazu", typeof(string));
            dt.Columns.Add("najeto_km", typeof(int));
            dt.Columns.Add("registracni_znacka", typeof(string));
            dt.Columns.Add("datum_prvni_registrace", typeof(DateTime));
            dt.Columns.Add("barva", typeof(string));
            //kategorie_vozidla
            dt.Columns.Add("kategorie_vozidla_nazev", typeof(string));

            return dt;
        }

        public static DataTable Zavada()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("kategorie", typeof(char));
            dt.Columns.Add("popis", typeof(string));
            //nalez
            dt.Columns.Add("nalez_id", typeof(int));
            dt.Columns.Add("kontrola_id", typeof(int));

            return dt;
        }
    }
}
