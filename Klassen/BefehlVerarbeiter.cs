using ProjektRechner.Interfaces;
using System;

namespace ProjektRechner.Klassen
{
    class BefehlVerarbeiter : IBefehlVerarbeiter
    {
        public string GetAntwortAufBefehl(string befehl)
        {
                string[] dummy = befehl.Split(' ');

                string op = dummy[1];
                decimal a = Convert.ToInt32(dummy[0]);
                decimal b = Convert.ToInt32(dummy[2]);

                return (new ErgebnisBerechner().GetErgebnis(op, a, b)).ToString();
        }
    }
}
