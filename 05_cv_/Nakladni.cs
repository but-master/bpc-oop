using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_cv_
{
    // Odvozená třída Nakladni
    class Nakladni : Auto
    {
        // Konstruktor
        public Nakladni(double velikostNadrze, TypPaliva palivo, double maxNaklad)
            : base(velikostNadrze, palivo, 1, maxNaklad) { }

        // Přetížení metody ToString pro Nakladni
        public override string ToString()
        {
            return $"Nákladní - {base.ToString()}";
        }
    }
}
