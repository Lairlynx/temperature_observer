using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observator
{
    internal class SenzorTemperatura : Abonat
    {
    List<Abonat> abonati;

        public SenzorTemperatura()
        {
            abonati = new List<Abonat>();
        }
        public bool aboneaza(Abonat abonat)
        {
            bool contains = abonati.Contains(abonat);
            if (!contains)
            {
                abonati.Add(abonat);
            }
            return !contains;
        }

        public bool dezaboneaza(Abonat abonat)
        {
            return abonati.Remove(abonat);

        }

        public void inject(int temperatura)
        {
            foreach (var abonat in abonati)
            {
                abonat.handle(temperatura); //polimorfism
            }
        }

    }
}
