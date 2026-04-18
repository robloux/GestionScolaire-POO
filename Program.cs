using System;

namespace GestionScolaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant e = new Etudiant("Ali", "Test", "mail@test.com", "E01", "Info", 20);

            Console.WriteLine("OK");
        }
    }
}