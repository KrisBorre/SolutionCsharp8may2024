using LibraryPhysicalUnits8may2024;

namespace ConsoleHonkbalwerper9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Beweging bij constante versnelling");
            Console.WriteLine("Oefening 33");
            Console.WriteLine("Een honkbalwerper gooit een honkbal met een snelheid van 41 m/s.");
            Console.WriteLine("Geef een schatting van de gemiddelde versnelling van de bal tijdens het werpen.");
            Console.WriteLine("Bij het gooien van de honkbal versnelt de werper de bal door een verplaatsing van circa 3,5 m, van achter het lichaam tot het punt waar deze wordt losgelaten.");

            var snelheid = new VelocityInMeterPerSecond13may2024(41);

            var verplaatsing = new LengthInMeter8may2024(3.5, 0);

            var acceleration_multiplied_with_time = snelheid;

            // s = (a t^2) / 2

            // verplaatsing = (acceleration_multiplied_with_time * t ) / 2

            var t = (2 * verplaatsing) / acceleration_multiplied_with_time;
            Console.WriteLine("t = " + t); // 0,17073170731707318 s

            var a = acceleration_multiplied_with_time / t;
            Console.WriteLine("a = " + a); // 240,14285714285714 m / s^2
            // 240 m/s^2

            Console.ReadKey();
        }
    }
}
