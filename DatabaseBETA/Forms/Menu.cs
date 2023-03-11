using System.Data.SqlClient;
using System.Diagnostics;

namespace DatabaseBETA
{
    /// <summary>
    /// class that represents a main menu that can navigate through all application
    /// </summary>
    public partial class Menu : Form
    {
        /// <summary>
        /// Drawing form components
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Proper form closing
        /// </summary>
        /// <param name="e"> event </param>
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
            View viewForm = new View();
            this.Hide();
            viewForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// icon link lable
        /// opens default web browser with a source of used icons
        /// </summary>
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
            Create createForm = new Create();
            this.Hide();
            createForm.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        /// <summary>
        /// Tests connection by requesting operating version of server
        /// only displays result in debug console
        /// </summary>
        private void testConnection_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Database.Instance);
            SqlCommand cmd = new SqlCommand("select @@VERSION;", Database.Instance.Connection);
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