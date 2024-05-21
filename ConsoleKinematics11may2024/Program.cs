using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics11may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Constant acceleration problems");

            Console.WriteLine("Exercise 3.10");

            Console.WriteLine("A box slides down an incline with uniform acceleration.");

            Console.WriteLine("It starts from rest and attains a speed of 2.7 m/s in 3 s.");

            Console.WriteLine("Find (a) the acceleration and (b) the distance moved in the first 6 s.");

            var speed = new VelocityInMeterPerSecond13may2024(2.7);
            var t = new TimeInSeconds8may2024(3, 0);

            var acceleration = speed / t;

            Console.WriteLine("The acceleration is " + acceleration); // 0,9 m / s^2

            var time2 = new TimeInSeconds8may2024(6, 0);

            var distance = 0.5 * acceleration * time2 * time2;
            Console.WriteLine("The distance is " + distance); // 16,200000000000003 m
            Console.WriteLine("The distance in meter = " + distance.GetInMeter()); // 16,200000000000003

            Console.ReadKey();
        }
    }
}
