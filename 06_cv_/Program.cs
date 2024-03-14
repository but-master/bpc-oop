// hlavni abstraktni trida
abstract public class GrObject
{
    public abstract void Kresli();
}


// abstraktni podtridy
abstract public class Objekt2D : GrObject
{
    public abstract double SpoctiPlochu();
}

abstract public class Objekt3D : GrObject
{
    public abstract double SpoctiPovrch();
    public abstract double SpoctiObjem();
}


// 2D objekty
public class Kruh : Objekt2D
{
    double Polomer;

    //konstruktor
    public Kruh(double polomer)
    {
        Polomer = polomer;
    }

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Kruh: r = {Polomer}");
    }

    //funkcionalita
    public override double SpoctiPlochu()
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

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Obdelnik: a = {A}; b = {B}");
    }

    //funkcionalita
    public override double SpoctiPlochu()
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

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Elipsa: a = {A}; b = {B}");
    }

    //funkcionalita
    public override double SpoctiPlochu()
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

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Trojuhelnik: a = {A}; b = {B}; c = {C}");
    }

    //funkcionalita
    public override double SpoctiPlochu()
    {
        double S = (A + B + C) / 2;
        return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
    }
}



// 3D objekty
public class Kvadr : Objekt3D
{
    double A;
    double B;
    double C;

    //konstruktor
    public Kvadr(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Kvadr: a = {A}; b = {B}; c = {C}");
    }

    //funkcionalita
    public override double SpoctiPovrch()
    {
        return 2 * (A * B) + 2 * (A * C) + 2 * (C * B);
    }

    public override double SpoctiObjem()
    {
        return A * B * C;
    }
}

public class Valec : Objekt3D
{
    double Vyska;
    double Polomer;

    //konstruktor
    public Valec(double vyska, double polomer)
    {
        Vyska = vyska;
        Polomer = polomer;
    }

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Valec: r = {Polomer}; v = {Vyska}");
    }

    //funkcionalita
    public override double SpoctiPovrch()
    {
        return 2 * (Math.PI * Math.Pow(Polomer, 2)) + Vyska * 2 * Math.PI * Polomer;
    }

    public override double SpoctiObjem()
    {
        return (Math.PI * Math.Pow(Polomer, 2)) * Vyska;
    }
}

public class Koule : Objekt3D
{
    double Polomer;

    //konstruktor
    public Koule(double polomer)
    {
        Polomer = polomer;
    }

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Koule: r = {Polomer}");
    }

    //funkcionalita
    public override double SpoctiPovrch()
    {
        return 4 * Math.PI * Math.Pow(Polomer, 2);
    }

    public override double SpoctiObjem()
    {
        return 4 * Math.PI * Math.Pow(Polomer, 3) / 3;
    }
}

public class Jehlan : Objekt3D
{
    double Vyska;
    double A;
    double B;

    //konstruktor
    public Jehlan(double vyska, double a, double b)
    {
        Vyska = vyska;
        A = a;
        B = b;
    }

    //kresli
    public override void Kresli()
    {
        Console.WriteLine($"Jehlan: v = {Vyska}; a = {A}; b = {B}");
    }

    //funkcionalita
    public override double SpoctiPovrch()
    {
        double povrch = A * B + A * Math.Sqrt(Math.Pow(B / 2, 2) + Math.Pow(Vyska, 2)) + B * Math.Sqrt(Math.Pow(A / 2, 2) + Math.Pow(Vyska, 2));
        return povrch;
    }

    public override double SpoctiObjem()
    {
        return A * B * Vyska/3;
    }
}


