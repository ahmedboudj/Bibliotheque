namespace Biblio
{
    public partial class Ce_connecter : Form
    {
        public Ce_connecter()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin")
            {
                if (txtpass.Text == "admin")
                {
                    new livre().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur,SVP Entrer les informations exacte");
                }
            }
            else
            {
                MessageBox.Show("Erreur,SVP Entrer les informations exacte");
            }
        }

        private void btnacceuil_Click(object sender, EventArgs e)
        {
            var C = new Form1();
            C.Show();
            this.Hide();
        }
    }
}
