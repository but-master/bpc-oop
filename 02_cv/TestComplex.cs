/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_cv
{
    internal class TestComplex
    {
    }
}
*/

class TestComplex
{
    const double epsilon = 1E-6;

    public static void Test(Complex skutecna, Complex ocekavana, string nazev)
    {
 
        if ((Math.Abs(skutecna.Realna - ocekavana.Realna) < epsilon) && (Math.Abs(skutecna.Imaginarni - ocekavana.Imaginarni) < epsilon))
        {
            Console.WriteLine($"{nazev}: OK");
        } else {
            Console.WriteLine($"{nazev}: Chyba: Očekávaná hodnota: {ocekavana}, Skutečná hodnota: {skutecna}");
        }

    }

    public static void Testb(bool skutecna, bool ocekavana, string nazev)
    {

        if (skutecna == ocekavana)
        {
            Console.WriteLine($"{nazev}: OK");
        }
        else
        {
            Console.WriteLine($"{nazev}: Chyba: Očekávaná hodnota: {ocekavana}, Skutečná hodnota: {skutecna}");
        }

    }

    public static void TestD(double skutecna, double ocekavana, string nazev)
    {

        if (Math.Abs(skutecna - ocekavana) < epsilon)
        {
            Console.WriteLine($"{nazev}: OK");
        }
        else
        {
            Console.WriteLine($"{nazev}: Chyba: Očekávaná hodnota: {ocekavana}, Skutečná hodnota: {skutecna}");
        }

    }

}