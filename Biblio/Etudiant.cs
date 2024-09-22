namespace Biblio
{
    internal class Etudiant : EtudiantBase
    {
        private int ID;
        private string nom;
        private string prenom;
        private string sexe;
        private string Adresse;

        public int Id { get => ID; set => ID = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public string adresse { get => Adresse; set => Adresse = value; }

        bool validation = false;
        public bool ajouterEtudiant(Etudiant e)
        {
            foreach (Etudiant etudiant in Liste.listEtudiant)
            {
                if (etudiant.ID == e.ID)
                {
                    validation = true;
                }
                else
                {
                    validation = false;
                }

            }
            return validation;
        }

    }
}
