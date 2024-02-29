using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class StringStatistics
{
    private string inputText;

    public StringStatistics(string text)
    {
        inputText = text;
    }

    public int GetWordCount()
    {
        string[] words = inputText.Split(new char[] { ' ', '\n', '\r', '\t', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public int GetLineCount()
    {
        return inputText.Split('\n').Length;
    }

    public int GetSentenceCount()
    {
        string[] sentences = Regex.Split(inputText, @"(?<=[.!?])\s+");
        return sentences.Length;
    }

    public string[] GetLongestWords()
    {
        string[] words = inputText.Split(new char[] { ' ', '\n', '\r', '\t', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int maxLength = words.Max(w => w.Length);
        return words.Where(w => w.Length == maxLength).ToArray();
    }

    public string[] GetShortestWords()
    {
        string[] words = inputText.Split(new char[] { ' ', '\n', '\r', '\t', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int minLength = words.Min(w => w.Length);
        return words.Where(w => w.Length == minLength).ToArray();
    }

    public string[] GetMostCommonWords()
    {
        string[] words = inputText.Split(new char[] { ' ', '\n', '\r', '\t', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var wordCounts = words.GroupBy(w => w).OrderByDescending(g => g.Count()).Select(g => g.Key).ToArray();
        return wordCounts;
    }

    public string[] GetAlphabeticallySortedWords()
    {
        string[] words = inputText.Split(new char[] { ' ', '\n', '\r', '\t', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.OrderBy(w => w).ToArray();
    }
}

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

        Console.WriteLine($"Počet slov: {statistics.GetWordCount()}");
        Console.WriteLine($"Počet řádků: {statistics.GetLineCount()}");
        Console.WriteLine($"Počet vět: {statistics.GetSentenceCount()}");

        Console.WriteLine("Nejdelší slova:");
        foreach (var word in statistics.GetLongestWords())
        {
            Console.WriteLine($"- {word}");
        }

        Console.WriteLine("Nejkratší slova:");
        foreach (var word in statistics.GetShortestWords())
        {
            Console.WriteLine($"- {word}");
        }

        Console.WriteLine("Nejčetnější slova:");
        foreach (var word in statistics.GetMostCommonWords())
        {
            Console.WriteLine($"- {word}");
        }

        Console.WriteLine("Setříděná slova dle abecedy:");
        foreach (var word in statistics.GetAlphabeticallySortedWords())
        {
            Console.WriteLine($"- {word}");
        }
    }
}

