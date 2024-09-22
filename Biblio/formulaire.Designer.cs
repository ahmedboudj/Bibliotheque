namespace Biblio
{
    partial class formulaire
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
            btnNouveau = new Button();
            btnAjouter = new Button();
            btnSuprimer = new Button();
            rdbMasculin = new RadioButton();
            rdbFéminin = new RadioButton();
            label1 = new Label();
            Prénom = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxID = new TextBox();
            tbxPrénom = new TextBox();
            tbxNom = new TextBox();
            tbxAdresse = new TextBox();
            label6 = new Label();
            dtgEtudiant = new DataGridView();
            btnQuitter = new Button();
            btnacceuil = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEtudiant).BeginInit();
            SuspendLayout();
            // 
            // btnNouveau
            // 
            btnNouveau.Location = new Point(188, 349);
            btnNouveau.Name = "btnNouveau";
            btnNouveau.Size = new Size(94, 29);
            btnNouveau.TabIndex = 9;
            btnNouveau.Text = "Nouveau";
            btnNouveau.UseVisualStyleBackColor = true;
            btnNouveau.Click += btnNouveau_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(330, 349);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 10;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnSuprimer
            // 
            btnSuprimer.Location = new Point(482, 349);
            btnSuprimer.Name = "btnSuprimer";
            btnSuprimer.Size = new Size(94, 29);
            btnSuprimer.TabIndex = 12;
            btnSuprimer.Text = "Suprimer";
            btnSuprimer.UseVisualStyleBackColor = true;
            btnSuprimer.Click += btnSuprimer_Click;
            // 
            // rdbMasculin
            // 
            rdbMasculin.AutoSize = true;
            rdbMasculin.Location = new Point(237, 285);
            rdbMasculin.Name = "rdbMasculin";
            rdbMasculin.Size = new Size(88, 24);
            rdbMasculin.TabIndex = 5;
            rdbMasculin.TabStop = true;
            rdbMasculin.Text = "Masculin";
            rdbMasculin.UseVisualStyleBackColor = true;
            // 
            // rdbFéminin
            // 
            rdbFéminin.AutoSize = true;
            rdbFéminin.Location = new Point(342, 287);
            rdbFéminin.Name = "rdbFéminin";
            rdbFéminin.Size = new Size(82, 24);
            rdbFéminin.TabIndex = 6;
            rdbFéminin.TabStop = true;
            rdbFéminin.Text = "Féminin";
            rdbFéminin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 202);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Nom";
            // 
            // Prénom
            // 
            Prénom.AutoSize = true;
            Prénom.Location = new Point(131, 165);
            Prénom.Name = "Prénom";
            Prénom.Size = new Size(60, 20);
            Prénom.TabIndex = 6;
            Prénom.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 123);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 241);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 8;
            label4.Text = "Adresse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 287);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 9;
            label5.Text = "Sexe";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(237, 123);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(125, 27);
            tbxID.TabIndex = 0;
            // 
            // tbxPrénom
            // 
            tbxPrénom.Location = new Point(237, 165);
            tbxPrénom.Name = "tbxPrénom";
            tbxPrénom.Size = new Size(125, 27);
            tbxPrénom.TabIndex = 2;
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(237, 202);
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(125, 27);
            tbxNom.TabIndex = 3;
            // 
            // tbxAdresse
            // 
            tbxAdresse.Location = new Point(237, 238);
            tbxAdresse.Name = "tbxAdresse";
            tbxAdresse.Size = new Size(125, 27);
            tbxAdresse.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 43);
            label6.Name = "label6";
            label6.Size = new Size(336, 20);
            label6.TabIndex = 14;
            label6.Text = "FORMULAIR D'INSCRIPTION A LA BIBLIOTHÉQUE ";
            // 
            // dtgEtudiant
            // 
            dtgEtudiant.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgEtudiant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEtudiant.Location = new Point(505, 123);
            dtgEtudiant.Name = "dtgEtudiant";
            dtgEtudiant.RowHeadersWidth = 51;
            dtgEtudiant.RowTemplate.Height = 29;
            dtgEtudiant.Size = new Size(268, 142);
            dtgEtudiant.TabIndex = 15;
            dtgEtudiant.CellContentClick += dtgEtudiant_CellContentClick;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(634, 349);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(94, 29);
            btnQuitter.TabIndex = 13;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnacceuil
            // 
            btnacceuil.Location = new Point(61, 349);
            btnacceuil.Name = "btnacceuil";
            btnacceuil.Size = new Size(94, 29);
            btnacceuil.TabIndex = 16;
            btnacceuil.Text = "Acceuil";
            btnacceuil.UseVisualStyleBackColor = true;
            btnacceuil.Click += btnacceuil_Click;
            // 
            // formulaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnacceuil);
            Controls.Add(btnQuitter);
            Controls.Add(dtgEtudiant);
            Controls.Add(label6);
            Controls.Add(tbxAdresse);
            Controls.Add(tbxNom);
            Controls.Add(tbxPrénom);
            Controls.Add(tbxID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Prénom);
            Controls.Add(label1);
            Controls.Add(rdbFéminin);
            Controls.Add(rdbMasculin);
            Controls.Add(btnSuprimer);
            Controls.Add(btnAjouter);
            Controls.Add(btnNouveau);
            Name = "formulaire";
            Text = "formulaire";
            ((System.ComponentModel.ISupportInitialize)dtgEtudiant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNouveau;
        private Button btnAjouter;
        private Button btnSuprimer;
        private RadioButton rdbMasculin;
        private RadioButton rdbFéminin;
        private Label label1;
        private Label Prénom;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxID;
        private TextBox tbxPrénom;
        private TextBox tbxNom;
        private TextBox tbxAdresse;
        private Label label6;
        private DataGridView dtgEtudiant;
        private Button btnQuitter;
        private Button btnacceuil;
    }
}