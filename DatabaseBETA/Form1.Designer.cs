namespace DatabaseBETA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(332, -22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOMECHANIK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Location = new System.Drawing.Point(639, 684);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(143, 94);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(535, 512);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(352, 35);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(535, 607);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(352, 35);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "PASSWORD";
            // 
            // guestButton
            // 
            this.guestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestButton.Location = new System.Drawing.Point(657, 827);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(104, 40);
            this.guestButton.TabIndex = 7;
            this.guestButton.Text = "GUEST";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 930);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button loginButton;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label2;
        private Label label3;
        private Button guestButton;
    }
}