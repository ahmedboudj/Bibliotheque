namespace Biblio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            inscription = new Button();
            button2 = new Button();
            button3 = new Button();
            btnQuitter = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripDropDownButton();
            ajouterUnLivreToolStripMenuItem = new ToolStripMenuItem();
            emprunterUnLivreToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripDropDownButton();
            saisirVotreUsernameEtMotDePasseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripDropDownButton();
            formulaireDinscriptionToolStripMenuItem = new ToolStripMenuItem();
            fermerToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(260, 108);
            label1.Name = "label1";
            label1.Size = new Size(334, 20);
            label1.TabIndex = 0;
            label1.Text = "BIENVENU DANS LA BIBLIOTHÉQUE DE TECCART\r\n";
            label1.Click += label1_Click;
            // 
            // inscription
            // 
            inscription.BackColor = SystemColors.ActiveCaption;
            inscription.Location = new Point(44, 393);
            inscription.Name = "inscription";
            inscription.Size = new Size(146, 53);
            inscription.TabIndex = 1;
            inscription.Text = "S'inscrire";
            inscription.TextImageRelation = TextImageRelation.ImageAboveText;
            inscription.UseVisualStyleBackColor = false;
            inscription.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(245, 393);
            button2.Name = "button2";
            button2.Size = new Size(146, 53);
            button2.TabIndex = 2;
            button2.Text = "Ce connecter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(448, 393);
            button3.Name = "button3";
            button3.Size = new Size(146, 53);
            button3.TabIndex = 3;
            button3.Text = "Magaziner";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = SystemColors.ActiveCaption;
            btnQuitter.Location = new Point(636, 393);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(146, 53);
            btnQuitter.TabIndex = 4;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, toolStripLabel2, toolStripSeparator2, toolStripLabel3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(839, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "bibliothéque";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.DropDownItems.AddRange(new ToolStripItem[] { ajouterUnLivreToolStripMenuItem, emprunterUnLivreToolStripMenuItem, fermerToolStripMenuItem });
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(108, 24);
            toolStripLabel1.Text = "bibliothéque";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // ajouterUnLivreToolStripMenuItem
            // 
            ajouterUnLivreToolStripMenuItem.Name = "ajouterUnLivreToolStripMenuItem";
            ajouterUnLivreToolStripMenuItem.Size = new Size(224, 26);
            ajouterUnLivreToolStripMenuItem.Text = "Ajouter un livre";
            ajouterUnLivreToolStripMenuItem.Click += ajouterUnLivreToolStripMenuItem_Click;
            // 
            // emprunterUnLivreToolStripMenuItem
            // 
            emprunterUnLivreToolStripMenuItem.Name = "emprunterUnLivreToolStripMenuItem";
            emprunterUnLivreToolStripMenuItem.Size = new Size(224, 26);
            emprunterUnLivreToolStripMenuItem.Text = "Emprunter un livre";
            emprunterUnLivreToolStripMenuItem.Click += emprunterUnLivreToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.DropDownItems.AddRange(new ToolStripItem[] { saisirVotreUsernameEtMotDePasseToolStripMenuItem });
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(60, 24);
            toolStripLabel2.Text = "Login";
            // 
            // saisirVotreUsernameEtMotDePasseToolStripMenuItem
            // 
            saisirVotreUsernameEtMotDePasseToolStripMenuItem.Name = "saisirVotreUsernameEtMotDePasseToolStripMenuItem";
            saisirVotreUsernameEtMotDePasseToolStripMenuItem.Size = new Size(345, 26);
            saisirVotreUsernameEtMotDePasseToolStripMenuItem.Text = "Saisir votre Username et mot de passe";
            saisirVotreUsernameEtMotDePasseToolStripMenuItem.Click += saisirVotreUsernameEtMotDePasseToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.DropDownItems.AddRange(new ToolStripItem[] { formulaireDinscriptionToolStripMenuItem });
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(142, 24);
            toolStripLabel3.Text = "Nouveau membre";
            // 
            // formulaireDinscriptionToolStripMenuItem
            // 
            formulaireDinscriptionToolStripMenuItem.Name = "formulaireDinscriptionToolStripMenuItem";
            formulaireDinscriptionToolStripMenuItem.Size = new Size(250, 26);
            formulaireDinscriptionToolStripMenuItem.Text = "Formulaire D'inscription";
            formulaireDinscriptionToolStripMenuItem.Click += formulaireDinscriptionToolStripMenuItem_Click;
            // 
            // fermerToolStripMenuItem
            // 
            fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            fermerToolStripMenuItem.Size = new Size(224, 26);
            fermerToolStripMenuItem.Text = "Fermer";
            fermerToolStripMenuItem.Click += fermerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(839, 475);
            Controls.Add(toolStrip1);
            Controls.Add(btnQuitter);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(inscription);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button inscription;
        private Button button2;
        private Button button3;
        private Button btnQuitter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripLabel1;
        private ToolStripMenuItem ajouterUnLivreToolStripMenuItem;
        private ToolStripMenuItem emprunterUnLivreToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripLabel2;
        private ToolStripMenuItem saisirVotreUsernameEtMotDePasseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripLabel3;
        private ToolStripMenuItem formulaireDinscriptionToolStripMenuItem;
        private ToolStripMenuItem fermerToolStripMenuItem;
    }
}