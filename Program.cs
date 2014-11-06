using ProjektRechner.Klassen;
using System;

namespace ProjektRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine Rechenoperation ein: ");
            string mRechenAufgabe = Console.ReadLine();
            Console.WriteLine("Das Ergebnis lautet: {0}",
                new BefehlVerarbeiter().GetAntwortAufBefehl(mRechenAufgabe));
            Console.ReadLine();
        }
    }
}
