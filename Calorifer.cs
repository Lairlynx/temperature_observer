namespace Observator
{
    
    internal class Calorifer
    {
        bool pornit = false;

        public void power(bool on)
        {
            Console.WriteLine($"Caloriferul este {(on ? "pornit" : "oprit")}.");
        }
        
        public void handler(int temperatura)
        {
            Console.WriteLine($"Caloriferul a primit temperatura de {temperatura} grade.");

            if (temperatura < 20)
            {
                if (!pornit) { power(true); }
            }
            else if (temperatura > 22)
            {
                if (pornit) { power(false); }
            }
        }
    }
}