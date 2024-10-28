using System;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] masyvas = new int[6];
            int zeroCount = 0;
            int numberCount = masyvas.Length - zeroCount;

            Console.WriteLine($"Iveskie {masyvas.Length} skaicius");
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = int.Parse(Console.ReadLine());
                if (masyvas[i] != 0)
                {
                    zeroCount++;
                }
            }

            int[] naujasMasyvas = new int[masyvas.Length];
            int j = 0;

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] != 0)
                {
                    naujasMasyvas[j] = masyvas[i];
                    j++;
                }
            }

            for(int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine(naujasMasyvas[i]);
            }
        }
    }
}