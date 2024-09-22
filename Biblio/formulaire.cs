namespace Biblio
{
    public partial class formulaire : Form
    {
        public formulaire()
        {
            InitializeComponent();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            tbxID.Clear();
            tbxNom.Clear();
            tbxPrénom.Clear();
            tbxAdresse.Clear();
            rdbMasculin.Checked = false;
            rdbFéminin.Checked = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant();
            etudiant.Id = Int32.Parse(tbxID.Text);
            etudiant.Nom = tbxNom.Text;
            etudiant.Prenom = tbxPrénom.Text;
            etudiant.adresse = tbxAdresse.Text;
            if (rdbMasculin.Checked == true) { etudiant.Sexe = "Masculin"; }
            if (rdbFéminin.Checked == true) { etudiant.Sexe = "Feminin"; }

            bool validation = etudiant.ajouterEtudiant(etudiant);
            if (validation == false)
            {
                Liste.listEtudiant.Add(etudiant);
                MessageBox.Show("Vous etes ajouter a la bibliothéque avec succes !");
            }
            else MessageBox.Show("!!! l'etudiant éxiste deja !!!");

            dtgEtudiant.DataSource = null; // effacer les donnes avant dafficher
            dtgEtudiant.DataSource = Liste.listEtudiant;
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            string matricule = dtgEtudiant.CurrentRow.Cells[0].Value.ToString();

            foreach (Etudiant etudiant in Liste.listEtudiant)
            {
                if (etudiant.Id == Int32.Parse(matricule))
                {
                    Liste.listEtudiant.Remove(etudiant);
                    break;
                }

            }
            dtgEtudiant.DataSource = null; // effacer les donnes avant dafficher
            dtgEtudiant.DataSource = Liste.listEtudiant;
            MessageBox.Show("L'Étudiant a été retirer avec succés !");

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgEtudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnacceuil_Click(object sender, EventArgs e)
        {
            var C = new Form1();
            C.Show();
            this.Hide();
        }
    }
}
