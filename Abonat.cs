using System.Security.Cryptography.X509Certificates;

namespace Observator
{
    internal class Abonat
    {
        public virtual void handle(int temp)
        {
            Console.WriteLine($"Abonat a primit temp {temp}");
        }
    }
}