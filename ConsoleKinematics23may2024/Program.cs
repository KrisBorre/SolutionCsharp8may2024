using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics23may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 46");
            Console.WriteLine("Exercise 3.49");

            Console.WriteLine("A truck is moving forward at a constant speed of 21 m/s.");
            Console.WriteLine("The driver sees a stationary car directly ahead at a distance of 110 m.");
            Console.WriteLine("After a \"reaction time\" of delta t, he applies the brakes, which gives the truck an acceleration of -3 m/s^2");
            Console.WriteLine("(a) What is the maximum allowable delta t to avoid a collision, and what distance will the truck have moved before the brakes take hold?");
            Console.WriteLine("(b) Assuming a reaction time of 1.4 s, how far behind the car will the truck stop, and in how many seconds from the time the driver first saw the car?");

            var speed_initial = new VelocityInMeterPerSecond13may2024(21);
            var speed_final = new VelocityInMeterPerSecond13may2024(0);

            var distance_from_stationary_car = new LengthInMeter8may2024(110, 0);

            var acceleration = new AccelerationInMeterPerSecondSquared17may2024(-3);

            Console.WriteLine("(a)");

            var brake_time = (speed_final - speed_initial) / acceleration;

            Console.WriteLine("brake_time = " + brake_time); // 7 s 

            var brake_distance = speed_initial * brake_time + (acceleration * brake_time.Square()) / 2.0;

            Console.WriteLine("brake_distance = " + brake_distance); // 73.5 m         

            var distance_moved_before_braking = distance_from_stationary_car - brake_distance;
            Console.WriteLine("distance_moved_before_braking = " + distance_moved_before_braking); // 36.5 m

            var maximum_allowable_delta_t = distance_moved_before_braking / speed_initial;
            Console.WriteLine("maximum_allowable_delta_t = " + maximum_allowable_delta_t); // 1.74 s

            Console.WriteLine("(b)");

            var reaction_time = new TimeInSeconds8may2024(1.4, 0);

            var reaction_distance = reaction_time * speed_initial;

            Console.WriteLine("reaction_distance = " + reaction_distance); // 29.4 m

            var new_distance_from_stationary_car = distance_from_stationary_car - reaction_distance;

            Console.WriteLine("new_distance_from_stationary_car = " + new_distance_from_stationary_car); // 80.6 m

            var distance_from_car = new_distance_from_stationary_car - brake_distance;

            Console.WriteLine("distance_from_car = " + distance_from_car); // 7.1 m

            Console.WriteLine("The truck stops at a distance of 7.1 meters from the stationary car.");

            var time_between_seen_the_car_and_stopping = reaction_time + brake_time;

            Console.WriteLine("time_between_seen_the_car_and_stopping = " + time_between_seen_the_car_and_stopping); // 8.4 s

            Console.ReadKey();
        }
    }
}
