namespace GestionScolaire
{
    public class Note
    {
        private double _valeur;
        private string _type;
        private string _date;

        public Note(double valeur, string type, string date)
        {
            _valeur = valeur;
            _type = type;
            _date = date;
        }
    }
}