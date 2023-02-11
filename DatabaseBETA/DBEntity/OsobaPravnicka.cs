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
    public class OsobaPravnicka
    {
        public int id;
        public string nazev_firmy;

        public OsobaPravnicka()
        {

        }

        public OsobaPravnicka(SqlDataReader reader)
        {
            this.id =  reader.GetInt32(0);
            this.nazev_firmy = reader.GetString(1);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.OsobaPravnicka();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["nazev_firmy"] = nazev_firmy;
            dt.Rows.Add(row);

            return dt;
        }
    }
}
