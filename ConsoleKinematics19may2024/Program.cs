using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics19may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 40");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.29");

            Console.WriteLine("The acceleration due to gravity at the surface of Mars is roughly 4 m/s^2");
            Console.WriteLine("If an astronaut on Mars were to toss a wrench upward with a speed of 10 m/s,");
            Console.WriteLine("find (a) how long it would rise;");
            Console.WriteLine("(b) how high it would go;");
            Console.WriteLine("(c) its speed at t = 3 s;");
            Console.WriteLine("and (d) its displacement at t = 3 s.");

            Console.WriteLine("Answersing:");
            Console.WriteLine("(a)");
            var g = new AccelerationInMeterPerSecondSquared17may2024(4);
            var velocity_initial = new VelocityInMeterPerSecond13may2024(10);
            var velocity_final = new VelocityInMeterPerSecond13may2024(0);
            var time_rise = (velocity_initial - velocity_final) / g;
            Console.WriteLine("t = " + time_rise + " is how long it would rise.");
            // t = 2,5 s is how long it would rise.

            Console.WriteLine("(b)");
            var h = velocity_initial.Square() / (2 * g);
            Console.WriteLine("s_max = " + h + " is how high it would go.");
            // s_max = 12,5 m is how high it would go.

            Console.WriteLine("(c)");
            var t = new TimeInSeconds8may2024(3, 0) - time_rise;
            var v_3 = g * t;
            Console.WriteLine("v_3 = " + v_3 + " is the speed downward after 3 seconds.");
            // v_3 = 2 m/s is the speed downward after 3 seconds.

            Console.WriteLine("(d)");
            var s_3 = (velocity_initial.Square() / 2 - v_3.Square() / 2) / g;
            Console.WriteLine("s_3 = " + s_3 + " is the displacement at t = 3 s");
            // s_3 = 12 m is the displacement at t = 3 s

            Console.ReadKey();
        }
    }
}
