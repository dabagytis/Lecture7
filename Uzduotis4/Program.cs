using System;
using Uzduotis4;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Produktas[] produktai = new Produktas[4];

            for (int i = 0; i < produktai.Length; i++)
            {
                Console.WriteLine("Iveskite produkto pavadinima:");
                string pavadinimas = Console.ReadLine();
                Console.WriteLine("Iveskite produkto kaina (eur):");
                decimal kaina = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Iveskite produkto kieki (vnt):");
                int kiekis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                produktai[i] = new Produktas(pavadinimas, kaina, kiekis);
            }

            foreach (Produktas a in produktai)
            {
                if (a.YraSandelyje() == true && a.Kaina < 10)
                {
                    Console.WriteLine($"{a.Pavadinimas}, kaina {a.Kaina}eur, kiekis {a.Kiekis}vnt");
                    Console.WriteLine();
                }
            }
        }
    }
}