using System;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] masyvas = new int[10];
            int dideliSkaiciai = 0;
            int neigiamiSkaiciai = 0;

            Console.WriteLine("Iveskite 10 skaiciu:");
            for(int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = int.Parse(Console.ReadLine());
                if (masyvas[i] > 20)
                {
                    dideliSkaiciai++;
                }
                if (masyvas[i] < 0)
                {
                    neigiamiSkaiciai++;
                }
            }

            int[] didelisMasyvas = new int[dideliSkaiciai];
            int j = 0;

            for(int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > 20)
                {
                    didelisMasyvas[j] = masyvas[i];
                    j++;
                }
            }

            Console.WriteLine("Skaiciai, didesni uz 20:");
            for (int i = 0; i < didelisMasyvas.Length; i++)
            {
                Console.WriteLine(didelisMasyvas[i]);
            }
            Console.WriteLine();

            Console.WriteLine($"Masyve yra {neigiamiSkaiciai} neigiamu skaiciu");
        }
    }
}