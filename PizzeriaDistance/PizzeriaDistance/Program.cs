namespace PizzeriaDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Skladiste.DostupneSuroviny();
            Pizza_A A = new Pizza_A("sýrová");
            Pizza_B B = new Pizza_B("šunková");


            Pizzeria Pampam2 = new Pizzeria();
            Pampam2.UpecPizzu(A);
            Pampam2.UpecPizzu(B);
            Pampam2.VyndejPizzu();
        }
    }
}