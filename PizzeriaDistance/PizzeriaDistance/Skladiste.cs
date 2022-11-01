using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDistance
{
    internal class Skladiste
    {
        public static IDictionary<string, int> dostupneSuroviny = new Dictionary<string, int>();

        public static void DostupneSuroviny()
        {
            dostupneSuroviny.Add("Testo", 100);
            dostupneSuroviny.Add("Sunka", 100);
            dostupneSuroviny.Add("Syr", 100);
            dostupneSuroviny.Add("Omacka", 100);

        }
    }
}
