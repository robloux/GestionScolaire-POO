namespace GestionScolaire
{
    public class Cours
    {
        private string _titre;
        private string _code;
        private int _heures;

        public Cours(string titre, string code, int heures)
        {
            _titre = titre;
            _code = code;
            _heures = heures;
        }

        public void Afficher()
        {
            throw new System.NotImplementedException();
        }
    }
}