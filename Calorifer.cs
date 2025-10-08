using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observator
{
    // mentine temp in [20, 22]
    internal class Calorifer : Abonat
    {
        bool pornit = false;
        string nume;
        public Calorifer(string n = "no name") {nume = n; }
        private void power(bool on)
        {
            pornit = on;
            Console.WriteLine($"Caloriferul {nume} se {(on ? "porneste" : "opreste")}");
        }

        public override void handle(int temp)
        {

            Console.WriteLine($"Caloriferul {nume} a primit temp {temp}");

            if (temp < 20)
            {
                if (!pornit) { power(true); }
            }
            else if (temp > 22)
            {
                if (pornit) { power(false); }
            }
        }
    }
}
