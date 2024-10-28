using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis4
{
    public class Produktas
    {
        public string Pavadinimas { get; set; }
        public decimal Kaina { get; set; }
        public int Kiekis { get; set; }

        public Produktas()
        {

        }

        public Produktas(string pavadinimas, decimal kaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Kiekis = kiekis;
        }

        public bool YraSandelyje()
        {
            if (Kiekis > 0)
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
