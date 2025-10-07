namespace Observator
{
    internal class Termometru : Abonat
    {
        public override void handle(int temp)
        {
            Console.WriteLine($"Termometru: temperatura este {temp}");
        }
    }
}