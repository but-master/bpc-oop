using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_cv_
{
    // Odvozená třída Osobni
    class Osobni : Auto
    {
        // Konstruktor
        public Osobni(double velikostNadrze, TypPaliva palivo, int maxOsob)
            : base(velikostNadrze, palivo, maxOsob, 0) { }

        // Přetížení metody ToString pro Osobni
        public override string ToString()
        {
            return $"Osobní - {base.ToString()}";
        }
    }
}
