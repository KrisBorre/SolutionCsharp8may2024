namespace LibraryPhysicalUnits8may2024.Test
{
    public class UnitTestTime13may2024
    {
        [Fact]
        public void Test1()
        {
            ITime6apr2024 time = new TimeInSeconds8may2024(5, 0);
            Assert.Equal(expected: 5, actual: time.GetInSeconds());
        }

        [Fact]
        public void Test2()
        {
            TimeInMilliseconds6apr2024 time = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time.GetInMilliseconds());
        }

        [Fact]
        public void Test3()
        {
            TimeInMilliseconds6apr2024 time = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time.GetInMilliseconds());
            Assert.Equal(expected: 0.002, actual: time.GetInSeconds());
        }

        [Fact]
        public void Test4()
        {
            ITime6apr2024 time = new TimeInSeconds8may2024(5, 0);
            Assert.Equal(expected: 5, actual: time.GetInSeconds());
            Assert.Equal(expected: 5000, actual: time.GetInMilliseconds());
        }

        [Fact]
        public void Test5()
        {
            ITime6apr2024 time = new TimeInSeconds8may2024(5, 1);
            Assert.Equal(expected: 5, actual: time.GetInSeconds(), tolerance: 1);
        }

        [Fact]
        public void Test6()
        {
            TimeInMilliseconds6apr2024 time = new TimeInMilliseconds6apr2024(2, 0.1);
            Assert.Equal(expected: 2, actual: time.GetInMilliseconds(), tolerance: 0.1);
        }

        [Fact]
        public void Test7()
        {
            ITime6apr2024 time = new TimeInSeconds8may2024(5, 1);
            Assert.Equal(expected: 5, actual: time.GetInSeconds(), tolerance: 1);
            Assert.Equal(expected: 5000, actual: time.GetInMilliseconds(), tolerance: 1000);
        }

        [Fact]
        public void Test8()
        {
            ITime6apr2024 time1 = new TimeInSeconds8may2024(5, 0);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation13may2024.Add(time1, time2);

            Assert.Equal(expected: 5002, actual: totalTime.GetInMilliseconds(), tolerance: 1);
        }

        [Fact]
        public void Test9()
        {
            ITime6apr2024 time1 = new TimeInSeconds8may2024(5, 0);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation13may2024.Add(time1, time2);

            Assert.Equal(expected: 5.002, actual: totalTime.GetInSeconds(), tolerance: 0.001);
        }

        [Fact]
        public void Test10()
        {
            ITime6apr2024 time1 = new TimeInMilliseconds6apr2024(5, 0);
            Assert.Equal(expected: 0.005, actual: time1.GetInSeconds());

            ITime6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation13may2024.Add(time1, time2);

            Assert.Equal(expected: 0.007, actual: totalTime.GetInSeconds(), tolerance: 0.001);
        }

        [Fact]
        public void Test11()
        {
            ITime6apr2024 time1 = new TimeInSeconds8may2024(5, 1);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0.1);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation13may2024.Add(time1, time2);

            Assert.Equal(expected: 5002, actual: totalTime.GetInMilliseconds(), tolerance: 1500);
        }

        [Fact]
        public void Test12()
        {
            ITime6apr2024 time1 = new TimeInSeconds8may2024(5, 0.1);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 1);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation13may2024.Add(time1, time2);

            Assert.Equal(expected: 5.002, actual: totalTime.GetInSeconds(), tolerance: 0.15);
        }

        [Fact]
        public void Test13()
        {
            ITime6apr2024 time1 = new TimeInMilliseconds6apr2024(5, 0.002);
            Assert.Equal(expected: 0.005, actual: time1.GetInSeconds());

            ITime6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation13may2024.Add(time1, time2);

            Assert.Equal(expected: 0.007, actual: totalTime.GetInSeconds(), tolerance: 0.002);
        }

        [Fact]
        public void Test14()
        {
            double time1 = 5;
            double time2 = TimeCalculation13may2024.ConvertMillisecondsIntoSeconds(time1);
            Assert.Equal(expected: 0.005, actual: time2);
        }


        [Fact]
        public void Test15()
        {
            double time1 = 5;
            double time2 = TimeCalculation13may2024.ConvertSecondsIntoMilliseconds(time1);
            Assert.Equal(expected: 5000, actual: time2);
        }


        [Fact]
        public void Test16()
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);
        }


        [Fact]
        public void Test17()
        {
            double time1 = 3600;
            double time2 = TimeCalculation13may2024.ConvertSecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test18()
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertMinutesIntoSeconds(time1);
            Assert.Equal(expected: 60, actual: time2);
        }

        [Fact]
        public void Test19()
        {
            double time1 = 60;
            double time2 = TimeCalculation13may2024.ConvertSecondsIntoMinutes(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test20()
        {
            double time1 = 60000;
            double time2 = TimeCalculation13may2024.ConvertMillisecondsIntoMinutes(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test21()
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertMinutesIntoMilliseconds(time1);
            Assert.Equal(expected: 60000, actual: time2);
        }

        [Fact]
        public void Test22()
        {
            double time1 = 60;
            double time2 = TimeCalculation13may2024.ConvertMinutesIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test23()
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertHoursIntoMinutes(time1);
            Assert.Equal(expected: 60, actual: time2);
        }

        [Fact]
        public void Test24()
        {
            double time1 = 1;
            double time2 = TimeCalculation13may2024.ConvertHoursIntoMilliseconds(time1);
            Assert.Equal(expected: 3600000, actual: time2);
        }

        [Fact]
        public void Test25()
        {
            double time1 = 3600000;
            double time2 = TimeCalculation13may2024.ConvertMillisecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Theory]
        [InlineData(5, 2, 5.002)]
        [InlineData(5000, 2000, 5002)]
        [InlineData(2, 7, 2.007)]
        public void Test26(double input1, double input2, double expected)
        {
            ITime6apr2024 time1 = new TimeInSeconds8may2024(input1, 0);
            Assert.Equal(expected: input1, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(input2, 0);
            Assert.Equal(expected: input2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation13may2024.Add(time1, time2);

            Assert.Equal(expected: expected, actual: totalTime.GetInSeconds(), tolerance: 0.001);
        }

        [Theory]
        [InlineData(3_600_000, 1)]
        [InlineData(900_000, 0.25)]
        public void Test27(double input, double expected)
        {
            double time1 = input;
            double time2 = TimeCalculation13may2024.ConvertMillisecondsIntoHours(time1);
            Assert.Equal(expected: expected, actual: time2);
        }

        [Fact]
        public void Test28()
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
            Assert.Equal(expected: 5.4, actual: time.GetInSeconds(), tolerance: 0.1);

            var acceleration = acceleration_multiplied_by_time / time;
            Console.WriteLine("The acceleration is " + acceleration); // 2,5999999999999996 m / s^2
            Assert.Equal(expected: 2.6, actual: acceleration.GetInMeterPerSecondSquared(), tolerance: 0.01);
        }

        [Fact]
        public void Test29()
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 50");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Oefening 19");

            Console.WriteLine("Een bowlingbal die met constante snelheid rolt raakt de kegels aan het einde van een bowlingbaan van 16,5 m lang.");
            Console.WriteLine("De bowler hoort het geluid van de bal die de kegels raakt 2,50 s nadat hij de bal heeft losgelaten.");
            Console.WriteLine("Wat is de snelheid van de bal, aangenomen dat de geluidsnelheid 340 m/s is?");

            var s = new LengthInMeter8may2024(16.5, 0);
            var v = new VelocityInMeterPerSecond13may2024(340, 0);

            var tijd_geluid = s / v;
            Console.WriteLine("Tijd die het geluid nodig heeft is " + tijd_geluid); // 0,04852941176470588 s
            Assert.Equal(expected: 0.0485, actual: tijd_geluid.GetInSeconds(), tolerance: 0.001);

            var totale_tijd = new TimeInSeconds8may2024(2.50, 0.01);
            var tijd = totale_tijd - tijd_geluid;

            Console.WriteLine("Tijd is " + tijd); // 2,4514705882352943 s
            Assert.Equal(expected: 2.45147, actual: tijd.GetInSeconds(), tolerance: 0.001);

            var snelheid_van_de_bal = s / tijd;
            Console.WriteLine("De snelheid van de bal is " + snelheid_van_de_bal); // 6,730653869226154 m/s
            Assert.Equal(expected: 6.7306, actual: snelheid_van_de_bal.GetInMeterPerSecond(), tolerance: 0.001);
            // 6,73 m/s
        }

        [Fact]
        public void Test30()
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
            Assert.Equal(expected: 3.55, actual: velocity_1.GetInMeterPerSecond(), tolerance: 0.01);

            var t_1 = velocity_1 / g;

            var x_1 = (g * t_1.Square()) / 2;

            Console.WriteLine("x_1 = " + x_1);
            // x_1 = 0,6414248853211008 m
            Assert.Equal(expected: 0.64, actual: x_1.GetInMeter(), tolerance: 0.01);
        }

        [Fact]
        public void Test31()
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
            Assert.Equal(expected: 7, actual: brake_time.GetInSeconds(), tolerance: 0.1);

            var brake_distance = speed_initial * brake_time + (acceleration * brake_time.Square()) / 2.0;

            Console.WriteLine("brake_distance = " + brake_distance); // 73.5 m
            Assert.Equal(expected: 73.5, actual: brake_distance.GetInMeter(), tolerance: 0.1);

            var distance_moved_before_braking = distance_from_stationary_car - brake_distance;
            Console.WriteLine("distance_moved_before_braking = " + distance_moved_before_braking); // 36.5 m
            Assert.Equal(expected: 36.5, actual: distance_moved_before_braking.GetInMeter(), tolerance: 0.1);

            var maximum_allowable_delta_t = distance_moved_before_braking / speed_initial;
            Console.WriteLine("maximum_allowable_delta_t = " + maximum_allowable_delta_t); // 1.74 s
            Assert.Equal(expected: 1.74, actual: maximum_allowable_delta_t.GetInSeconds(), tolerance: 0.1);

            Console.WriteLine("(b)");

            var reaction_time = new TimeInSeconds8may2024(1.4, 0);

            var reaction_distance = reaction_time * speed_initial;

            Console.WriteLine("reaction_distance = " + reaction_distance); // 29.4 m
            Assert.Equal(expected: 29.4, reaction_distance.GetInMeter(), tolerance: 0.1);

            var new_distance_from_stationary_car = distance_from_stationary_car - reaction_distance;

            Console.WriteLine("new_distance_from_stationary_car = " + new_distance_from_stationary_car); // 80.6 m
            Assert.Equal(expected: 80.6, actual: new_distance_from_stationary_car.GetInMeter(), tolerance: 0.1);

            var distance_from_car = new_distance_from_stationary_car - brake_distance;

            Console.WriteLine("distance_from_car = " + distance_from_car); // 7.1 m
            Assert.Equal(expected: 7.1, actual: distance_from_car.GetInMeter(), tolerance: 0.1);

            Console.WriteLine("The truck stops at a distance of 7.1 meters from the stationary car.");

            var time_between_seen_the_car_and_stopping = reaction_time + brake_time;

            Console.WriteLine("time_between_seen_the_car_and_stopping = " + time_between_seen_the_car_and_stopping); // 8.4 s
            Assert.Equal(expected: 8.4, actual: time_between_seen_the_car_and_stopping.GetInSeconds(), tolerance: 0.1);
        }

    }
}
