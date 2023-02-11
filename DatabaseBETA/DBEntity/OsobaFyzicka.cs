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
    public class OsobaFyzicka
    {
        public int id;
        public string jmeno;
        public string prijmeni;

        public OsobaFyzicka()
        {

        }
        public OsobaFyzicka(SqlDataReader reader)
        {
            this.id =  reader.GetInt32(0);
            this.jmeno = reader.GetString(1);
            this.prijmeni = reader.GetString(2);
        }

        public DataTable GetTable()
        {
            DataTable dt = DatabaseTables.OsobaFyzicka();

            DataRow row = dt.NewRow();
            row["id"] = id;
            row["jmeno"] = jmeno;
            row["prijmeni"] = prijmeni;
            dt.Rows.Add(row);

            return dt;
        }
    }
}
