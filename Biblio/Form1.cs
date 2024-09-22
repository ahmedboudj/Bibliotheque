namespace Biblio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var A = new formulaire();
            A.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var C = new Ce_connecter();
            C.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterUnLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var L = new livre();
            L.Show();
            this.Hide();
        }

        private void emprunterUnLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var L = new livre();
            L.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var L = new livre();
            L.Show();
            this.Hide();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }



        private void saisirVotreUsernameEtMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var C = new Ce_connecter();
            C.Show();
            this.Hide();
        }

        private void formulaireDinscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var C = new formulaire();
            C.Show();
            this.Hide();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}