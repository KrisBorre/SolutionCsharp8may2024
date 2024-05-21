using LibraryPhysicalUnits8may2024;

namespace ConsoleSignificanteCijfers9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli");
            Console.WriteLine("Eenheden, standaarden, SI, eenheden omzetten, orde van grootte schatten.");
            Console.WriteLine("Oefening 33");

            Console.WriteLine("Het global positioning system (GPS) kan worden gebruikt voor zeer nauwkeurige plaatsbepalingen met behulp van satellieten.");
            Console.WriteLine("Als één van de satellieten 20 000 km van je verwijderd is, welke onnauwkeurigheidspercentage in de afstand hoort er dan bij een onnauwkeurigheid van 2 m?");
            Console.WriteLine("Hoeveel significante cijfers zijn er nodig in de afstand?");

            var length1 = new LengthInMeter8may2024(2, 0);
            var length2 = new LengthInKilometer8may2024(20_000, 0);

            var onnauwkeurigheidspercentage = length1 / length2;

            Console.WriteLine("onnauwkeurigheidspercentage = " + onnauwkeurigheidspercentage); // 1E-07
            // 10E-5 procent = 0.00001 %

            // acht significante cijfers.

            Console.ReadKey();
        }
    }
}
