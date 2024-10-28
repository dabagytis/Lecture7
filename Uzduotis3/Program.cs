using System;
using Uzduotis3;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Studentas[] studentai = new Studentas[4];

            for (int i = 0; i < studentai.Length; i++)
            {
                Console.WriteLine("Iveskite studento varda:");
                string vardas = Console.ReadLine();
                Console.WriteLine("Iveskite studento pazymiu kieki:");
                int pazymiuKiekis = int.Parse(Console.ReadLine());
                Console.WriteLine("Iveskite studento pazymius:");
                int[] pazymiai = new int[pazymiuKiekis];

                for(int j = 0; j < pazymiai.Length; j++)
                {
                    pazymiai[j] = int.Parse(Console.ReadLine());
                }
                studentai[i] = new Studentas(vardas, pazymiai);
                
            }
            Console.WriteLine();
            Console.WriteLine("Islaikiusiu studentu sarasas:");

            foreach (Studentas a in studentai)
            {
                if (a.Islaike() == true)
                {
                    Console.WriteLine($"{a.Vardas}");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}