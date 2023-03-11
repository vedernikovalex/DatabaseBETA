using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseBETA
{
    /// <summary>
    /// First page of application
    /// Logging in
    /// </summary>
    public partial class LoginForm : Form
    {
        private string loginInput;
        private string passwordInput;
        private Database database;

        public LoginForm()
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

        /// <summary>
        /// On textbox change it writes into target string
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loginInput = usernameBox.Text;
        }

        /// <summary>
        /// On textbox change it writes into target string
        /// </summary>
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
            else
            {
                //database = new Database();
                database = new Database(loginInput, passwordInput);
                Menu menuForm = new Menu();
                this.Hide();
                menuForm.ShowDialog();
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
        }
    }
}