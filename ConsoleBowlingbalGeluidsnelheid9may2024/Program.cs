using LibraryPhysicalUnits8may2024;

namespace ConsoleBowlingbalGeluidsnelheid9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 50");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Oefening 19");

            Console.WriteLine("Een bowlingbal die met constante snelheid rolt raakt de kegels aan het einde van een bowlingbaan van 16,5 m lang.");
            Console.WriteLine("De bowler hoort het geluid van de bal die de kegels raakt 2,50 s nadat hij de bal heeft losgelaten.");
            Console.WriteLine("Wat is de snelheid van de bal, aangenomen dat de geluidsnelheid 340 m/s is?");

            var s = new LengthInMeter8may2024(16.5, 0);
            var v = new VelocityInMeterPerSecond13may2024(340, 0);

            var tijd_geluid = s / v;
            Console.WriteLine("Tijd die het geluid nodig heeft is " + tijd_geluid); // 0,04852941176470588 s

            var totale_tijd = new TimeInSeconds8may2024(2.50, 0.01);
            var tijd = totale_tijd - tijd_geluid;

            Console.WriteLine("Tijd is " + tijd); // 2,4514705882352943 s

            var snelheid_van_de_bal = s / tijd;
            Console.WriteLine("De snelheid van de bal is "+ snelheid_van_de_bal); // 6,730653869226154 m/s
            // 6,73 m/s

            Console.ReadKey();
        }
    }
}
