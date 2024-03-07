using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _05_cv_.Auto;

namespace _05_cv_
{
    // Třída Autoradio
    internal class Autoradio
    {
        // Vlastnosti
        private Dictionary<int, double> predvolby = new Dictionary<int, double>();
        public double NaladenyKmitocet { get; private set; }
        public bool RadioZapnuto { get; set; }

        // Konstruktor
        public Autoradio(bool stav) 
        {
            RadioZapnuto = stav;
        }

        /*
        public bool StavRadia
        {
            get { return RadioZapnuto; }
            set { RadioZapnuto = value;}
        }
        */

        // Metoda pro nastavení předvolby
        public void NastavPredvolbu(int cislo, double kmitocet)
        {
            predvolby[cislo] = kmitocet;
        }

        // Metoda pro přeladění na předvolbu
        public void PreladNaPredvolbu(int cislo)
        {
            if (RadioZapnuto != true)
            {
                throw new ArgumentException("Nejdříve zapni rádio.");
            }

            if (predvolby.ContainsKey(cislo))
            {
                NaladenyKmitocet = predvolby[cislo];
            }
        }

        public override string ToString()
        {
            if (RadioZapnuto == true)
            {
                return $"Autoradio - Zapnuto na kanálu {NaladenyKmitocet}";
            } else { 
                return $"Autoradio - Vypnuto";
            }
            
        }
    }
}
