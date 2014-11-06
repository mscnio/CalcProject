
namespace ProjektRechner.Interfaces
{
    public interface IErgebnisBerechner
    {
        decimal GetErgebnis(string operation, decimal a, decimal b);
    }
}
