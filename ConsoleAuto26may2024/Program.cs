using LibraryPhysicalUnits8may2024;

namespace ConsoleAuto26may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Beweging bij constante versnelling");
            Console.WriteLine("Oefening 37");

            Console.WriteLine("Een auto remt in 5,00 s gelijkmatig af van een snelheid van 18,0 m/s tot rust.");
            Console.WriteLine("Welke afstand heeft hij in die tijd afgelegd?");

            var time = new TimeInSeconds8may2024(5, 0.01);
            var speed = new VelocityInMeterPerSecond13may2024(18, 0.1);

            AccelerationInMeterPerSecondSquared17may2024 a = speed / time;

            var distance = a * time.Square() / 2;

            Console.WriteLine("afstand = " + distance); // 45.0 m

            Console.WriteLine("Precisie van afstand = " + distance.GetPrecisionInMeter() + " m");

            Console.ReadKey();
        }
    }
}
