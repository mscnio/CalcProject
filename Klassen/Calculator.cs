using ProjektRechner.Interfaces;

namespace ProjektRechner.Klassen
{
    class Calculator : ICalculator
    {
        public decimal Addiere(decimal a, decimal b)
        {
            return a+b;
        }

        public decimal Subtrahiere(decimal a, decimal b)
        {
            return a-b;
        }

        public decimal Multipliziere(decimal a, decimal b)
        {
            return a*b;
        }

        public decimal Dividiere(decimal a, decimal b)
        {
            return a/b;
        }
    }
}
