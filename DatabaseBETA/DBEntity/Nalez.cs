using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBETA
{
    public class Nalez
    {
        public int kontrola_id;
        public int zavada_id;
        public char kategorie;
        public string zavada_popis;

        public Nalez() { }

        public Nalez(SqlDataReader reader)
        {
            this.kontrola_id= reader.GetInt32(0);
            this.zavada_id = reader.GetInt32(1);
            this.kategorie = char.Parse(reader.GetString(2));
            this.zavada_popis = reader.GetString(3);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.Nalez();
            DataRow row = dt.NewRow();

            row["kontrola_id"] = kontrola_id;
            row["zavada_id"] = zavada_id;
            row["kategorie"] = kategorie;
            row["zavada_popis"] = zavada_popis;

            dt.Rows.Add(row);

            return dt;
        }
    }
}
