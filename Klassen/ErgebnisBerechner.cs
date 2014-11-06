using ProjektRechner.Interfaces;
using StructureMap;

namespace ProjektRechner.Klassen
{
    class ErgebnisBerechner : IErgebnisBerechner
    {
        public decimal GetErgebnis(string operation, decimal a, decimal b)
        {
            switch (operation)
            {
                case "plus":
                    return ObjectFactory.GetInstance<ICalculator>().Addiere(a, b);
                case "minus":
                    return new Calculator().Subtrahiere(a, b);
                case "mal":
                    return new Calculator().Multipliziere(a, b);
                case "geteilt":
                    return new Calculator().Dividiere(a, b);
                default:
                    return -1;
            }
        }
    }
}
