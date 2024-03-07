using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_cv_
{
    // Základní třída Auto
    class Auto
    {
        // Výčtový typ pro typ paliva
        public enum TypPaliva { Benzin, Nafta }

        // Vlastnosti
        public double VelikostNadrze { get; protected set; }
        public double StavNadrze { get; protected set; }
        public TypPaliva Palivo { get; private set; }
        public int MaxOsob { get; protected set; }
        public double MaxNaklad { get; protected set; }
        public double PrepravovanyNaklad;
        public int PrepravovaneOsoby;
        public Autoradio autoradio = new Autoradio(false);

        // Konstruktor
        public Auto(double velikostNadrze, TypPaliva palivo, int maxOsob, double maxNaklad)
        {
            VelikostNadrze = velikostNadrze;
            StavNadrze = 10;
            Palivo = palivo;
            MaxOsob = maxOsob;
            MaxNaklad = maxNaklad;
            PrepravovaneOsoby = 0;
            PrepravovanyNaklad = 0;
        }

        // Metoda pro natankování
        public void Natankuj(TypPaliva typPaliva, double mnozstvi)
        {
            if (typPaliva != Palivo)
            {
                throw new ArgumentException("Nelze natankovat nesprávný typ paliva.");
            }

            if (StavNadrze + mnozstvi > VelikostNadrze)
            {
                throw new InvalidOperationException("Nelze natankovat, nádrž by přetekla.");
            }

            StavNadrze += mnozstvi;
        }

        // Metoda pro získání informací o stavu auta
        public override string ToString()
        {
            return $"Stav nádrže: {StavNadrze}/{VelikostNadrze}, Přepravovaný náklad: {PrepravovanyNaklad}, Přepravované osoby: {PrepravovaneOsoby}";
        }
    }

}
