namespace GestionScolaire
{
    public class Inscription
    {
        private Etudiant _etudiant;
        private Cours _cours;
        private string _statut;

        public Inscription(Etudiant etudiant, Cours cours, string statut)
        {
            _etudiant = etudiant;
            _cours = cours;
            _statut = statut;
        }
    }
}