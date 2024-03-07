using System;
using System.Collections.Generic;
using static _05_cv_.Auto;

namespace _05_cv_
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Vytvoření instance tříd
                Osobni osobniAuto = new Osobni(60, Auto.TypPaliva.Benzin, 5);
                Nakladni nakladniAuto = new Nakladni(200, Auto.TypPaliva.Nafta, 5000);
                //Autoradio autoradio = new Autoradio();

                // Nastavení vlastností a volání metod
                osobniAuto.Natankuj(Auto.TypPaliva.Benzin, 40);
                osobniAuto.PrepravovaneOsoby = 4;
                if (osobniAuto.PrepravovaneOsoby > osobniAuto.MaxOsob)
                {
                    throw new ArgumentException("Nelze převážet tolik osob.");
                }


                nakladniAuto.Natankuj(Auto.TypPaliva.Nafta, 150);
                nakladniAuto.PrepravovanyNaklad = 6000;
                if (nakladniAuto.PrepravovanyNaklad > nakladniAuto.MaxNaklad)
                {
                    throw new ArgumentException("Nelze převážet tolik nákladu.");
                }

                osobniAuto.autoradio.RadioZapnuto = true;

                osobniAuto.autoradio.NastavPredvolbu(1, 95.5);
                osobniAuto.autoradio.NastavPredvolbu(2, 100.9);
                osobniAuto.autoradio.NastavPredvolbu(3, 72.0);

                // Výpis informací o stavech
                Console.WriteLine(osobniAuto.ToString());
                Console.WriteLine(nakladniAuto.ToString());

                osobniAuto.autoradio.PreladNaPredvolbu(1);
                Console.WriteLine(osobniAuto.autoradio.ToString());

                osobniAuto.autoradio.PreladNaPredvolbu(3);
                Console.WriteLine(osobniAuto.autoradio.ToString());

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba: {ex.Message}");
            }
        }
    }
}