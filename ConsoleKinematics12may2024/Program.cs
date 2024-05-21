using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics12may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Constant acceleration problems");

            Console.WriteLine("Exercise 3.12");

            Console.WriteLine("A car is accelerating uniformly as it passes two checkpoints that are 30 m apart.");

            Console.WriteLine("The time taken between checkpoints is 4 s and the car's speed at the checkpoint is 5 m/s");

            Console.WriteLine("Find the car's acceleration and its speed at the second checkpoint.");

            var distance = new LengthInMeter8may2024(30, 0);

            var time = new TimeInSeconds8may2024(4, 0);

            var speed_checkpoint1 = new VelocityInMeterPerSecond13may2024(5);

            var acceleration = 2 * (distance / time - speed_checkpoint1) / time;

            Console.WriteLine("The acceleration is " + acceleration); // 1,25 m / s^2

            var speed_checkpoint2 = speed_checkpoint1 + acceleration * time;

            Console.WriteLine("The speed at the second checkpoint is " + speed_checkpoint2); // 10 m/s

            Console.ReadKey();
        }
    }
}
