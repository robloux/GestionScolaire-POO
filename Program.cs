using System;

namespace GestionScolaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant e = new Etudiant("Ali");
            Professeur p = new Professeur("Martin");
            Cours c = new Cours();

            Console.WriteLine("OK");
        }
    }
}