using System;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] masyvas = new int[5];
            int suma = 0;

            Console.WriteLine($"Iveskie {masyvas.Length} skaicius");
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] >= 0)
                {
                    suma = suma + masyvas[i];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(suma);
        }
    }
}