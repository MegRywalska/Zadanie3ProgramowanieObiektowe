namespace Zadanie3ProgramowanieObiektowe;

public class Wektor
{
    private double[] _wspolrzedne;

    // Konstruktory
    public Wektor(byte wymiar)
    {
        _wspolrzedne = new double[wymiar];
    }

    public Wektor(params double[] wspolrzedne)
    {
        this._wspolrzedne = wspolrzedne;
    }

    // Właściwości
    public byte Wymiar
    {
        get
        {
            return (byte)_wspolrzedne.Length;
        }
    }

    public double Dlugosc
    {
        get
        {
            return Math.Sqrt(IloczynSkalarny(this, this).GetValueOrDefault());
        }
    }

    // Indeksator
    public double this[byte i]
    {
        get { return _wspolrzedne[i]; }
        set { _wspolrzedne[i] = value; }
    }

    // Statyczne metody
    public static double? IloczynSkalarny(Wektor v, Wektor w)
    {
        if (v.Wymiar != w.Wymiar)
        {
            throw new ArgumentException("Wymiary są różne !!");
        }

        double wynik = 0;
        for (int i = 0; i < v._wspolrzedne.Length; i++)
        {
            wynik += v._wspolrzedne[i] * w._wspolrzedne[i];
        }

        return wynik;
    }

    public static Wektor Suma(params Wektor[] wektory)
    {
        byte wymiar = wektory[0].Wymiar;
        foreach (var wektor in wektory)
        {
            if (wektor.Wymiar != wymiar)
            {
                throw new ArgumentException("Wszystkie wektory muszą mieć ten sam wymiar.");
            }
        }

        Wektor wynik = new Wektor(wymiar);
        for (int i = 0; i < wymiar; i++)
        {
            foreach (var wektor in wektory)
            {
                wynik._wspolrzedne[i] += wektor._wspolrzedne[i];
            }
        }

        return wynik;
    }

    // Operatory
    public static Wektor operator +(Wektor v, Wektor w)
    {
        return Suma(v, w);
    }

    public static Wektor operator -(Wektor v, Wektor w)
    {
        if (v.Wymiar != w.Wymiar)
        {
            throw new ArgumentException("Wymiary są różne !!");
        }

        Wektor roznica = new Wektor(v.Wymiar);
        for (int i = 0; i < v.Wymiar; i++)
        {
            roznica._wspolrzedne[i] = v._wspolrzedne[i] - w._wspolrzedne[i];
        }

        return roznica;
    }

    public static Wektor operator *(Wektor v, double skalar)
    {
        Wektor wynik = new Wektor(v.Wymiar);
        for (int i = 0; i < v.Wymiar; i++)
        {
            wynik._wspolrzedne[i] = v._wspolrzedne[i] * skalar;
        }
        return wynik;
    }

    public static Wektor operator *(double skalar, Wektor v)
    {
        return v * skalar;
    }

    public static Wektor operator /(Wektor v, double skalar)
    {
        if (skalar == 0)
        {
            throw new DivideByZeroException("Nie dzieli się przez zero.");
        }

        Wektor wynik = new Wektor(v.Wymiar);
        for (int i = 0; i < v.Wymiar; i++)
        {
            wynik._wspolrzedne[i] = v._wspolrzedne[i] / skalar;
        }

        return wynik;
    }
}
