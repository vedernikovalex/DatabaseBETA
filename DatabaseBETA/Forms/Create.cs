using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseBETA
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            nazevFLabel.Hide();
            personNazevF.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        private bool RequiredTextBoxCheck()
        {
            foreach (Control control in this.Controls)
            {
                if (personBool.Checked)
                {
                    if (control is TextBox && string.IsNullOrWhiteSpace(control.Text) && !string.IsNullOrWhiteSpace(personJmeno.Text) && !string.IsNullOrWhiteSpace(personPrijmeni.Text))
                    {
                        return false;
                    }
                }

            }
            return true;
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

        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            //database = new Database();
            //database.Connect();
        }

        private ProvozovatelVozidla provozovatel;
        private OsobaFyzicka osobaFyzicka;
        private OsobaPravnicka osobaPravnicka;

        private void personButton_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            personPanel.Show();
        }

        private void personBool_CheckedChanged(object sender, EventArgs e)
        {
            if (personBool.Checked)
            {
                nazevFLabel.Show();
                personNazevF.Show();

                jmenoLabel.Hide();
                personJmeno.Hide();

                prijmeniLabel.Hide();
                personPrijmeni.Hide();
            }
            else
            {
                nazevFLabel.Hide();
                personNazevF.Hide();

                jmenoLabel.Show();
                personJmeno.Show();

                prijmeniLabel.Show();
                personPrijmeni.Show();
            }
        }

        private void personCreate_Click(object sender, EventArgs e)
        {
            provozovatel = new ProvozovatelVozidla();
            //todo podminky
            if (personBool.Checked)
            {
                osobaPravnicka = new OsobaPravnicka();
                osobaPravnicka.nazev_firmy = personNazevF.Text;
                OsobaPravnickaRepository repo = new OsobaPravnickaRepository();
                repo.Insert(osobaPravnicka);
            }
            else 
            {
                osobaFyzicka = new OsobaFyzicka();
                osobaFyzicka.jmeno = personJmeno.Text;
                osobaFyzicka.prijmeni = personPrijmeni.Text;
                OsobaFyzickaRepository repo = new OsobaFyzickaRepository();
                repo.Insert(osobaFyzicka);
            }
            provozovatel.adresa_ulice = personUlice.Text;
            provozovatel.adresa_cislo_popisne = personPopisne.Text;
            provozovatel.adresa_psc = Int32.Parse(personPsc.Text);
            provozovatel.adresa_obec = personObec.Text;
            provozovatel.telefonni_cislo = Int32.Parse(personTelefon.Text);
            provozovatel.email = personEmail.Text;
            provozovatel.adresa_mesto = personMesto.Text;

            ProvozovatelVozidlaRepository repoProvozovatel = new ProvozovatelVozidlaRepository();
            repoProvozovatel.Insert(provozovatel);

        }

        private void personUpdate_Click(object sender, EventArgs e)
        {

        }

        private void personDelete_Click(object sender, EventArgs e)
        {

        }
    }
}