namespace Observator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calorifer calorifer = new Calorifer();
            SenzorTemperatura senzor = new SenzorTemperatura();

            //1.
            senzor.aboneaza(calorifer);

            //2.
            senzor.inject(21);
            senzor.inject(20);
            senzor.inject(19);
            senzor.inject(20);
            senzor.inject(21);
            senzor.inject(23);
            //.

        }
    }
}