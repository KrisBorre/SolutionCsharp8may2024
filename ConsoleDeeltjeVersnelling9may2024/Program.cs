using LibraryPhysicalUnits8may2024;

namespace ConsoleDeeltjeVersnelling9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Oefening 27");

            Console.WriteLine("Een deeltje beweegt langs de x-as.");
            Console.WriteLine("Zijn plaats als functie van de tijd wordt gegeven door x = 6,8 t + 8,5 t^2 met t in seconden en x in meter.");
            Console.WriteLine("Wat is de versnelling als functie van de tijd?");

            // x = 6,8 t + 8,5 t^2
            // v = 6,8 + 8,5 *2 * t
            // a = 8,5 * 2
            var versnelling = new AccelerationInMeterPerSecondSquared17may2024(8.5 * 2);
            Console.WriteLine("De versnelling is " + versnelling); // 17 m / s^2
            // 17,0 m/s^2

            Console.ReadKey();
        }
    }
}
