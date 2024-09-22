namespace Biblio
{
    partial class livre
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdateretour = new Label();
            txtnumero = new TextBox();
            txttitre = new TextBox();
            txtauteur = new TextBox();
            txtdate = new TextBox();
            txtretour = new TextBox();
            dtglivre = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnnouveau = new Button();
            btnsupprimer = new Button();
            btnacceuil = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtglivre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 59);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Numéro du livre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 109);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Titre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 167);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Auteur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 225);
            label4.Name = "label4";
            label4.Size = new Size(201, 20);
            label4.TabIndex = 3;
            label4.Text = "Date et heure Ajout/Emprunt";
            // 
            // txtdateretour
            // 
            txtdateretour.AutoSize = true;
            txtdateretour.Location = new Point(36, 283);
            txtdateretour.Name = "txtdateretour";
            txtdateretour.Size = new Size(168, 20);
            txtdateretour.TabIndex = 4;
            txtdateretour.Text = "Date et heure du Retour";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(260, 52);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(125, 27);
            txtnumero.TabIndex = 5;
            // 
            // txttitre
            // 
            txttitre.Location = new Point(260, 106);
            txttitre.Name = "txttitre";
            txttitre.Size = new Size(125, 27);
            txttitre.TabIndex = 6;
            // 
            // txtauteur
            // 
            txtauteur.Location = new Point(260, 164);
            txtauteur.Name = "txtauteur";
            txtauteur.Size = new Size(125, 27);
            txtauteur.TabIndex = 7;
            // 
            // txtdate
            // 
            txtdate.Location = new Point(260, 225);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(125, 27);
            txtdate.TabIndex = 8;
            // 
            // txtretour
            // 
            txtretour.Location = new Point(260, 276);
            txtretour.Name = "txtretour";
            txtretour.Size = new Size(125, 27);
            txtretour.TabIndex = 9;
            // 
            // dtglivre
            // 
            dtglivre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtglivre.Location = new Point(441, 52);
            dtglivre.Name = "dtglivre";
            dtglivre.RowHeadersWidth = 51;
            dtglivre.RowTemplate.Height = 29;
            dtglivre.Size = new Size(347, 251);
            dtglivre.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(12, 333);
            button1.Name = "button1";
            button1.Size = new Size(162, 41);
            button1.TabIndex = 11;
            button1.Text = "Ajouter un livre";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(196, 333);
            button2.Name = "button2";
            button2.Size = new Size(162, 41);
            button2.TabIndex = 12;
            button2.Text = "Emprunter un livre";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(664, 397);
            button3.Name = "button3";
            button3.Size = new Size(124, 41);
            button3.TabIndex = 13;
            button3.Text = "Quitter";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnnouveau
            // 
            btnnouveau.BackColor = SystemColors.ActiveCaption;
            btnnouveau.Location = new Point(12, 397);
            btnnouveau.Name = "btnnouveau";
            btnnouveau.Size = new Size(104, 41);
            btnnouveau.TabIndex = 14;
            btnnouveau.Text = "Nouveau";
            btnnouveau.UseVisualStyleBackColor = false;
            btnnouveau.Click += btnnouveau_Click;
            // 
            // btnsupprimer
            // 
            btnsupprimer.BackColor = SystemColors.ActiveCaption;
            btnsupprimer.Location = new Point(612, 333);
            btnsupprimer.Name = "btnsupprimer";
            btnsupprimer.Size = new Size(162, 41);
            btnsupprimer.TabIndex = 15;
            btnsupprimer.Text = "Supprimer";
            btnsupprimer.UseVisualStyleBackColor = false;
            btnsupprimer.Click += btnsupprimer_Click;
            // 
            // btnacceuil
            // 
            btnacceuil.BackColor = SystemColors.ActiveCaption;
            btnacceuil.Location = new Point(310, 397);
            btnacceuil.Name = "btnacceuil";
            btnacceuil.Size = new Size(124, 41);
            btnacceuil.TabIndex = 16;
            btnacceuil.Text = "Acceuil";
            btnacceuil.UseVisualStyleBackColor = false;
            btnacceuil.Click += btnacceuil_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(383, 333);
            button4.Name = "button4";
            button4.Size = new Size(223, 41);
            button4.TabIndex = 17;
            button4.Text = "Retourner un  livre emprunter";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // livre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(btnacceuil);
            Controls.Add(btnsupprimer);
            Controls.Add(btnnouveau);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtglivre);
            Controls.Add(txtretour);
            Controls.Add(txtdate);
            Controls.Add(txtauteur);
            Controls.Add(txttitre);
            Controls.Add(txtnumero);
            Controls.Add(txtdateretour);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "livre";
            Text = "livre";
            ((System.ComponentModel.ISupportInitialize)dtglivre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label txtdateretour;
        private TextBox txtnumero;
        private TextBox txttitre;
        private TextBox txtauteur;
        private TextBox txtdate;
        private TextBox txtretour;
        private DataGridView dtglivre;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnnouveau;
        private Button btnsupprimer;
        private Button btnacceuil;
        private Button button4;
    }
}