using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics8may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Exercise 3.2");

            Console.WriteLine("An auto travels at a rate of 25 km/h for 4 min, then at 50 km/h for 8 min, and finally at 20 km/h for 2 min.");

            Console.WriteLine("Find (a) the total distance covered in kilometers and ");
            Console.WriteLine("     (b) the average speed for the complete trip in meters per second.");

            var t1 = new TimeInMinutes8may2024(4, 0);
            Console.WriteLine("t1 in hours = " + t1.GetInHours()); // 4 min = 0.0666 hours
            var v1 = new VelocityInKilometerPerHour6apr2024(25);
            var s1 = t1 * v1;
            Console.WriteLine("s1 in kilometer = " + s1.GetInKilometer());  // 1.666 km

            var t2 = new TimeInMinutes8may2024(8, 0);
            Console.WriteLine("t2 in hours = " + t2.GetInHours()); // 8 min = 0.1333 hours
            var v2 = new VelocityInKilometerPerHour6apr2024(50);
            var s2 = t2 * v2;
            Console.WriteLine("s2 in kilometer = " + s2.GetInKilometer());  // 6.666 km

            var t3 = new TimeInMinutes8may2024(2, 0);
            Console.WriteLine("t3 in hours = " + t3.GetInHours()); // 2 min = 0.0333 hours
            var v3 = new VelocityInKilometerPerHour6apr2024(20);
            var s3 = t3 * v3;
            Console.WriteLine("s3 in kilometer = " + s3.GetInKilometer());  // 0.666 km

            var d = s1 + s2 + s3;
            Console.WriteLine("The total distance in kilometer = " + d.GetInKilometer()); // 9 km

            var time = t1 + t2 + t3;
            Console.WriteLine("The total time in hours = " + time.GetInHours()); // 0.233 hours

            var v_average = d / time;
            Console.WriteLine("The average velocity in km per hours = " + v_average.GetInKilometerPerHour()); // 38.571 km/h
            Console.WriteLine("The average velocity in meters per second =" + v_average.GetInMeterPerSecond()); // 10.714 m/s

            Console.ReadKey();
        }
    }
}
