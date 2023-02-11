using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseBETA
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.viewForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "https://icons8.com";
            startInfo.UseShellExecute = true;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.createForm.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.loginForm.ShowDialog();
        }

        private void testConnection_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select @@VERSION;",Database.Instance.Connection);
            Database.Instance.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Debug.WriteLine(reader.GetString(0));
            }
            Database.Instance.Connection.Close();
        }
    }
}