using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class RocniTeplota
{
    public int Rok { get; set; }
    public List<double> MesicniTeploty { get; set; }

    public RocniTeplota(int rok, List<double> mesicniTeploty)
    {
        Rok = rok;
        MesicniTeploty = mesicniTeploty;
    }

    public double MaxTeplota => MesicniTeploty.Max();
    public double MinTeplota => MesicniTeploty.Min();
    public double PrumRocniTeplota => Math.Round(MesicniTeploty.Average(), 1);
}

public class ArchivTeplot
{
    private SortedDictionary<int, RocniTeplota> _archiv = new SortedDictionary<int, RocniTeplota>();

    public void Load(string path)
    {
        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            string[] parts = line.Split(':', ';');
            int rok = int.Parse(parts[0]);
            List<double> mesicniTeploty = new List<double>();

            for (int i = 1; i < parts.Length; i++)
            {
                mesicniTeploty.Add(double.Parse(parts[i]));
            }
            _archiv.Add(rok, new RocniTeplota(rok, mesicniTeploty));
        }
    }

    public void Save(string path)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (var kvp in _archiv)
            {
                writer.Write($"{kvp.Key}:");
                foreach (double teplota in kvp.Value.MesicniTeploty)
                {
                    writer.Write($" {teplota.ToString("F1")};");
                }
                writer.WriteLine();
            }
        }
    }

    public void Kalibrace(double konstanta)
    {
        foreach (var rocniTeplota in _archiv.Values)
        {
            for (int i = 0; i < rocniTeplota.MesicniTeploty.Count; i++)
            {
                rocniTeplota.MesicniTeploty[i] = Math.Round(rocniTeplota.MesicniTeploty[i] + konstanta, 1);
            }
        }
    }

    public RocniTeplota Vyhledej(int rok)
    {
        if (_archiv.ContainsKey(rok))
            return _archiv[rok];
        else
            return null;
    }

    public void TiskTeplot()
    {
        foreach (var rocniTeplota in _archiv.Values)
        {
            Console.Write($"{rocniTeplota.Rok}: ");
            for (int mesic = 1; mesic <= 12; mesic++)
            {
                Console.Write($"{rocniTeplota.MesicniTeploty[mesic - 1].ToString("F1")}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void TiskPrumernychRocnichTeplot()
    {
        foreach (var rocniTeplota in _archiv.Values)
        {
            Console.WriteLine($"{rocniTeplota.Rok}: {rocniTeplota.PrumRocniTeplota}");
        }
    }

    public void TiskPrumernychMesicnichTeplot()
    {
        Console.Write("Prum.: ");
        for (int mesic = 1; mesic <= 12; mesic++)
        {
            double prumernaTeplota = _archiv.Values.Average(rt => rt.MesicniTeploty[mesic - 1]);
            Console.Write($"{prumernaTeplota.ToString("F1")} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ArchivTeplot archiv = new ArchivTeplot();
        archiv.Load("teploty.txt");

        Console.WriteLine("Teploty před kalibrací:");
        archiv.TiskTeplot();

        archiv.TiskPrumernychMesicnichTeplot();

        Console.WriteLine("\nPrůměrné roční teploty:");
        archiv.TiskPrumernychRocnichTeplot();

        double kalibracniKonstanta = -0.1;
        archiv.Kalibrace(kalibracniKonstanta);
        Console.WriteLine($"\nTeploty po kalibraci o {kalibracniKonstanta} stupně:");
        archiv.TiskTeplot();

        archiv.Save("teploty_po_kalibraci.txt");

    }
}
