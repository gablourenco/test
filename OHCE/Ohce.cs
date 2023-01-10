using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly SystemLang _langue;
    private readonly SystemPeriodeJournéeAdapter _périodeJournée;

    public Ohce(SystemLang systemLang, SystemPeriodeJournéeAdapter PériodeActuelle)
    {
        _langue = systemLang;
        _périodeJournée = PériodeActuelle;
    }

    public string Saluer()
    {
        var stringBuilder = 
            new StringBuilder(_langue.direBonjour(_périodeJournée));
    }

    public string Palindrome(string input)
    {
        

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(reversed);

        if (reversed.Equals(input))
            stringBuilder.Append(_langue.bienDit);

        return stringBuilder.ToString();
    }

    public string AuRevoir()
    {
        stringBuilder.Append(_langue.auRevoir);
    }
}