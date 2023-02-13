namespace DatabaseBETA
{
    partial class View: Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vechicleButtonView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.repairsButtonView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.personButtonView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.defectButtonView = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Panel();
            this.personPanel = new System.Windows.Forms.Panel();
            this.personExit = new System.Windows.Forms.Button();
            this.provozovatelTable = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.idPravnicka = new System.Windows.Forms.TextBox();
            this.displayIdPravnicka = new System.Windows.Forms.Button();
            this.displayAllPravnicka = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.IdFyzicka = new System.Windows.Forms.TextBox();
            this.displayIdFyzicka = new System.Windows.Forms.Button();
            this.displayAllFyzicka = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.idProvoz = new System.Windows.Forms.TextBox();
            this.displayIdProvoz = new System.Windows.Forms.Button();
            this.displayAllProvoz = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.repairPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.idTechnik = new System.Windows.Forms.TextBox();
            this.displayIdTechnik = new System.Windows.Forms.Button();
            this.displayAllTechnik = new System.Windows.Forms.Button();
            this.repairExit = new System.Windows.Forms.Button();
            this.repairTable = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.idRepair = new System.Windows.Forms.TextBox();
            this.displayIdRepair = new System.Windows.Forms.Button();
            this.displayAllRepair = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.viewExit = new System.Windows.Forms.Button();
            this.vozidloPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.idVozidlo = new System.Windows.Forms.TextBox();
            this.displayIdVozidlo = new System.Windows.Forms.Button();
            this.displayAllVozidlo = new System.Windows.Forms.Button();
            this.vozidloExit = new System.Windows.Forms.Button();
            this.vozidloTable = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.zavadaPanel = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.idNalez = new System.Windows.Forms.TextBox();
            this.displayIdNalez = new System.Windows.Forms.Button();
            this.displayAllNalez = new System.Windows.Forms.Button();
            this.zavadaExit = new System.Windows.Forms.Button();
            this.zavadaTable = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.idZavada = new System.Windows.Forms.TextBox();
            this.displayIdZavada = new System.Windows.Forms.Button();
            this.displayAllZavada = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.personPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provozovatelTable)).BeginInit();
            this.repairPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairTable)).BeginInit();
            this.vozidloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozidloTable)).BeginInit();
            this.zavadaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zavadaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOMECHANIK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(243, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "View";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 933);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "ICONS: https://icons8.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(499, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "VEHICLE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vechicleButtonView
            // 
            this.vechicleButtonView.BackColor = System.Drawing.Color.Transparent;
            this.vechicleButtonView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vechicleButtonView.BackgroundImage")));
            this.vechicleButtonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vechicleButtonView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vechicleButtonView.Location = new System.Drawing.Point(483, 326);
            this.vechicleButtonView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vechicleButtonView.Name = "vechicleButtonView";
            this.vechicleButtonView.Size = new System.Drawing.Size(130, 130);
            this.vechicleButtonView.TabIndex = 17;
            this.vechicleButtonView.UseVisualStyleBackColor = false;
            this.vechicleButtonView.Click += new System.EventHandler(this.vechicleButtonView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "REPAIR RECORD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repairsButtonView
            // 
            this.repairsButtonView.BackColor = System.Drawing.Color.Transparent;
            this.repairsButtonView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("repairsButtonView.BackgroundImage")));
            this.repairsButtonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.repairsButtonView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repairsButtonView.Location = new System.Drawing.Point(234, 315);
            this.repairsButtonView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repairsButtonView.Name = "repairsButtonView";
            this.repairsButtonView.Size = new System.Drawing.Size(158, 153);
            this.repairsButtonView.TabIndex = 19;
            this.repairsButtonView.UseVisualStyleBackColor = false;
            this.repairsButtonView.Click += new System.EventHandler(this.repairsButtonView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "PERSON";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personButtonView
            // 
            this.personButtonView.BackColor = System.Drawing.Color.Transparent;
            this.personButtonView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personButtonView.BackgroundImage")));
            this.personButtonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personButtonView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personButtonView.Location = new System.Drawing.Point(20, 326);
            this.personButtonView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personButtonView.Name = "personButtonView";
            this.personButtonView.Size = new System.Drawing.Size(130, 130);
            this.personButtonView.TabIndex = 21;
            this.personButtonView.UseVisualStyleBackColor = false;
            this.personButtonView.Click += new System.EventHandler(this.personButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(263, 703);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "DEFECT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defectButtonView
            // 
            this.defectButtonView.BackColor = System.Drawing.Color.Transparent;
            this.defectButtonView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("defectButtonView.BackgroundImage")));
            this.defectButtonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defectButtonView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defectButtonView.Location = new System.Drawing.Point(249, 579);
            this.defectButtonView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.defectButtonView.Name = "defectButtonView";
            this.defectButtonView.Size = new System.Drawing.Size(120, 120);
            this.defectButtonView.TabIndex = 23;
            this.defectButtonView.UseVisualStyleBackColor = false;
            this.defectButtonView.Click += new System.EventHandler(this.defectButtonView_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.personButtonView);
            this.mainMenu.Controls.Add(this.label6);
            this.mainMenu.Controls.Add(this.label1);
            this.mainMenu.Controls.Add(this.defectButtonView);
            this.mainMenu.Controls.Add(this.label4);
            this.mainMenu.Controls.Add(this.label3);
            this.mainMenu.Controls.Add(this.vechicleButtonView);
            this.mainMenu.Controls.Add(this.label5);
            this.mainMenu.Controls.Add(this.label2);
            this.mainMenu.Controls.Add(this.repairsButtonView);
            this.mainMenu.Location = new System.Drawing.Point(458, 60);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(635, 806);
            this.mainMenu.TabIndex = 25;
            // 
            // personPanel
            // 
            this.personPanel.Controls.Add(this.personExit);
            this.personPanel.Controls.Add(this.provozovatelTable);
            this.personPanel.Controls.Add(this.label12);
            this.personPanel.Controls.Add(this.idPravnicka);
            this.personPanel.Controls.Add(this.displayIdPravnicka);
            this.personPanel.Controls.Add(this.displayAllPravnicka);
            this.personPanel.Controls.Add(this.label11);
            this.personPanel.Controls.Add(this.IdFyzicka);
            this.personPanel.Controls.Add(this.displayIdFyzicka);
            this.personPanel.Controls.Add(this.displayAllFyzicka);
            this.personPanel.Controls.Add(this.label10);
            this.personPanel.Controls.Add(this.idProvoz);
            this.personPanel.Controls.Add(this.displayIdProvoz);
            this.personPanel.Controls.Add(this.displayAllProvoz);
            this.personPanel.Controls.Add(this.label8);
            this.personPanel.Controls.Add(this.label9);
            this.personPanel.Location = new System.Drawing.Point(161, 60);
            this.personPanel.Name = "personPanel";
            this.personPanel.Size = new System.Drawing.Size(1195, 850);
            this.personPanel.TabIndex = 26;
            this.personPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.personPanel_Paint);
            // 
            // personExit
            // 
            this.personExit.BackColor = System.Drawing.Color.Transparent;
            this.personExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personExit.BackgroundImage")));
            this.personExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personExit.Location = new System.Drawing.Point(12, 748);
            this.personExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personExit.Name = "personExit";
            this.personExit.Size = new System.Drawing.Size(68, 66);
            this.personExit.TabIndex = 24;
            this.personExit.UseVisualStyleBackColor = false;
            this.personExit.Click += new System.EventHandler(this.personExit_Click);
            // 
            // provozovatelTable
            // 
            this.provozovatelTable.AllowUserToAddRows = false;
            this.provozovatelTable.AllowUserToDeleteRows = false;
            this.provozovatelTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provozovatelTable.Location = new System.Drawing.Point(98, 475);
            this.provozovatelTable.Name = "provozovatelTable";
            this.provozovatelTable.ReadOnly = true;
            this.provozovatelTable.RowTemplate.Height = 25;
            this.provozovatelTable.Size = new System.Drawing.Size(999, 339);
            this.provozovatelTable.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(927, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 37);
            this.label12.TabIndex = 23;
            this.label12.Text = "Osoba Pravnicka";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idPravnicka
            // 
            this.idPravnicka.Location = new System.Drawing.Point(987, 343);
            this.idPravnicka.Name = "idPravnicka";
            this.idPravnicka.Size = new System.Drawing.Size(110, 23);
            this.idPravnicka.TabIndex = 22;
            this.idPravnicka.Text = "id";
            this.idPravnicka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdPravnicka
            // 
            this.displayIdPravnicka.Location = new System.Drawing.Point(987, 369);
            this.displayIdPravnicka.Name = "displayIdPravnicka";
            this.displayIdPravnicka.Size = new System.Drawing.Size(110, 45);
            this.displayIdPravnicka.TabIndex = 21;
            this.displayIdPravnicka.Text = "DISPLAY BY ID";
            this.displayIdPravnicka.UseVisualStyleBackColor = true;
            this.displayIdPravnicka.Click += new System.EventHandler(this.displayIdPravnicka_Click);
            // 
            // displayAllPravnicka
            // 
            this.displayAllPravnicka.Location = new System.Drawing.Point(987, 271);
            this.displayAllPravnicka.Name = "displayAllPravnicka";
            this.displayAllPravnicka.Size = new System.Drawing.Size(110, 45);
            this.displayAllPravnicka.TabIndex = 20;
            this.displayAllPravnicka.Text = "DISPLAY ALL";
            this.displayAllPravnicka.UseVisualStyleBackColor = true;
            this.displayAllPravnicka.Click += new System.EventHandler(this.displayAllPravnicka_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(503, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 37);
            this.label11.TabIndex = 19;
            this.label11.Text = "Osoba Fyzicka";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdFyzicka
            // 
            this.IdFyzicka.Location = new System.Drawing.Point(542, 343);
            this.IdFyzicka.Name = "IdFyzicka";
            this.IdFyzicka.Size = new System.Drawing.Size(110, 23);
            this.IdFyzicka.TabIndex = 18;
            this.IdFyzicka.Text = "id";
            this.IdFyzicka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdFyzicka
            // 
            this.displayIdFyzicka.Location = new System.Drawing.Point(542, 369);
            this.displayIdFyzicka.Name = "displayIdFyzicka";
            this.displayIdFyzicka.Size = new System.Drawing.Size(110, 45);
            this.displayIdFyzicka.TabIndex = 17;
            this.displayIdFyzicka.Text = "DISPLAY BY ID";
            this.displayIdFyzicka.UseVisualStyleBackColor = true;
            this.displayIdFyzicka.Click += new System.EventHandler(this.displayIdFyzicka_Click);
            // 
            // displayAllFyzicka
            // 
            this.displayAllFyzicka.Location = new System.Drawing.Point(542, 271);
            this.displayAllFyzicka.Name = "displayAllFyzicka";
            this.displayAllFyzicka.Size = new System.Drawing.Size(110, 45);
            this.displayAllFyzicka.TabIndex = 16;
            this.displayAllFyzicka.Text = "DISPLAY ALL";
            this.displayAllFyzicka.UseVisualStyleBackColor = true;
            this.displayAllFyzicka.Click += new System.EventHandler(this.displayAllFyzicka_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(27, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 37);
            this.label10.TabIndex = 15;
            this.label10.Text = "Provozovatel Vozidla";
            // 
            // idProvoz
            // 
            this.idProvoz.Location = new System.Drawing.Point(98, 343);
            this.idProvoz.Name = "idProvoz";
            this.idProvoz.Size = new System.Drawing.Size(110, 23);
            this.idProvoz.TabIndex = 14;
            this.idProvoz.Text = "id";
            this.idProvoz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdProvoz
            // 
            this.displayIdProvoz.Location = new System.Drawing.Point(98, 369);
            this.displayIdProvoz.Name = "displayIdProvoz";
            this.displayIdProvoz.Size = new System.Drawing.Size(110, 45);
            this.displayIdProvoz.TabIndex = 13;
            this.displayIdProvoz.Text = "DISPLAY BY ID";
            this.displayIdProvoz.UseVisualStyleBackColor = true;
            this.displayIdProvoz.Click += new System.EventHandler(this.displayIdProvoz_Click);
            // 
            // displayAllProvoz
            // 
            this.displayAllProvoz.Location = new System.Drawing.Point(98, 271);
            this.displayAllProvoz.Name = "displayAllProvoz";
            this.displayAllProvoz.Size = new System.Drawing.Size(110, 45);
            this.displayAllProvoz.TabIndex = 12;
            this.displayAllProvoz.Text = "DISPLAY ALL";
            this.displayAllProvoz.UseVisualStyleBackColor = true;
            this.displayAllProvoz.Click += new System.EventHandler(this.displayAllProvoz_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(389, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 72);
            this.label8.TabIndex = 9;
            this.label8.Text = "AUTOMECHANIK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(475, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 54);
            this.label9.TabIndex = 10;
            this.label9.Text = "Person View";
            // 
            // repairPanel
            // 
            this.repairPanel.Controls.Add(this.label13);
            this.repairPanel.Controls.Add(this.idTechnik);
            this.repairPanel.Controls.Add(this.displayIdTechnik);
            this.repairPanel.Controls.Add(this.displayAllTechnik);
            this.repairPanel.Controls.Add(this.repairExit);
            this.repairPanel.Controls.Add(this.repairTable);
            this.repairPanel.Controls.Add(this.label14);
            this.repairPanel.Controls.Add(this.idRepair);
            this.repairPanel.Controls.Add(this.displayIdRepair);
            this.repairPanel.Controls.Add(this.displayAllRepair);
            this.repairPanel.Controls.Add(this.label16);
            this.repairPanel.Controls.Add(this.label17);
            this.repairPanel.Location = new System.Drawing.Point(161, 60);
            this.repairPanel.Name = "repairPanel";
            this.repairPanel.Size = new System.Drawing.Size(1195, 850);
            this.repairPanel.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(648, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 37);
            this.label13.TabIndex = 28;
            this.label13.Text = "Technik";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTechnik
            // 
            this.idTechnik.Location = new System.Drawing.Point(648, 343);
            this.idTechnik.Name = "idTechnik";
            this.idTechnik.Size = new System.Drawing.Size(110, 23);
            this.idTechnik.TabIndex = 27;
            this.idTechnik.Text = "id";
            this.idTechnik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdTechnik
            // 
            this.displayIdTechnik.Location = new System.Drawing.Point(648, 369);
            this.displayIdTechnik.Name = "displayIdTechnik";
            this.displayIdTechnik.Size = new System.Drawing.Size(110, 45);
            this.displayIdTechnik.TabIndex = 26;
            this.displayIdTechnik.Text = "DISPLAY BY ID";
            this.displayIdTechnik.UseVisualStyleBackColor = true;
            this.displayIdTechnik.Click += new System.EventHandler(this.displayIdTechnik_Click);
            // 
            // displayAllTechnik
            // 
            this.displayAllTechnik.Location = new System.Drawing.Point(648, 271);
            this.displayAllTechnik.Name = "displayAllTechnik";
            this.displayAllTechnik.Size = new System.Drawing.Size(110, 45);
            this.displayAllTechnik.TabIndex = 25;
            this.displayAllTechnik.Text = "DISPLAY ALL";
            this.displayAllTechnik.UseVisualStyleBackColor = true;
            this.displayAllTechnik.Click += new System.EventHandler(this.displayAllTechnik_Click);
            // 
            // repairExit
            // 
            this.repairExit.BackColor = System.Drawing.Color.Transparent;
            this.repairExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("repairExit.BackgroundImage")));
            this.repairExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.repairExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repairExit.Location = new System.Drawing.Point(12, 748);
            this.repairExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repairExit.Name = "repairExit";
            this.repairExit.Size = new System.Drawing.Size(68, 66);
            this.repairExit.TabIndex = 24;
            this.repairExit.UseVisualStyleBackColor = false;
            this.repairExit.Click += new System.EventHandler(this.repairExit_Click);
            // 
            // repairTable
            // 
            this.repairTable.AllowUserToAddRows = false;
            this.repairTable.AllowUserToDeleteRows = false;
            this.repairTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairTable.Location = new System.Drawing.Point(98, 475);
            this.repairTable.Name = "repairTable";
            this.repairTable.ReadOnly = true;
            this.repairTable.RowTemplate.Height = 25;
            this.repairTable.Size = new System.Drawing.Size(999, 339);
            this.repairTable.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(436, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 37);
            this.label14.TabIndex = 19;
            this.label14.Text = "Repair";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idRepair
            // 
            this.idRepair.Location = new System.Drawing.Point(426, 343);
            this.idRepair.Name = "idRepair";
            this.idRepair.Size = new System.Drawing.Size(110, 23);
            this.idRepair.TabIndex = 18;
            this.idRepair.Text = "id";
            this.idRepair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdRepair
            // 
            this.displayIdRepair.Location = new System.Drawing.Point(426, 369);
            this.displayIdRepair.Name = "displayIdRepair";
            this.displayIdRepair.Size = new System.Drawing.Size(110, 45);
            this.displayIdRepair.TabIndex = 17;
            this.displayIdRepair.Text = "DISPLAY BY ID";
            this.displayIdRepair.UseVisualStyleBackColor = true;
            this.displayIdRepair.Click += new System.EventHandler(this.displayIdRepair_Click);
            // 
            // displayAllRepair
            // 
            this.displayAllRepair.Location = new System.Drawing.Point(426, 271);
            this.displayAllRepair.Name = "displayAllRepair";
            this.displayAllRepair.Size = new System.Drawing.Size(110, 45);
            this.displayAllRepair.TabIndex = 16;
            this.displayAllRepair.Text = "DISPLAY ALL";
            this.displayAllRepair.UseVisualStyleBackColor = true;
            this.displayAllRepair.Click += new System.EventHandler(this.displayAllRepair_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(389, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(433, 72);
            this.label16.TabIndex = 9;
            this.label16.Text = "AUTOMECHANIK";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(475, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(231, 54);
            this.label17.TabIndex = 10;
            this.label17.Text = "Repair View";
            // 
            // viewExit
            // 
            this.viewExit.BackColor = System.Drawing.Color.Transparent;
            this.viewExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewExit.BackgroundImage")));
            this.viewExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.Location = new System.Drawing.Point(60, 831);
            this.viewExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewExit.Name = "viewExit";
            this.viewExit.Size = new System.Drawing.Size(82, 79);
            this.viewExit.TabIndex = 25;
            this.viewExit.UseVisualStyleBackColor = false;
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // vozidloPanel
            // 
            this.vozidloPanel.Controls.Add(this.label15);
            this.vozidloPanel.Controls.Add(this.idVozidlo);
            this.vozidloPanel.Controls.Add(this.displayIdVozidlo);
            this.vozidloPanel.Controls.Add(this.displayAllVozidlo);
            this.vozidloPanel.Controls.Add(this.vozidloExit);
            this.vozidloPanel.Controls.Add(this.vozidloTable);
            this.vozidloPanel.Controls.Add(this.label19);
            this.vozidloPanel.Controls.Add(this.label20);
            this.vozidloPanel.Location = new System.Drawing.Point(161, 60);
            this.vozidloPanel.Name = "vozidloPanel";
            this.vozidloPanel.Size = new System.Drawing.Size(1195, 850);
            this.vozidloPanel.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(532, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 37);
            this.label15.TabIndex = 28;
            this.label15.Text = "Vozidlo";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idVozidlo
            // 
            this.idVozidlo.Location = new System.Drawing.Point(532, 340);
            this.idVozidlo.Name = "idVozidlo";
            this.idVozidlo.Size = new System.Drawing.Size(110, 23);
            this.idVozidlo.TabIndex = 27;
            this.idVozidlo.Text = "id";
            this.idVozidlo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdVozidlo
            // 
            this.displayIdVozidlo.Location = new System.Drawing.Point(532, 366);
            this.displayIdVozidlo.Name = "displayIdVozidlo";
            this.displayIdVozidlo.Size = new System.Drawing.Size(110, 45);
            this.displayIdVozidlo.TabIndex = 26;
            this.displayIdVozidlo.Text = "DISPLAY BY ID";
            this.displayIdVozidlo.UseVisualStyleBackColor = true;
            this.displayIdVozidlo.Click += new System.EventHandler(this.displayIdVozidlo_Click);
            // 
            // displayAllVozidlo
            // 
            this.displayAllVozidlo.Location = new System.Drawing.Point(532, 268);
            this.displayAllVozidlo.Name = "displayAllVozidlo";
            this.displayAllVozidlo.Size = new System.Drawing.Size(110, 45);
            this.displayAllVozidlo.TabIndex = 25;
            this.displayAllVozidlo.Text = "DISPLAY ALL";
            this.displayAllVozidlo.UseVisualStyleBackColor = true;
            this.displayAllVozidlo.Click += new System.EventHandler(this.displayAllVozidlo_Click);
            // 
            // vozidloExit
            // 
            this.vozidloExit.BackColor = System.Drawing.Color.Transparent;
            this.vozidloExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vozidloExit.BackgroundImage")));
            this.vozidloExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vozidloExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vozidloExit.Location = new System.Drawing.Point(12, 748);
            this.vozidloExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vozidloExit.Name = "vozidloExit";
            this.vozidloExit.Size = new System.Drawing.Size(68, 66);
            this.vozidloExit.TabIndex = 24;
            this.vozidloExit.UseVisualStyleBackColor = false;
            this.vozidloExit.Click += new System.EventHandler(this.vozidloExit_Click);
            // 
            // vozidloTable
            // 
            this.vozidloTable.AllowUserToAddRows = false;
            this.vozidloTable.AllowUserToDeleteRows = false;
            this.vozidloTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vozidloTable.Location = new System.Drawing.Point(98, 475);
            this.vozidloTable.Name = "vozidloTable";
            this.vozidloTable.ReadOnly = true;
            this.vozidloTable.RowTemplate.Height = 25;
            this.vozidloTable.Size = new System.Drawing.Size(999, 339);
            this.vozidloTable.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(389, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(433, 72);
            this.label19.TabIndex = 9;
            this.label19.Text = "AUTOMECHANIK";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(475, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(231, 54);
            this.label20.TabIndex = 10;
            this.label20.Text = "Repair View";
            // 
            // zavadaPanel
            // 
            this.zavadaPanel.Controls.Add(this.label25);
            this.zavadaPanel.Controls.Add(this.label24);
            this.zavadaPanel.Controls.Add(this.label18);
            this.zavadaPanel.Controls.Add(this.idNalez);
            this.zavadaPanel.Controls.Add(this.displayIdNalez);
            this.zavadaPanel.Controls.Add(this.displayAllNalez);
            this.zavadaPanel.Controls.Add(this.zavadaExit);
            this.zavadaPanel.Controls.Add(this.zavadaTable);
            this.zavadaPanel.Controls.Add(this.label21);
            this.zavadaPanel.Controls.Add(this.idZavada);
            this.zavadaPanel.Controls.Add(this.displayIdZavada);
            this.zavadaPanel.Controls.Add(this.displayAllZavada);
            this.zavadaPanel.Controls.Add(this.label22);
            this.zavadaPanel.Controls.Add(this.label23);
            this.zavadaPanel.Location = new System.Drawing.Point(161, 60);
            this.zavadaPanel.Name = "zavadaPanel";
            this.zavadaPanel.Size = new System.Drawing.Size(1195, 850);
            this.zavadaPanel.TabIndex = 29;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(446, 325);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 15);
            this.label24.TabIndex = 29;
            this.label24.Text = "(Kontrola ID)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(660, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 37);
            this.label18.TabIndex = 28;
            this.label18.Text = "Nalez";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idNalez
            // 
            this.idNalez.Location = new System.Drawing.Point(648, 343);
            this.idNalez.Name = "idNalez";
            this.idNalez.Size = new System.Drawing.Size(110, 23);
            this.idNalez.TabIndex = 27;
            this.idNalez.Text = "id";
            this.idNalez.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdNalez
            // 
            this.displayIdNalez.Location = new System.Drawing.Point(648, 369);
            this.displayIdNalez.Name = "displayIdNalez";
            this.displayIdNalez.Size = new System.Drawing.Size(110, 45);
            this.displayIdNalez.TabIndex = 26;
            this.displayIdNalez.Text = "DISPLAY BY ID";
            this.displayIdNalez.UseVisualStyleBackColor = true;
            this.displayIdNalez.Click += new System.EventHandler(this.displayIdNalez_Click);
            // 
            // displayAllNalez
            // 
            this.displayAllNalez.Location = new System.Drawing.Point(648, 271);
            this.displayAllNalez.Name = "displayAllNalez";
            this.displayAllNalez.Size = new System.Drawing.Size(110, 45);
            this.displayAllNalez.TabIndex = 25;
            this.displayAllNalez.Text = "DISPLAY ALL";
            this.displayAllNalez.UseVisualStyleBackColor = true;
            this.displayAllNalez.Click += new System.EventHandler(this.displayAllNalez_Click);
            // 
            // zavadaExit
            // 
            this.zavadaExit.BackColor = System.Drawing.Color.Transparent;
            this.zavadaExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zavadaExit.BackgroundImage")));
            this.zavadaExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zavadaExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zavadaExit.Location = new System.Drawing.Point(12, 748);
            this.zavadaExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zavadaExit.Name = "zavadaExit";
            this.zavadaExit.Size = new System.Drawing.Size(68, 66);
            this.zavadaExit.TabIndex = 24;
            this.zavadaExit.UseVisualStyleBackColor = false;
            this.zavadaExit.Click += new System.EventHandler(this.zavadaExit_Click);
            // 
            // zavadaTable
            // 
            this.zavadaTable.AllowUserToAddRows = false;
            this.zavadaTable.AllowUserToDeleteRows = false;
            this.zavadaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zavadaTable.Location = new System.Drawing.Point(98, 475);
            this.zavadaTable.Name = "zavadaTable";
            this.zavadaTable.ReadOnly = true;
            this.zavadaTable.RowTemplate.Height = 25;
            this.zavadaTable.Size = new System.Drawing.Size(999, 339);
            this.zavadaTable.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(426, 217);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 37);
            this.label21.TabIndex = 19;
            this.label21.Text = "Zavada";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idZavada
            // 
            this.idZavada.Location = new System.Drawing.Point(426, 343);
            this.idZavada.Name = "idZavada";
            this.idZavada.Size = new System.Drawing.Size(110, 23);
            this.idZavada.TabIndex = 18;
            this.idZavada.Text = "id";
            this.idZavada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayIdZavada
            // 
            this.displayIdZavada.Location = new System.Drawing.Point(426, 369);
            this.displayIdZavada.Name = "displayIdZavada";
            this.displayIdZavada.Size = new System.Drawing.Size(110, 45);
            this.displayIdZavada.TabIndex = 17;
            this.displayIdZavada.Text = "DISPLAY BY ID";
            this.displayIdZavada.UseVisualStyleBackColor = true;
            this.displayIdZavada.Click += new System.EventHandler(this.displayIdZavada_Click);
            // 
            // displayAllZavada
            // 
            this.displayAllZavada.Location = new System.Drawing.Point(426, 271);
            this.displayAllZavada.Name = "displayAllZavada";
            this.displayAllZavada.Size = new System.Drawing.Size(110, 45);
            this.displayAllZavada.TabIndex = 16;
            this.displayAllZavada.Text = "DISPLAY ALL";
            this.displayAllZavada.UseVisualStyleBackColor = true;
            this.displayAllZavada.Click += new System.EventHandler(this.displayAllZavada_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(389, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(433, 72);
            this.label22.TabIndex = 9;
            this.label22.Text = "AUTOMECHANIK";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(475, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(234, 54);
            this.label23.TabIndex = 10;
            this.label23.Text = "Defect View";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(670, 325);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 15);
            this.label25.TabIndex = 30;
            this.label25.Text = "(Kontrola ID)";
            // 
            // View
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1480, 957);
            this.Controls.Add(this.zavadaPanel);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.repairPanel);
            this.Controls.Add(this.vozidloPanel);
            this.Controls.Add(this.personPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMECHANIK";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.personPanel.ResumeLayout(false);
            this.personPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provozovatelTable)).EndInit();
            this.repairPanel.ResumeLayout(false);
            this.repairPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairTable)).EndInit();
            this.vozidloPanel.ResumeLayout(false);
            this.vozidloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozidloTable)).EndInit();
            this.zavadaPanel.ResumeLayout(false);
            this.zavadaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zavadaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label7;
        private Label label5;
        private Button vechicleButtonView;
        private Label label2;
        private Button repairsButtonView;
        private Label label3;
        private Button personButtonView;
        private Label label6;
        private Button defectButtonView;
        private Panel mainMenu;
        private Panel personPanel;
        private Label label8;
        private Label label9;
        private TextBox idProvoz;
        private Button displayIdProvoz;
        private Button displayAllProvoz;
        private Label label11;
        private TextBox IdFyzicka;
        private Button displayIdFyzicka;
        private Button displayAllFyzicka;
        private Label label10;
        private Label label12;
        private TextBox idPravnicka;
        private Button displayIdPravnicka;
        private Button displayAllPravnicka;
        private DataGridView provozovatelTable;
        private Button personExit;
        private Panel repairPanel;
        private Button repairExit;
        private DataGridView repairTable;
        private Label label14;
        private TextBox idRepair;
        private Button displayIdRepair;
        private Button displayAllRepair;
        private Label label16;
        private Label label17;
        private Button viewExit;
        private Label label13;
        private TextBox idTechnik;
        private Button displayIdTechnik;
        private Button displayAllTechnik;
        private Panel vozidloPanel;
        private Label label15;
        private TextBox idVozidlo;
        private Button displayIdVozidlo;
        private Button displayAllVozidlo;
        private Button vozidloExit;
        private DataGridView vozidloTable;
        private Label label19;
        private Label label20;
        private Panel zavadaPanel;
        private Label label18;
        private TextBox idNalez;
        private Button displayIdNalez;
        private Button displayAllNalez;
        private Button zavadaExit;
        private DataGridView zavadaTable;
        private Label label21;
        private TextBox idZavada;
        private Button displayIdZavada;
        private Button displayAllZavada;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
    }
}