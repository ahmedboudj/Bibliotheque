namespace Biblio
{
    public partial class livre : Form
    {
        public livre()
        {
            InitializeComponent();
        }

        private void btnnouveau_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txttitre.Clear();
            txtauteur.Clear();
            txtdate.Clear();
            txtretour.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            livre1 livre = new livre1();
            livre.Numéro_du_livre = Int32.Parse(txtnumero.Text);
            livre.titre = txttitre.Text;
            livre.auteur = txtauteur.Text;
            livre.Date_et_heure_Ajout_Emprunt = txtdate.Text;
            livre.Date_et_heure_du_Retour = txtretour.Text;

            bool validation = livre.ajouterlivre(livre);
            if (validation == false)
            {
                Liste1.listLivre.Add(livre);
                MessageBox.Show("Vous etes ajouter un livre a la bibliothéque avec succes !");
            }
            else MessageBox.Show("!!! Le livre éxiste deja !!!");

            dtglivre.DataSource = null; // effacer les donnes avant dafficher
            dtglivre.DataSource = Liste1.listLivre;
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            string matricule = dtglivre.CurrentRow.Cells[0].Value.ToString();

            foreach (livre1 livre in Liste1.listLivre)
            {
                if (livre.Numéro_du_livre == Int32.Parse(matricule))
                {
                    Liste1.listLivre.Remove(livre);
                    break;
                }

            }
            dtglivre.DataSource = null; // effacer les donnes avant dafficher
            dtglivre.DataSource = Liste1.listLivre;
            MessageBox.Show("Le livre a été retirer avec succés !");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            livre1 livre = new livre1();
            livre.Numéro_du_livre = Int32.Parse(txtnumero.Text);
            livre.titre = txttitre.Text;
            livre.auteur = txtauteur.Text;
            livre.Date_et_heure_Ajout_Emprunt = txtdate.Text;
            livre.Date_et_heure_du_Retour = txtretour.Text;

            bool validation = livre.emprunterlivre(livre);
            if (validation == false)
            {
                Liste1.listLivre.Add(livre);
                MessageBox.Show("Vous avez Emprunter un livre a la bibliothéque avec succes !");
            }
            else MessageBox.Show("!!! Le livre est des emprunter !!!");

            dtglivre.DataSource = null; // effacer les donnes avant dafficher
            dtglivre.DataSource = Liste1.listLivre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnacceuil_Click(object sender, EventArgs e)
        {
            var C = new Form1();
            C.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            livre1 livre = new livre1();
            livre.Numéro_du_livre = Int32.Parse(txtnumero.Text);
            livre.titre = txttitre.Text;
            livre.auteur = txtauteur.Text;
            livre.Date_et_heure_Ajout_Emprunt = txtdate.Text;
            livre.Date_et_heure_du_Retour = txtretour.Text;

            bool validation = livre.emprunterlivre(livre);
            if (validation == false)
            {
                Liste1.listLivre.Add(livre);
                MessageBox.Show("Vous avez remis un livre emprunter a la bibliothéque avec succes !");
            }
            else MessageBox.Show("!!! Le livre est des emprunter !!!");

            dtglivre.DataSource = null; // effacer les donnes avant dafficher
            dtglivre.DataSource = Liste1.listLivre;
        }
    }
}
