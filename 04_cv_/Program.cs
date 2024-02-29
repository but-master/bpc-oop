using System;

class Program
{
    static void Main()
    {
        string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
            + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
            + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
            + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
            + "posledni veta!";

        StringStatistics statistics = new StringStatistics(testovaciText);

        Console.WriteLine($"Počet slov: {statistics.number_of_words()}");
        Console.WriteLine($"Počet řádků: {statistics.number_of_lines()}");
        Console.WriteLine($"Počet vět: {statistics.number_of_sentences()}");

        Console.WriteLine($"Nejdelší slova:");
        foreach (var word in statistics.longest_words())
        {
            Console.WriteLine($"\t{word}");
        }

        //Console.WriteLine($"{statistics.longest_words()}");

        Console.WriteLine($"Nejkratší slova:");
        foreach (var word in statistics.shortest_words())
        {
            Console.WriteLine($"\t{word}");
        }

        /*
        Console.WriteLine($"Nejčetnější slova:");
        foreach (var word in statistics.most_numerous_words())
        {
            Console.WriteLine($"\t{word}");
        }
        */

        Console.WriteLine($"Nejčetnější slova:");
        Console.WriteLine($"\t{statistics.most_numerous_words()}");


        Console.WriteLine($"Slova podle abecedy:");
        foreach (var word in statistics.ABC_sorted_words())
        {
            Console.WriteLine($"\t{word}");
        }

        Console.WriteLine(String.Join(", ", statistics.ABC_sorted_words()));
    }
}

