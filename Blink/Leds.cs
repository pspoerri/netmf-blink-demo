using Microsoft.SPOT.Hardware;
using Mountaineer.Netmf.Hardware;

namespace Blink
{
    public static class Leds
    {
        public static OutputPort Red { get; private set; }
        public static OutputPort Green { get; private set; }
        public static OutputPort Blue { get; private set; }

        static Leds()
        {
            Red = new OutputPort(OnboardIO.LedRed, false);
            Green = new OutputPort(OnboardIO.LedGreen, false);
            Blue = new OutputPort(OnboardIO.LedBlue, false);
        }

        public static void Toggle(this OutputPort port)
        {
            port.Write(!port.Read());
        }
    }
}