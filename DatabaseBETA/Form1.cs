using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace DatabaseBETA
{
    public partial class Form1 : Form
    {
        private string loginInput;
        private string passwordInput;
        private bool loggedIn = false;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlCommand, output;

        //private string dataSource = ConfigurationManager.AppSettings.Get("macDBDataSource");
        //private string databaseName = ConfigurationManager.AppSettings.Get("DBName");

        //
        private string connectionString = string.Format("Data Source=(LocalDb)\\beta;Integrated Security=true;", ConfigurationManager.AppSettings.Get("macDBDataSource"), ConfigurationManager.AppSettings.Get("DBName"));
        public Form1()
        {
            InitializeComponent();
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
            passwordInput= passwordBox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(loginInput) && !String.IsNullOrEmpty(passwordInput))
            {
                Debug.WriteLine(loginInput);
                Debug.WriteLine(passwordInput);
                loggedIn= true;
                Debug.WriteLine(loggedIn);
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(connectionString);
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    this.Hide();
                    Form2 form2= new Form2();
                    form2.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }
    }
}