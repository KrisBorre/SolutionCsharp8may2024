using LibraryPhysicalUnits8may2024;

namespace ConsoleOppervlakMaan8may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - pagina 17");
            Console.WriteLine("Oefening 17");
            Console.WriteLine("De diameter van de maan is 3480 km.");
            Console.WriteLine("(a) Hoe groot is het buitenoppervlak van de maan.");
            Console.WriteLine("(b) Hoeveel keer groter is het buitenoppervlak van de Aarde?");

            var diameter_moon = new LengthInKilometer8may2024(3480, 0);
            var radius_moon = diameter_moon / 2;
            var surface_moon = 4 * Math.PI * radius_moon.Square();

            Console.WriteLine("Oppervlak van de maan is " + surface_moon); // 38_045_943,67.. km^2

            var radius_earth = new LengthInMeter8may2024(6_500_000, 0);
            var surface_earth = 4 * Math.PI * radius_earth.Square();

            Console.WriteLine("Oppervlak van de aarde is " + surface_earth); // 530_929_158_456_675,06 m^2

            double ratio = surface_earth / surface_moon;
            Console.WriteLine($"De oppervlak van de aarde is {ratio} keer groter dan de oppervlakte van de maan."); // 13,95

            Console.ReadKey();
        }
    }
}
