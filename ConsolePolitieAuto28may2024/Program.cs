using ConsoleKinematics17may2024;
using LibraryPhysicalUnits8may2024;

namespace ConsolePolitieAuto28may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Beweging bij constante versnelling");
            Console.WriteLine("Oefening 44");

            Console.WriteLine("Een anonieme politieauto die constant 95 km/u rijdt, wordt ingehaald door een snelheidsovertreder die 135 km/u rijdt.");
            Console.WriteLine("Exact 1,00 s nadat de snelheidsovertreder is gepasseerd, drukt de politieagent het gaspedaal in;");
            Console.WriteLine("als de versnelling van de politieauto 2,00 m/s^2 is, hoe lang duurt het dan voordat de politieauto de snelheidsovertreder heeft ingehaald?");

            var snelheid_politieauto = new VelocityInKilometerPerHour6apr2024(95);
            var snelheid_overtreder = new VelocityInKilometerPerHour6apr2024(135);
            var tijd_politieauto = new TimeInSeconds8may2024(1, 0.01);
            var versnelling_politieauto = new AccelerationInMeterPerSecondSquared17may2024(2, 0.01);

            // (t + tijd_politieauto) * snelheid_overtreder = (t + tijd_politieauto) * snelheid_politieauto + versnelling_politieauto * t^2 /2
            //  versnelling_politieauto * t^2 /2 + t * (snelheid_politieauto - snelheid_overtreder) + tijd_politieauto * (snelheid_politieauto - snelheid_overtreder) = 0

            AccelerationInMeterPerSecondSquared17may2024 a = versnelling_politieauto / 2;
            var velocity = snelheid_politieauto - snelheid_overtreder;
            VelocityInMeterPerSecond13may2024 b = velocity.ConvertToMeterPerSecond();
            var distance = tijd_politieauto * (snelheid_politieauto - snelheid_overtreder);
            LengthInMeter8may2024 c = distance.ConvertToMeter();

            TweedeGraadsVergelijking17may2024 vergelijking = new TweedeGraadsVergelijking17may2024(a, b, c);
            //Console.WriteLine(vergelijking);
            vergelijking.ZoekNulpunten(out TimeInSeconds8may2024 t1, out TimeInSeconds8may2024 t2, out bool zijnGevonden);

            TimeInSeconds8may2024 time = null;
            if (zijnGevonden)
            {
                //Console.WriteLine("t1 = " + t1);
                //Console.WriteLine("t2 = " + t2);
                //Console.WriteLine("vergelijking.YWaarde(" + t1 + ") = " + vergelijking.YWaarde(t1));
                //Console.WriteLine("vergelijking.YWaarde(" + t2 + ") = " + vergelijking.YWaarde(t2));

                if (t1.GetInSeconds() > 0)
                {
                    time = t1;
                }
                else
                {
                    time = t2;
                }

                Console.WriteLine($"time = {time}");
            }
            Console.WriteLine("Vanaf het moment dat de politieauto start met versnellen kost het 12,03 seconden om de overtreder in te halen.");
            // time = 12,03 s
            Console.WriteLine("De afstand vanaf het passeren tot het inhalen is ");
            LengthInMeter8may2024 afstand = ((time + tijd_politieauto) * snelheid_overtreder).ConvertToMeter();
            Console.WriteLine(afstand); // 488,7 m

            Console.ReadKey();
        }
    }
}
