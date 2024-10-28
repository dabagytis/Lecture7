using System;

namespace Lecture7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] masyvas = new double[7];
            double maxTemp = double.MinValue;

            Console.WriteLine("Iveskite dienos temperaturas visai savaitei (C):");
            Console.WriteLine("Pirmadienis:");
            masyvas[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Antradienis:");
            masyvas[1] = double.Parse(Console.ReadLine());
            Console.WriteLine("Treciadienis:");
            masyvas[2] = double.Parse(Console.ReadLine());
            Console.WriteLine("Ketvirtadienis:");
            masyvas[3] = double.Parse(Console.ReadLine());
            Console.WriteLine("Penktadienis:");
            masyvas[4] = double.Parse(Console.ReadLine());
            Console.WriteLine("Sestadienis:");
            masyvas[5] = double.Parse(Console.ReadLine());
            Console.WriteLine("Sekmadienis:");
            masyvas[6] = double.Parse(Console.ReadLine());

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > maxTemp)
                {
                    maxTemp = masyvas[i];
                }
            }
            Console.WriteLine($"Auksciausia savaites temperatura yra {maxTemp}C");

            if (masyvas.Average() < 10)
            {
                Console.WriteLine($"Savaites temperaturos vidurkis yra mazesnis nei 10C");
            }
        }
    }
}