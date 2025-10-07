namespace Observator
{
    internal class SenzorTemperatura
    {
        Calorifer abonat = null;

        public bool aboneaza(Calorifer calorifer)
        {
            bool rez = false;
            if (abonat == null)
            {
                abonat = calorifer;
                rez = true;
            }
            return rez;
        }

        public bool dezaboneaza(Calorifer calorifer)
        {
            bool rez = false;
            if (abonat == null)
            {
                abonat = calorifer;
                rez = true;
            }
            return rez;
        }

        public void inject(int temperatura)
        {
            /*
            if (abonat != null)
            {
                abonat.handler(temperatura);
            }
            */
            abonat?.handler(temperatura);
        }
    }
}