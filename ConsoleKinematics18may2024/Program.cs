using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics18may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 40");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.26");

            Console.WriteLine("A stone is thrown vertically upward with velocity 40 m/s at the edge of a cliff having a height of 110 m.");
            Console.WriteLine("Neglecting air resistance, compute the time required to strike the ground at the base of the cliff.");
            Console.WriteLine("With what velocity does it strike?");

            var velocity_initial = new VelocityInMeterPerSecond13may2024(40);
            var height = new LengthInMeter8may2024(110, 0);
            var g = new AccelerationInMeterPerSecondSquared17may2024(9.81);

            var strike_velocity_squared = velocity_initial.Square() + 2 * g * height;

            Console.WriteLine("v^2 = " + strike_velocity_squared);

            var strike_velocity = -strike_velocity_squared.SquareRoot();

            Console.WriteLine("v = " + strike_velocity + " (downward motion)");

            /*
            v^2 = 3758,2000000000003 (m/s)^2
            v = -61,30415972835775 m/s (downward motion)
            */

            Console.ReadKey();
        }
    }
}
