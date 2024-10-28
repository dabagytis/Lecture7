using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis3
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int[] Pazymiai { get; set; }

        public Studentas()
        {

        }

        public Studentas(string vardas, int[] pazymiai)
        {
            Vardas = vardas;
            Pazymiai = pazymiai;
        }

        public double Vidurkis()
        {
            int suma = Pazymiai.Sum();
            return suma / Pazymiai.Length;
        }
        

        public bool Islaike()
        {
            if (Vidurkis() >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
