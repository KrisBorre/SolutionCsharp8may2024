using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics24may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 46");
            Console.WriteLine("Exercise 3.50");

            Console.WriteLine("Just as a car starts to accelerate from rest with acceleration 1.4 m/s^2, a bus moving with constant speed of 12 m/s passes it in a parallel lane.");
            Console.WriteLine("(a) How long before the car overtakes the bus?");
            Console.WriteLine("(b) How fast will the car then be going?");
            Console.WriteLine("(c) How far will the car then have gone?");

            var acceleration_car = new AccelerationInMeterPerSecondSquared17may2024(1.4);
            var speed_bus = new VelocityInMeterPerSecond13may2024(12);

            Console.WriteLine("(a)");

            var time = speed_bus / (acceleration_car / 2);
            Console.WriteLine("time = " + time); // 17.14 s

            Console.WriteLine("(b)");

            var speed_car = acceleration_car * time;
            Console.WriteLine("speed_car = " + speed_car); // 24 m/s

            Console.WriteLine("(c)");

            var distance_car = acceleration_car * 0.5 * time.Square();
            Console.WriteLine("distance_car = " + distance_car); // 205 m

            Console.ReadKey();
        }
    }
}
