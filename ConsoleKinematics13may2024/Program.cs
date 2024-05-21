using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics13may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("page 38");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.13");

            Console.WriteLine("An auto's velocity increases uniformly from 6 m/s to 20 m/s while covering 70 m.");

            Console.WriteLine("Find the acceleration and the time taken.");

            var velocity_initial = new VelocityInMeterPerSecond13may2024(6);
            var velocity_final = new VelocityInMeterPerSecond13may2024(20);

            var distance = new LengthInMeter8may2024(70, 0);

            var acceleration_multiplied_by_time = (velocity_final - velocity_initial);

            // distance = v_initial * time + a * time^2 / 2
            // distance = time * (v_initial + a * time / 2)
            var time = distance / (velocity_initial + acceleration_multiplied_by_time / 2);
            Console.WriteLine("The time is " + time); // 5,384615384615385 s

            var acceleration = acceleration_multiplied_by_time / time;
            Console.WriteLine("The acceleration is " + acceleration); // 2,5999999999999996 m / s^2

            Console.ReadKey();
        }
    }
}
