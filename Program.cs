namespace Observator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calorifer calorifer = new Calorifer("Sufragerie");
            Calorifer calorifer2 = new Calorifer("Bucatarie");
            SenzorTemperatura senzor = new SenzorTemperatura();

            // 1. 
            senzor.aboneaza(calorifer);
            senzor.aboneaza(calorifer2);

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
