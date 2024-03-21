using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_cv_
{
    internal class main
    {
        static void Main(string[] args)
        {
            int[] rada = {5, 9, 4, 2, 20};
            string[] veta = {"virus", "ahoj", "aahoj"};
            Kruh kruh1 = new Kruh(5);
            Kruh kruh2 = new Kruh(8);
            Obdelnik obdelnik1 = new Obdelnik(3, 4);
            Obdelnik obdelnik2 = new Obdelnik(2, 7);

            Kruh[] kruhy = new Kruh[] { kruh1, kruh2 };
            Obdelnik[] obdelniky = new Obdelnik[] { obdelnik1, obdelnik2 };
            //Objekt2D[] ruzne = new Objekt2D[3];
            Objekt2D[] ruzne = {obdelnik1, kruh2, obdelnik2, kruh1};

            Console.WriteLine("Největší číslo: " + Extremy.Nejvetsi(ref rada).ToString());
            Console.WriteLine("Největší číslo: " + Extremy.Nejmensi(ref rada).ToString());
            Console.WriteLine("abecedně slovo posledni: " + Extremy.Nejvetsi(ref veta).ToString());
            Console.WriteLine("abecedně slovo prvni: " + Extremy.Nejmensi(ref veta).ToString());
            Console.WriteLine("Největší kruh: " + Extremy.Nejvetsi(ref kruhy).Kresli());
            Console.WriteLine("Nejmenší obdélník: " + Extremy.Nejmensi(ref obdelniky).Kresli());
            Console.WriteLine("Největší ruzne: " + Extremy.Nejvetsi(ref ruzne).Kresli());
            Console.WriteLine("Nejmenší ruzne: " + Extremy.Nejmensi(ref ruzne).Kresli());


            int[] cisla = { 1, 3, 5, 7, 9 };
            var filtrovanaCisla = cisla.Where(x => x >= 4 && x <= 8);
            Console.WriteLine("Filtrovaná pole int[]: " + string.Join(", ", filtrovanaCisla));
        }



        // proč to tu háže chyby???
        /*
        int[] cisla = { 1, 3, 5, 7, 9 };
        var filtrovanaCisla = cisla.Where(x => x >= 4 && x <= 8);
        Console.WriteLine("Filtrovaná pole int[]: " + string.Join(", ", filtrovanaCisla));
        */               
    }
}
