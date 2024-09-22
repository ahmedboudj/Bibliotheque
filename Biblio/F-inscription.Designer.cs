namespace Biblio
{
    partial class F_inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_inscription));
            ID = new Label();
            Nom = new Label();
            Prénom = new Label();
            Age = new Label();
            Sexe = new Label();
            Adresse = new Label();
            rdbMasculin = new RadioButton();
            rdbFéminin = new RadioButton();
            tbxID = new TextBox();
            tbxNom = new TextBox();
            tbxPrénom = new TextBox();
            tbxAge = new TextBox();
            tbxAdresse = new TextBox();
            label1 = new Label();
            btnNouveau = new Button();
            btnConfirmer = new Button();
            btnSuprimer = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(207, 122);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(207, 174);
            Nom.Name = "Nom";
            Nom.Size = new Size(42, 20);
            Nom.TabIndex = 1;
            Nom.Text = "Nom";
            // 
            // Prénom
            // 
            Prénom.AutoSize = true;
            Prénom.Location = new Point(207, 223);
            Prénom.Name = "Prénom";
            Prénom.Size = new Size(60, 20);
            Prénom.TabIndex = 2;
            Prénom.Text = "Prénom";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(207, 269);
            Age.Name = "Age";
            Age.Size = new Size(36, 20);
            Age.TabIndex = 3;
            Age.Text = "Age";
            Age.Click += label4_Click;
            // 
            // Sexe
            // 
            Sexe.AutoSize = true;
            Sexe.Location = new Point(207, 317);
            Sexe.Name = "Sexe";
            Sexe.Size = new Size(40, 20);
            Sexe.TabIndex = 4;
            Sexe.Text = "Sexe";
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Location = new Point(207, 377);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(61, 20);
            Adresse.TabIndex = 5;
            Adresse.Text = "Adresse";
            // 
            // rdbMasculin
            // 
            rdbMasculin.AutoSize = true;
            rdbMasculin.BackColor = SystemColors.InactiveBorder;
            rdbMasculin.Location = new Point(322, 315);
            rdbMasculin.Name = "rdbMasculin";
            rdbMasculin.RightToLeft = RightToLeft.No;
            rdbMasculin.Size = new Size(88, 24);
            rdbMasculin.TabIndex = 4;
            rdbMasculin.TabStop = true;
            rdbMasculin.Text = "Masculin";
            rdbMasculin.UseVisualStyleBackColor = true;
            // 
            // rdbFéminin
            // 
            rdbFéminin.AutoSize = true;
            rdbFéminin.Location = new Point(429, 315);
            rdbFéminin.Name = "rdbFéminin";
            rdbFéminin.Size = new Size(86, 24);
            rdbFéminin.TabIndex = 5;
            rdbFéminin.Text = "Féminin ";
            rdbFéminin.UseVisualStyleBackColor = true;
            // 
            // tbxID
            // 
            tbxID.Location = new Point(322, 122);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(193, 27);
            tbxID.TabIndex = 0;
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(322, 167);
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(193, 27);
            tbxNom.TabIndex = 1;
            // 
            // tbxPrénom
            // 
            tbxPrénom.Location = new Point(322, 216);
            tbxPrénom.Name = "tbxPrénom";
            tbxPrénom.Size = new Size(193, 27);
            tbxPrénom.TabIndex = 2;
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(322, 262);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(193, 27);
            tbxAge.TabIndex = 3;
            // 
            // tbxAdresse
            // 
            tbxAdresse.Location = new Point(322, 377);
            tbxAdresse.Name = "tbxAdresse";
            tbxAdresse.Size = new Size(193, 27);
            tbxAdresse.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(322, 31);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 14;
            label1.Text = "FORMULAIRE D'INSCRIPTION";
            // 
            // btnNouveau
            // 
            btnNouveau.Location = new Point(207, 447);
            btnNouveau.Name = "btnNouveau";
            btnNouveau.Size = new Size(111, 47);
            btnNouveau.TabIndex = 7;
            btnNouveau.Text = "Nouveau";
            btnNouveau.UseVisualStyleBackColor = true;
            btnNouveau.Click += Nouveau_Click;
            // 
            // btnConfirmer
            // 
            btnConfirmer.Location = new Point(377, 447);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(125, 47);
            btnConfirmer.TabIndex = 8;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // btnSuprimer
            // 
            btnSuprimer.Location = new Point(552, 447);
            btnSuprimer.Name = "btnSuprimer";
            btnSuprimer.Size = new Size(124, 47);
            btnSuprimer.TabIndex = 9;
            btnSuprimer.Text = "Suprimer";
            btnSuprimer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(552, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(295, 188);
            dataGridView1.TabIndex = 15;
            // 
            // F_inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(862, 506);
            Controls.Add(dataGridView1);
            Controls.Add(btnSuprimer);
            Controls.Add(btnConfirmer);
            Controls.Add(btnNouveau);
            Controls.Add(label1);
            Controls.Add(tbxAdresse);
            Controls.Add(tbxAge);
            Controls.Add(tbxPrénom);
            Controls.Add(tbxNom);
            Controls.Add(tbxID);
            Controls.Add(rdbFéminin);
            Controls.Add(rdbMasculin);
            Controls.Add(Adresse);
            Controls.Add(Sexe);
            Controls.Add(Age);
            Controls.Add(Prénom);
            Controls.Add(Nom);
            Controls.Add(ID);
            Cursor = Cursors.Default;
            Name = "F_inscription";
            Text = "F_inscription";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label Nom;
        private Label Prénom;
        private Label Age;
        private Label Sexe;
        private Label Adresse;
        private RadioButton rdbMasculin;
        private RadioButton rdbFéminin;
        private TextBox tbxID;
        private TextBox tbxNom;
        private TextBox tbxPrénom;
        private TextBox tbxAge;
        private TextBox tbxAdresse;
        private Label label1;
        private Button btnNouveau;
        private Button btnConfirmer;
        private Button btnSuprimer;
        private DataGridView dataGridView1;
    }
}