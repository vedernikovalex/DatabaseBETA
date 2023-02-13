using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseBETA
{
    /// <summary>
    /// Class that mainly comunicates with database
    /// Executing all "changable" methods on targeted entity tables
    /// Creating, editing and deleting
    /// </summary>
    public partial class Create : Form
    {
        /// <summary>
        /// Drawing all components
        /// Constructor to hide all available panels
        /// </summary>
        public Create()
        {
            InitializeComponent();
            nazevFLabel.Hide();
            personNazevF.Hide();
            personPanel.Hide();
            repairPanel.Hide();
            repairRealPanel.Hide();
            zavadaPanel.Hide();
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

        private bool AllTextInput(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Commit predefined fuction to aviod redundancy
        /// </summary>
        private void Commit()
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

        /// <summary>
        /// Rollback predefined fuction to aviod redundancy
        /// </summary>
        private void Rollback()
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

        /// <summary>
        /// Hiding/Showing inputs which represent different entity (arc relationship)
        /// </summary>
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

        /// <summary>
        /// Predefined method for generating an entity filled with data from textboxes
        /// </summary>
        /// <returns> Entity </returns>
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

        /// <summary>
        /// Creating record of target entity and disposing used repository object
        /// </summary>
        private void personCreate_Click(object sender, EventArgs e)
        {
            ProvozovatelVozidlaRepository repoProvozovatel = new ProvozovatelVozidlaRepository();
            repoProvozovatel.Insert(PersonCreate());
            repoProvozovatel.Dispose();
        }

        /// <summary>
        /// Editing record of target entity and disposing used repository object
        /// </summary>
        private void personUpdate_Click(object sender, EventArgs e)
        {
            ProvozovatelVozidlaRepository repoProvozovatel = new ProvozovatelVozidlaRepository();
            repoProvozovatel.Update(PersonCreate(), Int32.Parse(personId.Text));
            repoProvozovatel.Dispose();
        }

        /// <summary>
        /// Deleting record of target entity and disposing used repository object
        /// </summary>
        private void personDelete_Click(object sender, EventArgs e)
        {
            ProvozovatelVozidlaRepository repoProvozovatel = new ProvozovatelVozidlaRepository();
            repoProvozovatel.Delete(Int32.Parse(personId.Text));
            repoProvozovatel.Dispose();
        }

        /// <summary>
        /// Commiting transaction
        /// </summary>
        private void commitPerson_Click(object sender, EventArgs e)
        {
            Commit();
        }

        /// <summary>
        /// Rollbacking transaction
        /// </summary>
        private void rollbackPerson_Click(object sender, EventArgs e)
        {
            Rollback();
        }

        /// <summary>
        /// Exiting current panel 
        /// Rollbacking if there is active transaction detected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personExit_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.localTransActive)
            {
                UnitOfWork.Instance.Rollback();
            }
            personPanel.Hide();
            mainMenu.Show();
        }

        private void vechicleButton_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            repairPanel.Show();
        }

        private Vozidlo vozidlo;

        /// <summary>
        /// Predefined method for generating an entity filled with data from textboxes
        /// </summary>
        /// <returns> Entity </returns>
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
            if (!string.IsNullOrEmpty(repairId.Text))
            {
                VozidloRepository repo = new VozidloRepository();
                repo.Delete(Int32.Parse(repairId.Text));
                repo.Dispose();
                MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some required inputs are empty! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repairCommit_Click(object sender, EventArgs e)
        {
            Commit();
        }

        private void repairRollback_Click(object sender, EventArgs e)
        {
            Rollback();
        }
        private void repairExit_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.localTransActive)
            {
                UnitOfWork.Instance.Rollback();
            }
            repairPanel.Hide();
            mainMenu.Show();
        }

        private void repairsButton_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            repairRealPanel.Show();
        }

        private Kontrola kontrola;

        private Kontrola KontrolaCreate()
        {
            kontrola = new Kontrola();
            kontrola.vozidlo_id = Int32.Parse(kontrolaVozidloId.Text);
            kontrola.druh_kontroly_id = Int32.Parse(kontrolaDruh.Text);
            kontrola.plny_rozsah = kontrolaRozsahPlny.Checked ? true : false;
            kontrola.datum = kontrolaDatum.Value.Date;
            kontrola.poznamka = kontrolaPoznamka.Text;
            kontrola.technik_id = Int32.Parse(kontrolaTechnikId.Text);
            kontrola.provozovatel_vozidla_id = Int32.Parse(kontrolaProvozovatelId.Text);

            return kontrola;
        }
        private void kontrolaCreate_Click(object sender, EventArgs e)
        {
            KontrolaRepository repo = new KontrolaRepository();
            repo.Insert(KontrolaCreate());
            repo.Dispose();
        }

        private void kontrolaUpdate_Click(object sender, EventArgs e)
        {
            KontrolaRepository repo = new KontrolaRepository();
            repo.Update(KontrolaCreate(), Int32.Parse(kontrolaId.Text));
            repo.Dispose();

        }

        private void kontrolaDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kontrolaId.Text))
            {
                KontrolaRepository repo = new KontrolaRepository();
                repo.Delete(Int32.Parse(kontrolaId.Text));
                repo.Dispose();
                MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some required inputs are empty! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Technik technik;

        private Technik CreateTechnik()
        {
            technik = new Technik();
            technik.jmeno = technikJmeno.Text;
            technik.prijmeni = technikPrijmeni.Text;
            technik.nadrizeny_technik = Int32.Parse(technikNadrizeny.Text);

            return technik;
        }

        private void technikCreate_Click(object sender, EventArgs e)
        {
                TechnikRepository repo = new TechnikRepository();
                repo.Insert(CreateTechnik());
                repo.Dispose();
        }

        private void technikUpdate_Click(object sender, EventArgs e)
        {
                TechnikRepository repo = new TechnikRepository();
                repo.Update(CreateTechnik(), Int32.Parse(technikId.Text));
                repo.Dispose();
        }

        private void technikDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(technikId.Text))
            {
                TechnikRepository repo = new TechnikRepository();
                repo.Delete(Int32.Parse(technikId.Text));
                repo.Dispose();
                MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some required inputs are empty! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kontrolaCommit_Click(object sender, EventArgs e)
        {
            Commit();
        }

        private void kontrolaRollback_Click(object sender, EventArgs e)
        {
            Rollback();
        }

        private void kontrolaExit_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.localTransActive)
            {
                UnitOfWork.Instance.Rollback();
            }
            repairRealPanel.Hide();
            mainMenu.Show();
        }

        private void defectButton_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            zavadaPanel.Show();
        }

        private Zavada zavada;

        private Zavada CreateZavada()
        {
            zavada = new Zavada();
            zavada.kategorie = char.Parse(zavadaKategorie.SelectedValue.ToString());
            zavada.popis = zavadaPopis.Text;
            return zavada;
        }

        private void zavadaCreate_Click(object sender, EventArgs e)
        {
                ZavadaRepository repo = new ZavadaRepository();
                repo.Insert(CreateZavada());
                repo.Dispose();
        }

        private void zavadaUpdate_Click(object sender, EventArgs e)
        {
                ZavadaRepository repo = new ZavadaRepository();
                repo.Update(CreateZavada(),Int32.Parse(zavadaId.Text));
                repo.Dispose();
        }

        private void zavadaDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zavadaId.Text))
            {
                ZavadaRepository repo = new ZavadaRepository();
                repo.Delete(Int32.Parse(zavadaId.Text));
                repo.Dispose();
                MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some required inputs are empty! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private Nalez nalez;

        private Nalez CreateNalez()
        {
            nalez = new Nalez();
            nalez.kontrola_id = Int32.Parse(nalezKontrolaId.Text);
            nalez.zavada_id = Int32.Parse(nalezZavadaId.Text);
            return nalez;
        }

        private void nalezCreate_Click(object sender, EventArgs e)
        {
            NalezRepository repo = new NalezRepository();
            repo.Insert(CreateNalez());
            repo.Dispose();
        }

        private void nalezUpdate_Click(object sender, EventArgs e)
        {
            NalezRepository repo = new NalezRepository();
            repo.Update(CreateNalez(),Int32.Parse(nalezId.Text));
            repo.Dispose();
        }

        private void nalezDelete_Click(object sender, EventArgs e)
        {
            NalezRepository repo = new NalezRepository();
            repo.Delete(Int32.Parse(nalezId.Text));
            repo.Dispose();
        }

        private void zavadaCommit_Click(object sender, EventArgs e)
        {
            Commit();
        }

        private void zavadaRollback_Click(object sender, EventArgs e)
        {
            Rollback();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            this.Hide();
            menuForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zavadaPanel.Hide();
            mainMenu.Show();
        }
    }
}