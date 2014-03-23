using System.Threading;

namespace Blink
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Leds.Red.Toggle();
                Thread.Sleep(500); // Sleep for 500ms
            }
        }

    }
}
