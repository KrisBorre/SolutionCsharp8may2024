using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics25may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 46");
            Console.WriteLine("Exercise 3.52");

            Console.WriteLine("Two balls are dropped to the ground from different heights.");
            Console.WriteLine("One ball is dropped 2 s after the other but they both strike the ground at the same time, 5 s after the first is dropped.");
            Console.WriteLine("(a) What is the difference in the heights at which they were dropped?");
            Console.WriteLine("(b) From what height was the first dropped?");

            Console.WriteLine("(a)");

            var time_difference = new TimeInSeconds8may2024(2, 0);
            var time_ball_1 = new TimeInSeconds8may2024(5, 0);
            var time_ball_2 = time_ball_1 - time_difference;

            var a = new AccelerationInMeterPerSecondSquared17may2024(-9.81);

            var height_1 = -a * time_ball_1.Square() / 2.0;
            Console.WriteLine("height_1 = " + height_1); // 122.6 m

            var height_2 = -a * time_ball_2.Square() / 2.0;
            Console.WriteLine("height_2 = " + height_2); // 44.14 m

            var height_difference = height_1 - height_2;
            Console.WriteLine("height_difference = " + height_difference); // 78.48 m

            Console.WriteLine("(b)");

            Console.WriteLine("height_1 = " + height_1); // 122.6 m

            Console.ReadKey();
        }
    }
}
