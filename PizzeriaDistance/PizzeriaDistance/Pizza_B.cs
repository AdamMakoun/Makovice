using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDistance
{
    internal class Pizza_B : Pizza
    {
        public Pizza_B(string nazev) : base(nazev)
        {

        }
        public override void VyrobPizzu()
        {
            base.VyrobPizzu();
            if (Skladiste.dostupneSuroviny["Syr"] >= 5 &&
                Skladiste.dostupneSuroviny["Sunka"] >= 3)
            {
                surovinyVPizze.Add("Syr", 5);
                surovinyVPizze.Add("Sunka", 3);
                Skladiste.dostupneSuroviny["Syr"] -= 5;
                Skladiste.dostupneSuroviny["Sunka"] -= 3;
            }
            else
            {
                Console.WriteLine("Nemáš dostatek surovin pro výrobu pizzu B");
            }
            


        }
    }
}
