using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics14may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.16");

            Console.WriteLine("An object moving at 13 m/s slows uniformly at a rate of 2 m/s each second for a time of 6 s.");

            Console.WriteLine("Determine (a) it final speed (b) its average speed during the 6 s, and (c) the distance moved in the 6 seconds.");

            var velocity_initial = new VelocityInMeterPerSecond13may2024(13);

            var velocity_change = new VelocityInMeterPerSecond13may2024(-2);
            var each_second = new TimeInSeconds8may2024(1, 0);
            var acceleration = velocity_change / each_second;

            var time = new TimeInSeconds8may2024(6, 0);

            var velocity_final = velocity_initial + acceleration * time;
            Console.WriteLine("the final speed is " + velocity_final); // 1 m/s

            var distance = velocity_initial * time + 0.5 * acceleration * time * time;
            Console.WriteLine("The distance is " + distance); // 42 m

            var average_speed = distance / time;
            Console.WriteLine("The average speed is " + average_speed); // 7 m/s

            Console.ReadKey();
        }
    }
}
