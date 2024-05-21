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
    }
}