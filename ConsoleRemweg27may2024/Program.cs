using LibraryPhysicalUnits8may2024;

namespace ConsoleRemweg27may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Beweging bij constante versnelling");
            Console.WriteLine("Oefening 41");

            Console.WriteLine("Bepaal de remweg voor een auto met een beginsnelheid van 95 km/h en een reactietijd van de bestuurder van 1,0 s:");
            Console.WriteLine("a) bij een versnelling a = -5,0 m/s^2");
            Console.WriteLine("b) bij a = -7,0 m/s^2");

            Console.WriteLine("a)");
            var beginsnelheid = new VelocityInKilometerPerHour6apr2024(95, 1);
            var reactietijd = new TimeInSeconds8may2024(1, 0.1);
            var a1 = new AccelerationInMeterPerSecondSquared17may2024(-5, 0.1);
            var reactie_afstand = beginsnelheid * reactietijd;
            var t2_a = beginsnelheid / a1;
            var s2_a = -a1 * t2_a.Square() / 2;
            var remweg_a = reactie_afstand + s2_a;
            Console.WriteLine("s = " + remweg_a); // 96 meter

            Console.WriteLine("b)");
            var a2 = new AccelerationInMeterPerSecondSquared17may2024(-7, 0.1);
            var t2_b = beginsnelheid / a2;
            var s2_b = -a2 * t2_b.Square() / 2;
            var remweg_b = reactie_afstand + s2_b;
            Console.WriteLine("s = " + remweg_b); // 76 meter

            Console.ReadKey();
        }
    }
}
