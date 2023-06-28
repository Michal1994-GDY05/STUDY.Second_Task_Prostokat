using System;
using System.Collections.Generic;

public class Prostokąt
{
    private double bokA;
    private double bokB;

    public static Dictionary<char, decimal> wysokośćArkusza0 = new Dictionary<char, decimal>
    {
        ['A'] = 1189,
        ['B'] = 1414,
        ['C'] = 1297
    };

    public Prostokąt(double bokA, double bokB)
    {
        this.BokA = bokA;
        this.BokB = bokB;
    }

    public double BokA
    {
        get { return bokA; }
        set
        {
            if (IsValidLength(value))
                bokA = value;
            else
                throw new ArgumentException("Długość boku A musi być skończoną nieujemną liczbą.");
        }
    }

    public double BokB
    {
        get { return bokB; }
        set
        {
            if (IsValidLength(value))
                bokB = value;
            else
                throw new ArgumentException("Długość boku B musi być skończoną nieujemną liczbą.");
        }
    }

    private bool IsValidLength(double length)
    {
        return !double.IsNaN(length) && !double.IsInfinity(length) && length >= 0;
    }

    public static Prostokąt ArkuszPapieru(string format)
    {
        if (format.Length != 2)
            throw new ArgumentException("Nieprawidłowy format arkusza papieru.");

        char szereg = format[0];
        byte indeks;
        if (!byte.TryParse(format[1].ToString(), out indeks))
            throw new ArgumentException("Nieprawidłowy format arkusza papieru.");

        if (!wysokośćArkusza0.ContainsKey(szereg))
            throw new ArgumentException("Nieprawidłowy format arkusza papieru.");

        decimal wysokośćBazowa = wysokośćArkusza0[szereg];
        double pierwiastekZDwóch = Math.Sqrt(2);

        double bokA = Math.Round((double)(wysokośćBazowa / (decimal)Math.Pow(pierwiastekZDwóch, indeks)));
        double bokB = Math.Round(bokA / pierwiastekZDwóch);

        return new Prostokąt(bokA, bokB);
    }

}
