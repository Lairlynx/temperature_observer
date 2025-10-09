namespace Observator
{
    //Action<int> abonati;
    delegate void CALLBACK(int temperatura);
    
    internal class SenzorTemperatura
    {
        CALLBACK abonati;

        public void aboneaza(CALLBACK abonat)
        {
            abonati += abonat;   
        }

        public void dezaboneaza(CALLBACK abonat)
        {
            abonati -= abonat;
        }

        public void inject(int temperatura)
        {
            if (abonati != null)
            {
                abonati(temperatura);
            }
        }

    }
}
