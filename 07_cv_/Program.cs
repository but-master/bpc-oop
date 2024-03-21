using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface I2D
{
    double Plocha();
}

public abstract class Objekt2D : I2D, IComparable//<Objekt2D>
{
    public abstract double Plocha();
    public abstract string Kresli();
    /*
    public int CompareTo(Objekt2D other)
    {
        return Plocha().CompareTo(other.Plocha());
        //return (int)(Plocha() - other.Plocha());
    }
    */
    
    public int CompareTo(Object obj)
    {
        Objekt2D other = obj as Objekt2D;

        return Plocha().CompareTo(other.Plocha());
        //return (int)(Plocha() - other.Plocha());
    }
    
}

/*
1
3
4
8
*/

// 2D objekty
public class Kruh : Objekt2D
{
    double Polomer;

    //konstruktor
    public Kruh(double polomer)
    {
        Polomer = polomer;
    }

    //kresli = ToString
    public override string Kresli()
    {
        return $"Kruh: r = {Polomer}";
    }

    //funkcionalita
    public override double Plocha()
    {
        return Math.PI * Math.Pow(Polomer, 2);
    }
}

public class Obdelnik : Objekt2D
{
    double A;
    double B;

    //konstruktor
    public Obdelnik(double a, double b)
    {
        A = a;
        B = b;
    }

    //kresli = ToString
    public override string Kresli()
    {
        return $"Obdelnik: a = {A}; b = {B}";
    }

    //funkcionalita
    public override double Plocha()
    {
        return A * B;
    }
}

public class Elipsa : Objekt2D
{
    double A;
    double B;

    //konstruktor
    public Elipsa(double a, double b)
    {
        A = a;
        B = b;
    }

    //kresli = ToString
    public override string Kresli()
    {
        return $"Elipsa: a = {A}; b = {B}";
    }

    //funkcionalita
    public override double Plocha()
    {
        return Math.PI * A * B;
    }
}

public class Trojuhelnik : Objekt2D
{
    double A;
    double B;
    double C;

    //konstruktor
    public Trojuhelnik(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    //kresli = ToString
    public override string Kresli()
    {
        return $"Trojuhelnik: a = {A}; b = {B}; c = {C}";
    }

    //funkcionalita
    public override double Plocha()
    {
        double S = (A + B + C) / 2;
        return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
    }
}

public class Ctverec : Objekt2D
{
    double A;

    //konstruktor
    public Ctverec(double a)
    {
        A = a;
    }

    //kresli = ToString
    public override string Kresli()
    {
        return $"Ctverec: a = {A}";
    }

    //funkcionalita
    public override double Plocha()
    {
        return A * A;
    }
}





//extrém!
public class Extremy
{
    public static T Nejvetsi<T>(ref T[] pole) where T : IComparable
    {
        T max = pole[0];

        foreach (T item in pole)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }

        return max;
    }

    public static T Nejmensi<T>(ref T[] pole) where T : IComparable
    {
        T min = pole[0];

        foreach (T item in pole)
        {
            if (item.CompareTo(min) < 0)
                min = item;
        }

        return min;
    }
}