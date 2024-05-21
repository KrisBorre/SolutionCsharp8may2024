using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics15may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 40");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.23");

            Console.WriteLine("A ball thrown vertically upwards returns to its starting point is 4 s.");
            Console.WriteLine("Find its initial speed.");

            var acceleration = new AccelerationInMeterPerSecondSquared17may2024(-9.81);

            var time = new TimeInSeconds8may2024(2, 0);

            var initial_speed = -acceleration * time;

            Console.WriteLine("The initial speed is " + initial_speed); // 19,62 m/s

            Console.ReadKey();
        }
    }
}
