using System;
using System.Text.RegularExpressions;

class StringStatistics
{
    public string Text;

    //public int number_of_words = 0;
    //public int number_of_lines = 0;
    //public int number_of_sentences = 0;

    public string[] words;

    public StringStatistics(string vstup)
    {
        Text = vstup;
    }

    /*
    public override string ToString()
    {
        return $"Počet slov: {number_of_words} \n Počet řádků: {number_of_lines}";

        
    }
    */




    // 2. varianta řešení
    /*
    public new string[] all_words()
    {
        char[] oddelovace = new char[] { ' ', '.', ',', ';', '!', '?', '\n' };
        string[] poleSlov = Text.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);
        return poleSlov.Length;
    }
    */
    
    public new int number_of_words()
    {
        char[] oddelovace = new char[] { ' ', '.', ',', ';', '!', '?', '\n' };
        string[] poleSlov = Text.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);
        return poleSlov.Length;
    }

    public new int number_of_lines()
    {
        char[] oddelovace = new char[] { '\n' };
        string[] poleRadku = Text.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);
        return poleRadku.Length;
    }
    
    public new int number_of_sentences()
    {
        string[] sentences = Regex.Split(Text, @"(?<=[.!?])\s+[A-Z]");
        return sentences.Length;
    }

    
    public new string[] longest_words()
    {
        string[] words = Text.Split(new char[] { ' ', '.', ',', ';', '!', '?', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int maxLength = words.Max(w => w.Length);
        return words.Where(w => w.Length == maxLength).ToArray();
    }

    public new string[] shortest_words()
    {
        string[] words = Text.Split(new char[] { ' ', '.', ',', ';', '!', '?', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int minLength = words.Min(w => w.Length);
        return words.Where(w => w.Length == minLength).ToArray();
    }
    
    public new string most_numerous_words()
    {
        string[] words = Text.Split(new char[] { ' ', '.', ',', ';', '!', '?', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        var wordCounts = words.GroupBy(w => w).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
        return wordCounts;
    }

    public new string[] ABC_sorted_words()
    {
        string[] words = Text.Split(new char[] { ' ', '.', ',', ';', '!', '?', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        return words;
    }

}
