using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class Technik
    {
        public int id;
        public string jmeno;
        public string prijmeni;
        public int nadrizeny_technik;

        public Technik() { }

        public Technik(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.jmeno= reader.GetString(1);
            this.prijmeni= reader.GetString(2);
            this.nadrizeny_technik= reader.GetInt32(3);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.Technik();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["jmeno"] = jmeno;
            row["prijmeni"] = prijmeni;
            row["nadrizeny_technik"] = nadrizeny_technik;

            dt.Rows.Add(row);

            return dt;
        }
    }
}
