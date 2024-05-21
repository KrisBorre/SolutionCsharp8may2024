using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics17may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 40");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.22");

            Console.WriteLine("A stone is thrown downward with initial speed 8 m/s from a height of 25 m.");
            Console.WriteLine("Find (a) the time it takes to reach the ground and (b) the speed with which it strikes.");

            var height = new LengthInMeter8may2024(25, 0);
            var initial_speed = new VelocityInMeterPerSecond13may2024(8);
            var g = new AccelerationInMeterPerSecondSquared17may2024(9.81);

            var vgl1 = new TweedeGraadsVergelijking17may2024(g / 2, initial_speed, -height);
            Console.WriteLine(vgl1);
            vgl1.ZoekNulpunten(out TimeInSeconds8may2024 t1, out TimeInSeconds8may2024 t2, out bool zijnGevonden);
            if (zijnGevonden)
            {
                Console.WriteLine("t1 = " + t1);
                Console.WriteLine("t2 = " + t2);
                Console.WriteLine("vgl1.YWaarde(" + t1 + ") = " + vgl1.YWaarde(t1));
                Console.WriteLine("vgl1.YWaarde(" + t2 + ") = " + vgl1.YWaarde(t2));

                TimeInSeconds8may2024 time;
                if (t1.GetInSeconds() > 0)
                {
                    time = t1;
                }
                else
                {
                    time = t2;
                }

                Console.WriteLine($"time = {time}");
                // time = 1.58 s
                VelocityInMeterPerSecond13may2024 final_speed = initial_speed + g * time;
                Console.WriteLine($"final speed = {final_speed}");
                // final speed = 23.5 m/s
            }

            /*
            Schaum's Physics
            Chapter3: Kinematics in one dimension
            page 40
            Constant acceleration problems
            Exercise 3.22
            A stone is thrown downward with initial speed 8 m/s from a height of 25 m.
            Find (a) the time it takes to reach the ground and (b) the speed with which it strikes.
            4,905 m / s^2 * t^2 + 8 m/s * t + -25 m
            t1 = 1,584895380084937 s
            t2 = -3,2158841670370264 s
            vgl1.YWaarde(1,584895380084937 s) = -3,552713678800501E-15 m
            vgl1.YWaarde(-3,2158841670370264 s) = -1,0658141036401503E-14 m
            time = 1,584895380084937 s
            final speed = 23,547823678633232 m/s
            */

            Console.ReadKey();
        }
    }
}
