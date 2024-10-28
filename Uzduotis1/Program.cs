using System;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] masyvas = new int[6];

            Console.WriteLine($"Iveskite {masyvas.Length} skaicius:");
            int didziausias = int.MinValue;
            int maziausias = int.MaxValue;
            int teigiami = 0;
            int neigiami = 0;
            int nuliai = 0;


            for(int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > didziausias)
                {
                    didziausias = masyvas[i];
                }
                if (masyvas[i] < maziausias)
                {
                    maziausias = masyvas[i];
                }
            }
            Console.WriteLine($"Didziausias skaicius masyve yra {didziausias}");
            Console.WriteLine($"Maziausias skaicius masyve yra {maziausias}");
            Console.WriteLine();

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > 0)
                {
                    teigiami = teigiami + 1;
                }
                else if (masyvas[i] < 0)
                {
                    neigiami = neigiami + 1;
                }
                else
                {
                    nuliai = nuliai + 1;
                }
            }
            Console.WriteLine($"Masyve yra {teigiami} teigiami skaiciai, {neigiami} neigiami skaiciai, ir {nuliai} nuliai");
            Console.WriteLine();

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] % 2 == 0)
                {
                    Console.WriteLine("Masyve yra lyginiu skaiciu.");
                    break;
                }
            }
        }
    }
}