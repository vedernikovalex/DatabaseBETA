using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Reflection;
using System.Reflection.PortableExecutable;

namespace DatabaseBETA
{
    public partial class View : Form
    {
        private DataTable table;

        public View()
        {
            InitializeComponent();
            personPanel.Hide();
            repairPanel.Hide();
            vozidloPanel.Hide();
            zavadaPanel.Hide();
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

        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            //database = new Database();
            //database.Connect();
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            personPanel.Show();
        }

        private void repairsButtonView_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            repairPanel.Show();
        }

        private void personPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayAllProvoz_Click(object sender, EventArgs e)
        {
            ProvozovatelVozidlaRepository repo = new ProvozovatelVozidlaRepository();
            var data = repo.GetAll();
            table = DatabaseTables.ProvozovatelVozidlaTable();

            foreach ( var item in data )
            {
                table.Merge(item.GetTable());
            }

            provozovatelTable.DataSource = table;
        }

        private void displayIdProvoz_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(idProvoz.Text,out int a))
            {
                ProvozovatelVozidlaRepository repo = new ProvozovatelVozidlaRepository();
                var data = repo.GetById(Int32.Parse(idProvoz.Text));
                table = DatabaseTables.ProvozovatelVozidlaTable();

                table.Merge(data.GetTable());

                provozovatelTable.DataSource = table;
            }

        }

        private void displayAllFyzicka_Click(object sender, EventArgs e)
        {
            OsobaFyzickaRepository repo = new OsobaFyzickaRepository();
            var data = repo.GetAll();
            table = DatabaseTables.OsobaFyzicka();

            foreach (var item in data)
            {
                table.Merge(item.GetTable());
            }

            provozovatelTable.DataSource = table;
        }

        private void displayIdFyzicka_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(IdFyzicka.Text, out int a))
            {
                OsobaFyzickaRepository repo = new OsobaFyzickaRepository();
                var data = repo.GetById(Int32.Parse(IdFyzicka.Text));
                table = DatabaseTables.OsobaFyzicka();

                table.Merge(data.GetTable());

                provozovatelTable.DataSource = table;
            }
        }

        private void displayAllPravnicka_Click(object sender, EventArgs e)
        {
            OsobaPravnickaRepository repo = new OsobaPravnickaRepository();
            var data = repo.GetAll();
            table = DatabaseTables.OsobaPravnicka();

            foreach (var item in data)
            {
                table.Merge(item.GetTable());
            }

            provozovatelTable.DataSource = table;
        }

        private void displayIdPravnicka_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(idPravnicka.Text, out int a))
            {
                OsobaPravnickaRepository repo = new OsobaPravnickaRepository();
                var data = repo.GetById(Int32.Parse(idPravnicka.Text));
                table = DatabaseTables.OsobaPravnicka();

                table.Merge(data.GetTable());

                provozovatelTable.DataSource = table;
            }
        }

        private void personExit_Click(object sender, EventArgs e)
        {
            personPanel.Hide();
            mainMenu.Show();
        }

        private void displayAllRepair_Click(object sender, EventArgs e)
        {
            KontrolaRepository repo = new KontrolaRepository();
            var data = repo.GetAll();
            table = DatabaseTables.Kontrola();

            foreach (var item in data)
            {
                table.Merge(item.GetTable());
            }

            repairTable.DataSource = table;
        }

        private void displayIdRepair_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(idRepair.Text, out int a))
            {
                KontrolaRepository repo = new KontrolaRepository();
                var data = repo.GetById(Int32.Parse(idRepair.Text));
                table = DatabaseTables.Kontrola();

                table.Merge(data.GetTable());

                repairTable.DataSource = table;
            }
        }

        private void repairExit_Click(object sender, EventArgs e)
        {
            repairPanel.Hide();
            mainMenu.Show();
        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.menuForm.ShowDialog();
        }

        private void displayAllTechnik_Click(object sender, EventArgs e)
        {
            TechnikRepository repo = new TechnikRepository();
            var data = repo.GetAll();
            table = DatabaseTables.Technik();

            foreach (var item in data)
            {
                table.Merge(item.GetTable());
            }

            repairTable.DataSource = table;
        }

        private void displayIdTechnik_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(idTechnik.Text, out int a))
            {
                TechnikRepository repo = new TechnikRepository();
                var data = repo.GetById(Int32.Parse(idTechnik.Text));
                table = DatabaseTables.Technik();

                table.Merge(data.GetTable());

                repairTable.DataSource = table;
            }
        }


        private void vechicleButtonView_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            vozidloPanel.Show();
        }

        private void displayAllVozidlo_Click(object sender, EventArgs e)
        {
            VozidloRepository repo = new VozidloRepository();
            var data = repo.GetAll();
            table = DatabaseTables.Vozidlo();

            foreach (var item in data)
            {
                table.Merge(item.GetTable());
            }

            vozidloTable.DataSource = table;
        }

        private void displayIdVozidlo_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(idVozidlo.Text, out int a))
            {
                VozidloRepository repo = new VozidloRepository();
                var data = repo.GetById(Int32.Parse(idVozidlo.Text));
                table = DatabaseTables.Vozidlo();

                table.Merge(data.GetTable());

                vozidloTable.DataSource = table;
            }
        }

        private void vozidloExit_Click(object sender, EventArgs e)
        {
            vozidloPanel.Hide();
            mainMenu.Show();
        }

        private void defectButtonView_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            zavadaPanel.Show();
        }

        private void displayAllZavada_Click(object sender, EventArgs e)
        {
            ZavadaRepository repo = new ZavadaRepository();
            var data = repo.GetAll();
            table = DatabaseTables.Zavada();

            foreach (var item in data)
            {
                table.Merge(item.GetTable());
            }

            zavadaTable.DataSource = table;
        }

        private void displayIdZavada_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(idZavada.Text, out int a)) { 

                ZavadaRepository repo = new ZavadaRepository();
                var data = repo.GetById(Int32.Parse(idZavada.Text));
                table = DatabaseTables.Zavada();

                table.Merge(data.GetTable());

                zavadaTable.DataSource = table;
            }
        }

        private void zavadaExit_Click(object sender, EventArgs e)
        {
            zavadaPanel.Hide();
            mainMenu.Show();
        }


    }
}