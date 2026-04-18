public class Personne
{
    private string _nom;
    private string _prenom;
    private string _email;

    public Personne(string nom, string prenom, string email)
    {
        _nom = nom;
        _prenom = prenom;
        _email = email;
    }

    public virtual void SePresenter()
    {
        throw new System.NotImplementedException();
    }
}