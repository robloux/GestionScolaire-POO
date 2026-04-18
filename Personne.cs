namespace GestionScolaire
{
    public class Personne
    {
        private string _nom;

        public Personne(string nom)
        {
            _nom = nom;
        }

        public virtual void SePresenter()
        {
            throw new System.NotImplementedException();
        }
    }
}