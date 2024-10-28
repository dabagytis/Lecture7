using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis2
{
    public class Preke
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public int Kiekis { get; set; }

        public Preke()
        {

        }

        public Preke(string pavadinimas, double kaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Kiekis = kiekis;
        }

        public double BendraKaina()
        {
            return Kaina * Kiekis;
        }
    }
}
