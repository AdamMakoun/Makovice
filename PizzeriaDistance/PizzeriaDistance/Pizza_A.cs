using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDistance
{
    internal class Pizza_A : Pizza
    {
        public Pizza_A(string nazev) : base(nazev)
        {
            
        }
        public override void VyrobPizzu()
        {
            base.VyrobPizzu();
            if (Skladiste.dostupneSuroviny["Syr"] >= 5)
            {
                surovinyVPizze.Add("Syr", 5);
                Skladiste.dostupneSuroviny["Syr"] -= 5;
            }
            else
            {
                Console.WriteLine("Nemáš dostatek sýra");
            }
            
        }
    }
}
