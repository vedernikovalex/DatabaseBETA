using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseBETA
{
    public partial class Create : Form
    {
        private string loginInput;
        private string passwordInput;
        private Database database;

        public Create()
        {
            InitializeComponent();
            database = new Database();
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
            //TODO kontrola a prihlaseni pomoci user
            if (String.IsNullOrEmpty(loginInput) || String.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Login or Password was empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            //database = new Database();
            //database.Connect();
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();

        }
    }
}