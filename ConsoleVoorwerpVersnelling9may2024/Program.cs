using LibraryPhysicalUnits8may2024;

namespace ConsoleVoorwerpVersnelling9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Oefening 29");

            Console.WriteLine("De plaast van een voorwerp wordt gegeven door x = A t + B t^2 met t in seconden en x in meter.");
            Console.WriteLine("(a) Wat zijn de eenheden van A en B?");
            Console.WriteLine("(b) Wat is de versnelling als functie van de tijd?");
            Console.WriteLine("(c) Hoe groot zijn de snelheid en de versnelling op t = 5,0 s ?");
            Console.WriteLine("(d) Wat is de snelheid als functie van de tijd als x = A t + B t^(-3) ?");

            var t = new TimeInSeconds8may2024(1, 0);

            var A = new VelocityInMeterPerSecond13may2024(1);
            var B = new AccelerationInMeterPerSecondSquared17may2024(1);

            LengthInMeter8may2024 x = A * t + B * t * t;

            VelocityInMeterPerSecond13may2024 v = A + B * 2 * t;
            AccelerationInMeterPerSecondSquared17may2024 a = B * 2;

            var fiveSeconds = new TimeInSeconds8may2024(5, 0);
            v = A + B * 2 * fiveSeconds;
            a = B * 2;

            // x = A t + B t^(-3)
            // v = A + B * (-3) * t^(-4)

            Console.ReadKey();
        }
    }
}
