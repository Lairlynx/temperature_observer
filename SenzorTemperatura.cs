using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observator
{
    internal class SenzorTemperatura
    {
    Calorifer[] abonati;

        public SenzorTemperatura()
        {
            abonati = new Calorifer[5];
        }
        public bool aboneaza(Calorifer calorifer)
        {
            for (int i = 0; i < abonati.Length; i++)
            {
                if (abonati[i] == null)
                {
                    abonati[i] = calorifer;
                    return true;
                }
                // prevenim dublarea abonarii
                if (abonati[i] == calorifer)
                {
                    return false;
                }
            }
            return false;
        }

        public bool dezaboneaza(Calorifer calorifer)
        {
            for (int i = 0; i < abonati.Length; i++)
            {
                if (abonati[i] == calorifer)
                {
                    abonati[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void inject(int temperatura)
        {
            for (int i = 0; i < abonati.Length; i++)
            {
                abonati[i]?.handle(temperatura);
            }
        }

    }
}
