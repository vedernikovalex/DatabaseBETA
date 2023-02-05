using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseBETA
{
    public partial class LoginForm : Form
    {
        private string loginInput;
        private string passwordInput;
        private bool loggedIn = false;
        private Database database;

        public LoginForm()
        {
            InitializeComponent();
            database = new Database();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Label 1 clicked");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loginInput = usernameBox.Text;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordInput = passwordBox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginInput) || String.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Login or Password was empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!String.IsNullOrEmpty(loginInput) && !String.IsNullOrEmpty(passwordInput))
            {
                loggedIn = true;
                ZavadaRepository repo = new ZavadaRepository();
                var result = repo.GetAll();
                foreach (var i in result)
                {
                    Debug.WriteLine("ITEM: "+i);
                }
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            //database = new Database();
            //database.Connect();
        }
    }
}