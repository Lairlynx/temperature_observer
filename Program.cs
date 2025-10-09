namespace Observator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calorifer calorifer = new Calorifer("Sufragerie");
            Calorifer calorifer2 = new Calorifer("Bucatarie");

            SenzorTemperatura senzor = new SenzorTemperatura();

            Termometru termometru = new Termometru();

            // 1. 
            senzor.aboneaza(calorifer.handle);
            senzor.aboneaza(calorifer2.handle);
            senzor.aboneaza(termometru.afiseaza);

            // 2.
            senzor.inject(21);
            senzor.inject(20);
            senzor.inject(19);
            senzor.inject(20);
            senzor.inject(21);
            senzor.inject(23);
            // ...
        }
    }
}
