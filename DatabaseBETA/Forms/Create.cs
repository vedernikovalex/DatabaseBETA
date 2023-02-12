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
                personJmeno.Clear();

                prijmeniLabel.Hide();
                personPrijmeni.Hide();
                personPrijmeni.Clear();
            }
            else
            {
                nazevFLabel.Hide();
                personNazevF.Hide();
                personNazevF.Clear();

                jmenoLabel.Show();
                personJmeno.Show();

                prijmeniLabel.Show();
                personPrijmeni.Show();
            }
        }

        private ProvozovatelVozidla PersonCreate()
        {
            provozovatel = new ProvozovatelVozidla();
            int fyzickaid = 0;
            int pravnickaid = 0;
            //todo podminky
            if (personBool.Checked)
            {
                osobaPravnicka = new OsobaPravnicka();
                osobaPravnicka.nazev_firmy = personNazevF.Text;
                OsobaPravnickaRepository repo = new OsobaPravnickaRepository();
                pravnickaid = repo.InsertRetrieveId(osobaPravnicka);
                repo.Dispose();
            }
            else
            {
                osobaFyzicka = new OsobaFyzicka();
                osobaFyzicka.jmeno = personJmeno.Text;
                osobaFyzicka.prijmeni = personPrijmeni.Text;
                OsobaFyzickaRepository repo = new OsobaFyzickaRepository();
                fyzickaid = repo.InsertRetrieveId(osobaFyzicka);
                repo.Dispose();
            }
            provozovatel.osoba_fyzicka_id = fyzickaid;
            provozovatel.osoba_pravnicka_id = pravnickaid;
            provozovatel.adresa_ulice = personUlice.Text;
            provozovatel.adresa_cislo_popisne = personPopisne.Text;
            provozovatel.adresa_psc = Int32.Parse(personPsc.Text);
            provozovatel.adresa_obec = personObec.Text;
            provozovatel.telefonni_cislo = Int32.Parse(personTelefon.Text);
            provozovatel.email = personEmail.Text;
            provozovatel.adresa_mesto = personMesto.Text;

            return provozovatel;
        }

        private void personCreate_Click(object sender, EventArgs e)
        {
            ProvozovatelVozidlaRepository repoProvozovatel = new ProvozovatelVozidlaRepository();
            repoProvozovatel.Insert(PersonCreate());
            repoProvozovatel.Dispose();
        }

        private void personUpdate_Click(object sender, EventArgs e)
        {
            ProvozovatelVozidlaRepository repoProvozovatel = new ProvozovatelVozidlaRepository();
            repoProvozovatel.Update(PersonCreate(), Int32.Parse(personId.Text));
            repoProvozovatel.Dispose();
        }

        private void personDelete_Click(object sender, EventArgs e)
        {
            ProvozovatelVozidlaRepository repoProvozovatel = new ProvozovatelVozidlaRepository();
            repoProvozovatel.Delete(Int32.Parse(personId.Text));
            repoProvozovatel.Dispose();
        }

        private void commitPerson_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.localTransActive)
            {
                UnitOfWork.Instance.Commit();
            }
            else
            {
                MessageBox.Show("No transaction found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rollbackPerson_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.localTransActive)
            {
                UnitOfWork.Instance.Rollback();
            }
            else
            {
                MessageBox.Show("No transaction found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personExit_Click(object sender, EventArgs e)
        {
            personPanel.Hide();
            mainMenu.Show();
        }

        private Vozidlo vozidlo;

        private Vozidlo VozidloCreate()
        {
            vozidlo = new Vozidlo();
            vozidlo.kategorie_vozidla_id = Int32.Parse(repairKategorieId.Text);
            vozidlo.tovarni_znacka = repairZnacka.Text;
            vozidlo.obchodni_oznaceni = repairOznaceni.Text;
            vozidlo.VIN = repairVin.Text;
            vozidlo.cislo_technickeho_prukazu = repairCisloTp.Text;
            vozidlo.najeto_km = Int32.Parse(repairNajeto.Text);
            vozidlo.registracni_znacka = repairSpz.Text;
            vozidlo.datum_prvni_registrace = repairDatum.Value.Date;
            vozidlo.barva = repairBarva.Text;
            return vozidlo;
        }

        private void repairCreate_Click(object sender, EventArgs e)
        {
            VozidloRepository repo = new VozidloRepository();
            repo.Insert(VozidloCreate());
            repo.Dispose();
        }

        private void repairUpdate_Click(object sender, EventArgs e)
        {
            VozidloRepository repo = new VozidloRepository();
            repo.Update(VozidloCreate(), Int32.Parse(repairId.Text));
            repo.Dispose();

        }

        private void repairDelete_Click(object sender, EventArgs e)
        {
            VozidloRepository repo = new VozidloRepository();
            repo.Delete(Int32.Parse(repairId.Text));
            repo.Dispose();
        }

        private void repairCommit_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.localTransActive)
            {
                UnitOfWork.Instance.Commit();
            }
            else
            {
                MessageBox.Show("No transaction found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repairRollback_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.localTransActive)
            {
                UnitOfWork.Instance.Rollback();
            }
            else
            {
                MessageBox.Show("No transaction found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}