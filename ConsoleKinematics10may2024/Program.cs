using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics10may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Exercise 3.9");

            Console.WriteLine("A truck starts from rest and moves with a constant acceleration of 5 m/s^2");

            Console.WriteLine("Find its speed and the distance traveled after 4 s has elapsed.");

            var acceleration = new AccelerationInMeterPerSecondSquared17may2024(5);
            var t = new TimeInSeconds8may2024(4, 0);

            var speed = acceleration * t;

            Console.WriteLine("The speed is " + speed); // 20 m/s

            var distance = 0.5 * acceleration * t * t;

            Console.WriteLine("The distance is " + distance); // 40 m

            Console.ReadKey();
        }
    }
}
