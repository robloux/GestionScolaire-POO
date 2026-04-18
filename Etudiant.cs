namespace GestionScolaire
{
    public class Etudiant : Personne
    {
        private string _matricule;
        private string _classe;
        private int _age;

        public Etudiant(string nom, string prenom, string email,
                        string matricule, string classe, int age)
            : base(nom, prenom, email)
        {
            _matricule = matricule;
            _classe = classe;
            _age = age;
        }

        public override void SePresenter()
        {
            throw new System.NotImplementedException();
        }
    }
}