namespace GestionScolaire
{
    public class Professeur : Personne
    {
        private string _specialite;
        private double _salaire;
        private int _anciennete;

        public Professeur(string nom, string prenom, string email,
                          string specialite, double salaire, int anciennete)
            : base(nom, prenom, email)
        {
            _specialite = specialite;
            _salaire = salaire;
            _anciennete = anciennete;
        }

        public override void SePresenter()
        {
            throw new System.NotImplementedException();
        }
    }
}