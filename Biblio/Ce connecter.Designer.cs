namespace Biblio
{
    partial class Ce_connecter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ce_connecter));
            label1 = new Label();
            Password = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            LOGIN = new Label();
            btnQuitter = new Button();
            btnlogin = new Button();
            btnacceuil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 153);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(219, 231);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(349, 146);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(125, 27);
            txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(349, 224);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(125, 27);
            txtpass.TabIndex = 3;
            // 
            // LOGIN
            // 
            LOGIN.AutoSize = true;
            LOGIN.Location = new Point(349, 33);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(51, 20);
            LOGIN.TabIndex = 4;
            LOGIN.Text = "LOGIN";
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(468, 338);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(94, 29);
            btnQuitter.TabIndex = 5;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(229, 338);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnacceuil
            // 
            btnacceuil.Location = new Point(349, 338);
            btnacceuil.Name = "btnacceuil";
            btnacceuil.Size = new Size(94, 29);
            btnacceuil.TabIndex = 7;
            btnacceuil.Text = "Acceuil";
            btnacceuil.UseVisualStyleBackColor = true;
            btnacceuil.Click += btnacceuil_Click;
            // 
            // Ce_connecter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(718, 422);
            Controls.Add(btnacceuil);
            Controls.Add(btnlogin);
            Controls.Add(btnQuitter);
            Controls.Add(LOGIN);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(Password);
            Controls.Add(label1);
            Name = "Ce_connecter";
            Text = "Ce_connecter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Password;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label LOGIN;
        private Button btnQuitter;
        private Button btnlogin;
        private Button btnacceuil;
    }
}