using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseBETA
{
    public partial class Menu : Form
    {
        private Create createForm = new Create();
        private LoginForm loginForm = new LoginForm();
        private View viewForm = new View();

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
            viewForm.ShowDialog();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            //database = new Database();
            //database.Connect();
            ZavadaRepository repo = new ZavadaRepository();
            var result = repo.GetAll();
            foreach (var i in result)
            {
                Debug.WriteLine("ITEM: " + i);
            }
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
            createForm.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}