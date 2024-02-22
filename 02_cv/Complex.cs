/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_cv
{
    internal class Complex
    {
    }
}
¨*/

class Complex
{
    public double Realna;
    public double Imaginarni;

    public Complex(double realna = 0.0, double imaginarni = 0.0)
    {
        Realna = realna;
        Imaginarni = imaginarni;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Realna + b.Realna, a.Imaginarni + b.Imaginarni);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Realna - b.Realna, a.Imaginarni - b.Imaginarni);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Realna * b.Realna -a.Imaginarni * b.Imaginarni, a.Realna * b.Imaginarni + a.Imaginarni * b.Realna);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        return new Complex((a.Realna * b.Realna + a.Imaginarni * b.Imaginarni)/(Math.Pow(b.Realna, 2) + Math.Pow(b.Imaginarni, 2)), (a.Imaginarni * b.Realna - a.Realna * b.Imaginarni)/(Math.Pow(b.Realna, 2) + Math.Pow(b.Imaginarni, 2)));
    }

    public static bool operator ==(Complex a, Complex b)
    {
        //return (a.Realna == b.Realna && a.Imaginarni == b.Imaginarni) ? true : false;
        return (a.Realna == b.Realna && a.Imaginarni == b.Imaginarni);
    }

    public static bool operator !=(Complex a, Complex b)
    {
        //return !(a.Realna == b.Realna & a.Imaginarni == b.Imaginarni) ? true : false;
        return !(a.Realna == b.Realna && a.Imaginarni == b.Imaginarni);
    }

    public static Complex operator -(Complex a)
    {
        return new Complex(-a.Realna, -a.Imaginarni);
    }

    /// methods

    public override string ToString() 
    { if (Imaginarni < 0) 
        { 
            return string.Format("{0}-{1}j", Realna, -Imaginarni);
        } else { 
            return string.Format("{0}+{1}j", Realna, Imaginarni);
        } 
    }

    public Complex Complex_conjugate()
    {
        return new Complex(Realna, -Imaginarni);
    }

    public double Modul() => Math.Sqrt(Math.Pow(Realna, 2) + Math.Pow(Imaginarni, 2));

    public double Argument()
    {
        return Math.Atan(Imaginarni/Realna);
    }
}