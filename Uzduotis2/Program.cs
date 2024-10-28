using System;
using Uzduotis2;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Preke[] prekes = new Preke[5];

            for (int i = 0; i < prekes.Length; i++)
            {
                Console.WriteLine("Iveskite prekes pavadinima:");
                string pavadinimas = Console.ReadLine();
                Console.WriteLine("Iveskite prekes kaina (eur):");
                double kaina = double.Parse(Console.ReadLine());
                Console.WriteLine("Iveskite prekes kieki (vnt):");
                int kiekis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                prekes[i] = new Preke(pavadinimas, kaina, kiekis);
            }

            foreach (Preke a in prekes)
            {
                Console.WriteLine($"{a.Pavadinimas}, Kaina {a.Kaina}eur, kiekis {a.Kiekis}vnt");
            }
            Console.WriteLine();

            double bendraKaina = 0;
            for (int i = 0; i < prekes.Length; i++)
            {
                bendraKaina = bendraKaina + prekes[i].BendraKaina();
            }

            Console.WriteLine($"Krepselio suma {bendraKaina}eur");
            if (bendraKaina > 50)
            {
                Console.WriteLine("Krepselio suma virsija 50eur");
            }
        }
    }
}