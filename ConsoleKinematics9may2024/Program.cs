using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics9may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Exercise 3.8");

            Console.WriteLine("A body with initial velocity 8 m/s moves along a straight line with constant acceleration and travels 640 m in 40 s.");
            Console.WriteLine("For the 40 s interval, find (a) the average velocity");
            Console.WriteLine("(b) the final velocity, and (c) the acceleration.");

            var s = new LengthInMeter8may2024(640, 0);
            var t = new TimeInSeconds8may2024(40, 0);

            var v_average = s / t;
            Console.WriteLine("The average velocity is " + v_average); // 16 m/s

            var v_initial = new VelocityInMeterPerSecond13may2024(8);

            // x = v_0 t + 1/2 a t^2
            // a = (x - v_O t) * (2 / t^2)
            var a = 2 * (s / t - v_initial) / t;

            Console.WriteLine("The acceleration is " + a); // 0,4 m / s^2

            var v_final = v_initial + a * t;
            Console.WriteLine("The final velocity is " + v_final); // 24 m/s

            Console.ReadKey();
        }
    }
}
