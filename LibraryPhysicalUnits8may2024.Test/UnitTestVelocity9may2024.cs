namespace LibraryPhysicalUnits8may2024.Test
{
    public class UnitTestVelocity9may2024
    {
        [Fact]
        public void Test1()
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);

            double value1 = 5;
            double value2 = LengthCalculation9may2024.ConvertKilometerIntoMeter(value1);
            Assert.Equal(expected: 5000, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value1 / time1);
            VelocityInMeterPerSecond13may2024 velocity2 = new VelocityInMeterPerSecond13may2024(value2 / time2);

            double result = VelocityCalculation9may2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());

            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test2()
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);

            double value1 = 1000;
            double value2 = LengthCalculation9may2024.ConvertMeterIntoKilometer(value1);
            Assert.Equal(expected: 1, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value2 / time1);
            VelocityInMeterPerSecond13may2024 velocity2 = new VelocityInMeterPerSecond13may2024(value1 / time2);

            double result = VelocityCalculation9may2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());

            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test3()
        {
            double time1 = 3600;
            double time2 = TimeCalculation13may2024.ConvertSecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);

            double value1 = 5;
            double value2 = LengthCalculation9may2024.ConvertKilometerIntoMeter(value1);
            Assert.Equal(expected: 5000, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value1 / time2);
            VelocityInMeterPerSecond13may2024 velocity2 = new VelocityInMeterPerSecond13may2024(value2 / time1);

            double result = VelocityCalculation9may2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());
            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test4()
        {
            double time1 = 3600;
            double time2 = TimeCalculation13may2024.ConvertSecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);

            double value1 = 1000;
            double value2 = LengthCalculation9may2024.ConvertMeterIntoKilometer(value1);
            Assert.Equal(expected: 1, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value2 / time2);
            VelocityInMeterPerSecond13may2024 velocity2 = new VelocityInMeterPerSecond13may2024(value1 / time1);

            double result = VelocityCalculation9may2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());
            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test5()
        {
            Console.WriteLine("Een chauffeur rijdt 12 kilometer in 10 minuten.");
            Console.WriteLine("Hoeveel kilometer legt hij af in een uur?");

            LengthInKilometer8may2024 lengthInKilometer1 = new LengthInKilometer8may2024(12, 0);

            TimeInMinutes8may2024 timeInMinutes = new TimeInMinutes8may2024(10, 0);

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(lengthInKilometer1.GetInKilometer() / timeInMinutes.GetInHours());

            TimeInHours6apr2024 timeInHours = new TimeInHours6apr2024(1, 0);

            LengthInKilometer8may2024 lengthInKilometer2 = velocityInKilometerPerHour * timeInHours;

            Assert.Equal(expected: 72, actual: lengthInKilometer2.GetInKilometer());
        }

        [Fact]
        public void Test6()
        {
            Console.WriteLine("Bereken de afstand die is afgelegd door een auto wanneer gegeven is dat zijn gemiddelde snelheid 50 km/u is en de benodigde tijd 1 uur en 20 minuten is.");

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(50);

            TimeInHours6apr2024 timeInHours1 = new TimeInHours6apr2024(1, 0);
            TimeInMinutes8may2024 timeInMinutes2 = new TimeInMinutes8may2024(20, 0);

            var time = timeInHours1 + timeInMinutes2;

            LengthInKilometer8may2024 length = velocityInKilometerPerHour * time;

            Assert.Equal(expected: 66.666666, actual: length.GetInKilometer(), 0.0001);
        }

        [Fact]
        public void Test7()
        {
            Console.WriteLine("Een wielrenner fietst 60 km per uur.");
            Console.WriteLine("Hoeveel meter per seconde fietst hij ongeveer?");

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(60);

            Assert.Equal(expected: 16.666666, actual: velocityInKilometerPerHour.GetInMeterPerSecond(), 0.0001);
        }

        [Theory]
        [InlineData(5, 5000)]
        [InlineData(1, 1000)]
        public void Test8(double input, double expected)
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);

            double value1 = input;
            double value2 = LengthCalculation9may2024.ConvertKilometerIntoMeter(value1);
            Assert.Equal(expected: expected, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value1 / time1);
            VelocityInMeterPerSecond13may2024 velocity2 = new VelocityInMeterPerSecond13may2024(value2 / time2);

            double result = VelocityCalculation9may2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());

            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test9()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Exercise 3.8");

            Console.WriteLine("A body with initial velocity 8 m/s moves along a straight line with constant acceleration and travels 640 m in 40 s.");
            Console.WriteLine("For the 40 s interval, find (a) the average velocity");
            Console.WriteLine("(b) the final velocity, and (c) the acceleration.");

            var s = new LengthInMeter8may2024(640, 0);
            var t = new TimeInSeconds8may2024(40, 0);

            var v_average = s / t;
            Console.WriteLine("The average velocity is " + v_average); // 16 m/s
            Assert.Equal(expected: "16 m/s", actual: v_average.ToString());

            var v_initial = new VelocityInMeterPerSecond13may2024(8);

            // x = v_0 t + 1/2 a t^2
            // a = (x - v_O t) * (2 / t^2)
            var a = 2 * (s / t - v_initial) / t;

            Console.WriteLine("The acceleration is " + a); // 0,4 m / s^2
            Assert.Equal(expected: "0,4 m / s^2", actual: a.ToString());

            var v_final = v_initial + a * t;
            Console.WriteLine("The final velocity is " + v_final); // 24 m/s
            Assert.Equal(expected: "24 m/s", actual: v_final.ToString());
        }

        [Fact]
        public void Test10()
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

            Console.WriteLine("v^2 = " + strike_velocity_squared); // v^2 = 3758,2000000000003 (m/s)^2
            Assert.Equal(expected: 3758.2, actual: strike_velocity_squared.GetInSquareMeterPerSquareSecond(), tolerance: 0.01);

            var strike_velocity = -strike_velocity_squared.SquareRoot();

            Console.WriteLine("v = " + strike_velocity + " (downward motion)"); // v = -61,30415972835775 m/s (downward motion)
            Assert.Equal(expected: -61.3, actual: strike_velocity.GetInMeterPerSecond(), tolerance: 0.01);
        }

        [Fact]
        public void Test11()
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
            Assert.Equal(expected: 17, actual: time.GetInSeconds(), tolerance: 1);

            Console.WriteLine("(b)");

            var speed_car = acceleration_car * time;
            Console.WriteLine("speed_car = " + speed_car); // 24 m/s
            Assert.Equal(expected: 24, actual: speed_car.GetInMeterPerSecond(), tolerance: 1);

            Console.WriteLine("(c)");

            var distance_car = acceleration_car * 0.5 * time.Square();
            Console.WriteLine("distance_car = " + distance_car); // 205 m
            Assert.Equal(expected: 204, distance_car.GetInMeter(), tolerance: 10);
        }
    }
}