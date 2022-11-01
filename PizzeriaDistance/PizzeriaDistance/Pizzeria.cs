using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDistance
{
    internal class Pizzeria
    {
        Random rnd = new Random();
        List<Pizza> pizzyVPeci = new List<Pizza>();


        int pocetMistVPeci = 5;

        public Pizzeria() { 
        
        }

        public void UpecPizzu(Pizza pizza)
        {
            if (pocetMistVPeci > 0)
            {
                pizzyVPeci.Add(pizza);
                Console.WriteLine("přidal si Pizzu {0} do pece", pizza.nazev);
                pocetMistVPeci--;
            }
            else
            {   
                Console.WriteLine("nemáš místo v peci");
            }
        }
        public void VyndejPizzu()
        {
            Console.WriteLine("Vyndal si pizzu {0}", pizzyVPeci[0].nazev);
            pizzyVPeci.RemoveAt(0);
            pocetMistVPeci++;
        }
    }
}
