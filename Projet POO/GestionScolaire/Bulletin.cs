namespace GestionScolaire
{
    public class Bulletin
    {
        private Etudiant _etudiant;
        private double _moyenne;
        private string _appreciation;

        public Bulletin(Etudiant etudiant, double moyenne, string appreciation)
        {
            _etudiant = etudiant;
            _moyenne = moyenne;
            _appreciation = appreciation;
        }
    }
}