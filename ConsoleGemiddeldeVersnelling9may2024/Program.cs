using LibraryPhysicalUnits8may2024;

namespace ConsoleGemiddeldeVersnelling9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 50");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Oefening 25");

            Console.WriteLine("Een auto die volgens een rechte lijn rijdt, begint op t=0 bij x=0.");
            Console.WriteLine("Hij passeert het punt x = 25,0 m met een snelheid van 11,0 m/s op t = 3,00 s.");
            Console.WriteLine("Hij passeert het punt x = 385 m met een snelheid van 45,0 m/s op t = 20,0 s.");

            Console.WriteLine("Bepaal (a) de gemiddelde snelheid en");
            Console.WriteLine("       (b) de gemiddelde versnelling tussen t = 3,00 s en t = 20,0 s");

            var length1 = new LengthInMeter8may2024(25, 0.1);
            var length2 = new LengthInMeter8may2024(385, 1);

            var time1 = new TimeInSeconds8may2024(3, 0.01);
            var time2 = new TimeInSeconds8may2024(20, 0.1);

            var gemiddelde_snelheid = (length2 - length1) / (time2 - time1);
            Console.WriteLine("De gemiddelde snelheid is " + gemiddelde_snelheid); // 21,176470588235293 m/s
            // 21,2 m/s

            var velocity1 = new VelocityInMeterPerSecond13may2024(11, 0.1);
            var velocity2 = new VelocityInMeterPerSecond13may2024(45, 0.1);

            var gemiddelde_versnelling = (velocity2 - velocity1) / (time2 - time1);
            Console.WriteLine("De gemiddelde versnelling is " + gemiddelde_versnelling); // 2 m / s^2
            // 2,00 m/s^2

            Console.ReadKey();
        }
    }
}
