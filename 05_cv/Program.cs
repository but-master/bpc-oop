using System;
using System.Collections.Generic;

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
    public double PrepravovanyNaklad { get; protected set; }
    public int PrepravovaneOsoby { get; protected set; }

    // Konstruktor
    public Auto(double velikostNadrze, TypPaliva palivo, int maxOsob, double maxNaklad)
    {
        VelikostNadrze = velikostNadrze;
        StavNadrze = 0;
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

// Třída Autoradio
class Autoradio
{
    // Vlastnosti
    private Dictionary<int, double> predvolby = new Dictionary<int, double>();
    public double NaladenyKmitocet { get; private set; }
    public bool RadioZapnuto { get; private set; }

    // Metoda pro nastavení předvolby
    public void NastavPredvolbu(int cislo, double kmitocet)
    {
        predvolby[cislo] = kmitocet;
    }

    // Metoda pro přeladění na předvolbu
    public void PreladNaPredvolbu(int cislo)
    {
        if (predvolby.ContainsKey(cislo))
        {
            NaladenyKmitocet = predvolby[cislo];
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Vytvoření instance tříd
            Osobni osobniAuto = new Osobni(60, Auto.TypPaliva.Benzin, 5);
            Nakladni nakladniAuto = new Nakladni(200, Auto.TypPaliva.Nafta, 5000);
            Autoradio autoradio = new Autoradio();

            // Nastavení vlastností a volání metod
            osobniAuto.Natankuj(Auto.TypPaliva.Benzin, 40);
            osobniAuto.PrepravovaneOsoby = 4;

            nakladniAuto.Natankuj(Auto.TypPaliva.Nafta, 150);
            nakladniAuto.PrepravovanyNaklad = 3000;

            autoradio.NastavPredvolbu(1, 95.5);
            autoradio.PreladNaPredvolbu(1);

            // Výpis informací o stavech
            Console.WriteLine(osobniAuto.ToString());
            Console.WriteLine(nakladniAuto.ToString());
            Console.WriteLine($"Naladený kmitočet v autorádiu: {autoradio.NaladenyKmitocet}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba: {ex.Message}");
        }
    }
}
