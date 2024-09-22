namespace Biblio
{
    internal class livre1 : Liste1
    {
        public int Numéro_du_livre;
        public string Titre;
        public string Auteur;
        public string Date_et_heure_Ajout_Emprunt;
        public string Date_et_heure_du_Retour;

        public int Numéro_du_Livre { get => Numéro_du_livre; set => Numéro_du_Livre = value; }
        public string titre { get => Titre; set => Titre = value; }
        public string auteur { get => Auteur; set => Auteur = value; }
        public string date_et_heure_Ajout_Emprunt { get => Date_et_heure_Ajout_Emprunt; set => Date_et_heure_Ajout_Emprunt = value; }
        public string date_et_heure_du_Retour { get => Date_et_heure_du_Retour; set => Date_et_heure_du_Retour = value; }
        bool validation = false;
        public bool ajouterlivre(livre1 L)
        {
            foreach (livre1 livre in Liste1.listLivre)
            {
                if (livre.Numéro_du_Livre == L.Numéro_du_Livre)
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
        public bool emprunterlivre(livre1 M)
        {
            foreach (livre1 livre in Liste1.listLivre)
            {
                if (livre.Numéro_du_Livre == M.Numéro_du_Livre)
                {
                    validation = false;
                }
                else
                {
                    validation = true;
                }
            }
            return validation;
        }
    }
}


