using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics21may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 42");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.35");

            Console.WriteLine("A nut comes loose from a bolt on the bottom of an elevator as the elevator is moving up the shaft at 3 m/s.");
            Console.WriteLine("The nut strikes the bottom of the shaft in 2 s.");
            Console.WriteLine("(a) How far from the bottom of the shaft was the elevator when the nut fell off?");
            Console.WriteLine("(b) How far above the bottom was the nut 0.25 s after if fell off?");

            var velocity_initial = new VelocityInMeterPerSecond13may2024(3);

            var g = new AccelerationInMeterPerSecondSquared17may2024(9.81);

            var t = new TimeInSeconds8may2024(2, 0);

            var x_a = velocity_initial * t - ((g * t) * t) / 2.0;
            Console.WriteLine("x_a = " + x_a);
            // x_a = -13,620000000000001 m

            var t_b = new TimeInSeconds8may2024(0.25, 0);
            
            var x_b = velocity_initial * t_b - (g * t_b.Square()) / 2.0;
            Console.WriteLine("x_b = " + x_b);
            // x_b = 0,4434375 m

            Console.ReadKey();
        }
    }
}
