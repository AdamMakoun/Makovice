using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDistance
{
    internal class Pizza 
    {
        //Jaké suroviny budou potřeba pro pizzu?
        public IDictionary<string, int> surovinyVPizze = new Dictionary<string, int>();

        public string nazev { get; }
        public Pizza(string nazev)
        {
            this.nazev = nazev;
            VyrobPizzu();
        }
   
        public virtual void VyrobPizzu()
        {
            if (Skladiste.dostupneSuroviny["Testo"] > 0 &&
                Skladiste.dostupneSuroviny["Omacka"] >= 10)
            {
                surovinyVPizze.Add("Testo", 1);
                surovinyVPizze.Add("Omacka", 10);
                Skladiste.dostupneSuroviny["Testo"] -= 1;
                Skladiste.dostupneSuroviny["Omacka"] -= 10;
            }
            else
            {
                Console.WriteLine("nemáš dostatek surovin");
            }

        }
    }
}
