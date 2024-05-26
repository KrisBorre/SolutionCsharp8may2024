using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics20may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 41");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.31");

            Console.WriteLine("A proton in a uniform electric field moves along a straight line with constant acceleration.");
            Console.WriteLine("Starting from rest it attains a velocity of 1000 km/s in a distance of 1 cm.");
            Console.WriteLine("(a) What is the acceleration?");
            Console.WriteLine("(b) What time is required to reach the given velocity?");

            var v = new VelocityInMeterPerSecond13may2024(1_000_000);

            var s = new LengthInCentimeter8may2024(1, 0);

            var a_times_t = v;

            var t = (2 * s) / a_times_t;

            var a = a_times_t / t;

            Console.WriteLine("a = " + a); // a = 50000000000000 m / s^2

            Console.WriteLine("t = " + t); // t = 2E-08 s

            Console.ReadKey();
        }
    }
}
