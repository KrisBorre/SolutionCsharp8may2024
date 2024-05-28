using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics22may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 46");
            Console.WriteLine("Exercise 3.48");

            Console.WriteLine("A ball is dropped from the top of a building.");
            Console.WriteLine("The ball takes 0.5 s to fall past the 3 m length of a window some distance from the top of the building.");
            Console.WriteLine("(a) How fast was the ball going as it passed the top of the window?");
            Console.WriteLine("(b) How far is the top of the window from the point at which the ball was dropped?");

            var t = new TimeInSeconds8may2024(0.5, 0);

            var x = new LengthInMeter8may2024(3, 0);

            var g = new AccelerationInMeterPerSecondSquared17may2024(9.81);

            var velocity_1 = (x - (g * t.Square()) / 2) / t;

            Console.WriteLine("velocity_1 = " + velocity_1);
            // velocity = 3,5475 m/s

            var t_1 = velocity_1 / g;

            var x_1 = (g * t_1.Square()) / 2;

            Console.WriteLine("x_1 = " + x_1);
            // x_1 = 0,6414248853211008 m

            Console.ReadKey();
        }
    }
}
