using LibraryPhysicalUnits8may2024;

namespace ConsoleHardloopster9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Beweging bij constante versnelling");
            Console.WriteLine("Oefening 35");

            Console.WriteLine("Een hardloopster van wereldklasse kan in de eerste 15,0 meter van een race een topsnelheid bereiken (van circa 11,5 m/s).");
            Console.WriteLine("Wat is de gemiddelde versnelling van deze hardloopster en hoe lang doet zij erover om die snelheid te bereiken?");

            var fifteenMeter = new LengthInMeter8may2024(15, 0.1);
            var topsnelheid = new VelocityInMeterPerSecond13may2024(11.5, 0.1);

            // s = (a t^2) / 2  
            // s = (v * t) / 2
            // (2*s)/v = t
            var t = (2 * fifteenMeter) / topsnelheid;
            Console.WriteLine("t = " + t.GetInSeconds() + " seconden"); // 2,608695652173913 seconden           
            // 2,61 s
            Console.WriteLine("De nauwkeurigheid van de tijd is " + t.GetPrecisionInSeconds() + " seconden.");

            var gemiddelde_versnelling = topsnelheid / t;
            Console.WriteLine("De gemiddelde versnelling van de hardloopster is " + gemiddelde_versnelling); // 4,408333333333333 m / s^2
            // 4,41 m/s^2
            Console.WriteLine("De nauwkeurigheid van de gemiddelde_versnelling is " + gemiddelde_versnelling.GetPrecisionInMeterPerSecondSquared() + " m/s^2.");

            Console.ReadKey();
        }
    }
}
