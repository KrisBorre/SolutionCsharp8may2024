namespace LibraryPhysicalUnits8may2024.Test
{
    public class UnitTestLength8may2024
    {
        [Fact]
        public void Test1()
        {
            ILength14feb2024 length = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length.GetInMeter());
        }

        [Fact]
        public void Test2()
        {
            LengthInCentimeter8may2024 length = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length.GetInCentimeter());
        }

        [Fact]
        public void Test3()
        {
            LengthInCentimeter8may2024 length = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length.GetInCentimeter());
            Assert.Equal(expected: 0.02, actual: length.GetInMeter());
        }

        [Fact]
        public void Test4()
        {
            ILength14feb2024 length = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length.GetInMeter());
            Assert.Equal(expected: 500, actual: length.GetInCentimeter());
        }

        [Fact]
        public void Test5()
        {
            ILength14feb2024 length = new LengthInMeter8may2024(5, 1);
            Assert.Equal(expected: 5, actual: length.GetInMeter(), tolerance: 1);
        }

        [Fact]
        public void Test6()
        {
            LengthInCentimeter8may2024 length = new LengthInCentimeter8may2024(2, 0.1);
            Assert.Equal(expected: 2, actual: length.GetInCentimeter(), tolerance: 0.1);
        }

        [Fact]
        public void Test7()
        {
            ILength14feb2024 length = new LengthInMeter8may2024(5, 1);
            Assert.Equal(expected: 5, actual: length.GetInMeter(), tolerance: 1);
            Assert.Equal(expected: 500, actual: length.GetInCentimeter(), tolerance: 100);
        }

        [Fact]
        public void Test8()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 502, actual: totalLength.GetInCentimeter(), tolerance: 1);
        }

        [Fact]
        public void Test9()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 5.02, actual: totalLength.GetInMeter(), tolerance: 0.01);
        }

        [Fact]
        public void Test10()
        {
            ILength14feb2024 length1 = new LengthInCentimeter8may2024(5, 0);
            Assert.Equal(expected: 0.05, actual: length1.GetInMeter());

            ILength14feb2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 0.07, actual: totalLength.GetInMeter(), tolerance: 0.01);
        }

        [Fact]
        public void Test11()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 1);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0.1);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 502, actual: totalLength.GetInCentimeter(), tolerance: 150);
        }

        [Fact]
        public void Test12()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 0.1);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 1);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 5.02, actual: totalLength.GetInMeter(), tolerance: 0.15);
        }

        [Fact]
        public void Test13()
        {
            ILength14feb2024 length1 = new LengthInCentimeter8may2024(5, 0.002);
            Assert.Equal(expected: 0.05, actual: length1.GetInMeter());

            ILength14feb2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 0.07, actual: totalLength.GetInMeter(), tolerance: 0.002);
        }

        [Fact]
        public void Test14()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 0);
            ILength14feb2024 result = lengthInMeter.MultiplyBy(20);
            Assert.Equal(expected: 100, actual: result.GetInMeter());
        }

        [Fact]
        public void Test15()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 0);
            LengthInMeter8may2024 result = lengthInMeter * 20;
            Assert.Equal(expected: 100, actual: result.GetInMeter());
        }

        [Fact]
        public void Test16()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 0);
            LengthInMeter8may2024 result = 20 * lengthInMeter;
            Assert.Equal(expected: 100, actual: result.GetInMeter());
        }

        [Fact]
        public void Test17()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 1);
            ILength14feb2024 result = lengthInMeter.MultiplyBy(20);
            Assert.Equal(expected: 100, actual: result.GetInMeter());
            Assert.Equal(expected: 20, actual: result.GetPrecisionInMeter());
        }

        [Fact]
        public void Test18()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 1);
            LengthInMeter8may2024 result = lengthInMeter * 20;
            Assert.Equal(expected: 100, actual: result.GetInMeter());
            Assert.Equal(expected: 20, actual: result.GetPrecisionInMeter());
        }

        [Fact]
        public void Test19()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 1);
            LengthInMeter8may2024 result = 20 * lengthInMeter;
            Assert.Equal(expected: 100, actual: result.GetInMeter());
            Assert.Equal(expected: 20, actual: result.GetPrecisionInMeter());
        }

        [Fact]
        public void Test20()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 0);
            LengthInMeter8may2024 result = lengthInMeter.DivideBy(5);
            Assert.Equal(expected: 1, actual: result.GetInMeter());
        }

        [Fact]
        public void Test21()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 0);
            LengthInMeter8may2024 result = lengthInMeter / 5;
            Assert.Equal(expected: 1, actual: result.GetInMeter());
        }

        [Fact]
        public void Test22()
        {
            //LengthInMeter lengthInMeter = new LengthInMeter(5, 0);
            // InvertedLengthInMeter result = 5 / lengthInMeter;
            //Assert.Equal(expected: 1, actual: result.GetInInvertedMeter());
        }

        [Fact]
        public void Test23()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 1);
            LengthInMeter8may2024 result = lengthInMeter.DivideBy(5);
            Assert.Equal(expected: 1, actual: result.GetInMeter());
            Assert.Equal(expected: 0.2, actual: result.GetPrecisionInMeter());
        }

        [Fact]
        public void Test24()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(5, 1);
            LengthInMeter8may2024 result = lengthInMeter / 5;
            Assert.Equal(expected: 1, actual: result.GetInMeter());
            Assert.Equal(expected: 0.2, actual: result.GetPrecisionInMeter());
        }

        [Fact]
        public void Test25()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = length1 + length2;

            Assert.Equal(expected: 502, actual: totalLength.GetInCentimeter(), tolerance: 1);
        }

        [Fact]
        public void Test26()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = length1 + length2;

            Assert.Equal(expected: 5.02, actual: totalLength.GetInMeter(), tolerance: 0.01);
        }

        [Fact]
        public void Test27()
        {
            LengthInCentimeter8may2024 length1 = new LengthInCentimeter8may2024(5, 0);
            Assert.Equal(expected: 0.05, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = length1 + length2;

            Assert.Equal(expected: 0.07, actual: totalLength.GetInMeter(), tolerance: 0.01);
        }

        [Fact]
        public void Test28()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 1);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0.1);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = length1 + length2;

            Assert.Equal(expected: 502, actual: totalLength.GetInCentimeter(), tolerance: 150);
        }


        [Fact]
        public void Test29()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0.1);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 1);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = length1 + length2;

            Assert.Equal(expected: 5.02, actual: totalLength.GetInMeter(), tolerance: 0.15);
        }

        [Fact]
        public void Test30()
        {
            LengthInCentimeter8may2024 length1 = new LengthInCentimeter8may2024(5, 0.002);
            Assert.Equal(expected: 0.05, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            ILength14feb2024 totalLength = length1 + length2;

            Assert.Equal(expected: 0.07, actual: totalLength.GetInMeter(), tolerance: 0.002);
        }

        [Fact]
        public void Test31()
        {
            double x = 1;
            var lengthInMeter = new LengthInMeter8may2024(x, 0);
            var radius = HelperCircle.CalculateRadius(diameter: lengthInMeter);
            Assert.Equal(expected: 0.5, actual: radius.GetInMeter());

            var circumferenceOfCircle = HelperCircle.CalculateCircumference(diameter: lengthInMeter);
            Assert.Equal(expected: 3.141592653589793, actual: circumferenceOfCircle.GetInMeter(), tolerance: 0.00001);
        }

        [Fact]
        public void Test32()
        {
            double x = 0.35;
            var lengthInMeter = new LengthInMeter8may2024(x, 0);
            var radius = HelperCircle.CalculateRadius(diameter: lengthInMeter);
            Assert.Equal(expected: 0.175, actual: radius.GetInMeter());

            var circumferenceOfCircle = HelperCircle.CalculateCircumference(diameter: lengthInMeter);
            Assert.Equal(expected: 1.0995574287564276, actual: circumferenceOfCircle.GetInMeter(), tolerance: 0.00001);
        }


        [Fact]
        public void Test33()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 502, actual: totalLength.GetInCentimeter(), tolerance: 1);
        }

        [Fact]
        public void Test34()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 5.02, actual: totalLength.GetInMeter(), tolerance: 0.01);
        }

        [Fact]
        public void Test35()
        {
            ILength14feb2024 length1 = new LengthInCentimeter8may2024(5, 0);
            Assert.Equal(expected: 0.05, actual: length1.GetInMeter());

            ILength14feb2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 0.07, actual: totalLength.GetInMeter(), tolerance: 0.01);
        }

        [Fact]
        public void Test36()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 1);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0.1);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 502, actual: totalLength.GetInCentimeter(), tolerance: 150);
        }

        [Fact]
        public void Test37()
        {
            ILength14feb2024 length1 = new LengthInMeter8may2024(5, 0.1);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 1);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 5.02, actual: totalLength.GetInMeter(), tolerance: 0.15);
        }

        [Fact]
        public void Test38()
        {
            ILength14feb2024 length1 = new LengthInCentimeter8may2024(5, 0.002);
            Assert.Equal(expected: 0.05, actual: length1.GetInMeter());

            ILength14feb2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 0.07, actual: totalLength.GetInMeter(), tolerance: 0.002);
        }

        [Fact]
        public void Test39()
        {
            LengthInCentimeter8may2024 length1 = new LengthInCentimeter8may2024(5, 0.002);
            Assert.Equal(expected: 0.05, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = length1 + length2;

            Assert.Equal(expected: 0.07, actual: totalLength.GetInMeter(), tolerance: 0.002);
        }

        [Fact]
        public void Test40()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0.002);
            Assert.Equal(expected: 5, actual: length1.GetInMeter(), tolerance: 0.01);

            LengthInMeter8may2024 length2 = new LengthInMeter8may2024(2, 0);
            Assert.Equal(expected: 200, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Add(length1, length2);

            Assert.Equal(expected: 7, actual: totalLength.GetInMeter(), tolerance: 0.02);
        }

        [Fact]
        public void Test41()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0.002);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInMeter8may2024 length2 = new LengthInMeter8may2024(2, 0);
            Assert.Equal(expected: 200, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = LengthCalculation9may2024.Substract(length1, length2);

            Assert.Equal(expected: 3, actual: totalLength.GetInMeter(), tolerance: 0.002);
        }

        [Fact]
        public void Test42()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0.002);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInMeter8may2024 length2 = new LengthInMeter8may2024(2, 0);
            Assert.Equal(expected: 200, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = length1 + length2;

            Assert.Equal(expected: 7, actual: totalLength.GetInMeter(), tolerance: 0.02);
        }

        [Fact]
        public void Test43()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0.002);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInMeter8may2024 length2 = new LengthInMeter8may2024(2, 0);
            Assert.Equal(expected: 200, actual: length2.GetInCentimeter());

            LengthInMeter8may2024 totalLength = length1 - length2;

            Assert.Equal(expected: 3, actual: totalLength.GetInMeter(), tolerance: 0.02);
        }

        [Fact]
        public void Test44()
        {
            var displacementInCentimeter = new LengthInCentimeter8may2024(0.5, 0);
            var displacementInMeter = displacementInCentimeter.GetInMeter();
            Assert.Equal(expected: 0.005, actual: displacementInMeter);
        }

        [Fact]
        public void Test45()
        {
            var displacementInMeter = new LengthInMeter8may2024(0.5, 0);
            var displacementInCentimeter = displacementInMeter.GetInCentimeter();
            Assert.Equal(expected: 50, actual: displacementInCentimeter);
        }

        [Fact]
        public void Test46()
        {
            double value1 = 5;
            double value2 = LengthCalculation9may2024.ConvertKilometerIntoMeter(value1);
            Assert.Equal(expected: 5000, actual: value2);
        }

        [Fact]
        public void Test47()
        {
            double value1 = 1000;
            double value2 = LengthCalculation9may2024.ConvertMeterIntoKilometer(value1);
            Assert.Equal(expected: 1, actual: value2);
        }

        [Theory]
        [InlineData(1, 0.5, 3.141592653589793)]
        [InlineData(0.35, 0.175, 1.0995574287564276)]
        public void Test48(double input, double expectedInMeter, double expectedCircumferenceOfCircle)
        {
            double x = input;
            var lengthInMeter = new LengthInMeter8may2024(x, 0);
            var radius = HelperCircle.CalculateRadius(diameter: lengthInMeter);
            Assert.Equal(expected: expectedInMeter, actual: radius.GetInMeter());

            var circumferenceOfCircle = HelperCircle.CalculateCircumference(diameter: lengthInMeter);
            Assert.Equal(expected: expectedCircumferenceOfCircle, actual: circumferenceOfCircle.GetInMeter(), tolerance: 0.00001);
        }

        [Fact]
        public void Test49()
        {
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Exercise 3.2");

            Console.WriteLine("An auto travels at a rate of 25 km/h for 4 min, then at 50 km/h for 8 min, and finally at 20 km/h for 2 min.");

            Console.WriteLine("Find (a) the total distance covered in kilometers and ");
            Console.WriteLine("     (b) the average speed for the complete trip in meters per second.");

            var t1 = new TimeInMinutes8may2024(4, 0);
            Console.WriteLine("t1 in hours = " + t1.GetInHours()); // 4 min = 0.0666 hours
            Assert.Equal(expected: 0.0666, actual: t1.GetInHours(), 0.0001);
            var v1 = new VelocityInKilometerPerHour6apr2024(25);
            var s1 = t1 * v1;
            Console.WriteLine("s1 in kilometer = " + s1.GetInKilometer());  // 1.666 km
            Assert.Equal(expected: 1.666, actual: s1.GetInKilometer(), 0.001);

            var t2 = new TimeInMinutes8may2024(8, 0);
            Console.WriteLine("t2 in hours = " + t2.GetInHours()); // 8 min = 0.1333 hours
            Assert.Equal(expected: 0.1333, actual: t2.GetInHours(), 0.0001);
            var v2 = new VelocityInKilometerPerHour6apr2024(50);
            var s2 = t2 * v2;
            Console.WriteLine("s2 in kilometer = " + s2.GetInKilometer());  // 6.666 km
            Assert.Equal(expected: 6.666, actual: s2.GetInKilometer(), 0.001);

            var t3 = new TimeInMinutes8may2024(2, 0);
            Console.WriteLine("t3 in hours = " + t3.GetInHours()); // 2 min = 0.0333 hours
            Assert.Equal(expected: 0.0333, actual: t3.GetInHours(), 0.0001);
            var v3 = new VelocityInKilometerPerHour6apr2024(20);
            var s3 = t3 * v3;
            Console.WriteLine("s3 in kilometer = " + s3.GetInKilometer());  // 0.666 km
            Assert.Equal(expected: 0.666, actual: s3.GetInKilometer(), 0.001);

            var d = s1 + s2 + s3;
            Console.WriteLine("The total distance in kilometer = " + d.GetInKilometer()); // 9 km
            Assert.Equal(expected: 9, actual: d.GetInKilometer(), 0.001);

            var time = t1 + t2 + t3;
            Console.WriteLine("The total time in hours = " + time.GetInHours()); // 0.233 hours
            Assert.Equal(expected: 0.233, actual: time.GetInHours(), 0.001);

            var v_average = d / time;
            Console.WriteLine("The average velocity in km per hours = " + v_average.GetInKilometerPerHour()); // 38.571 km/h
            Assert.Equal(expected: 38.571, actual: v_average.GetInKilometerPerHour(), 0.001);

            Console.WriteLine("The average velocity in meters per second =" + v_average.GetInMeterPerSecond()); // 10.714 m/s
            Assert.Equal(expected: 10.714, actual: v_average.GetInMeterPerSecond(), 0.001);
        }

        [Fact]
        public void Test50()
        {
            var s = new LengthInKilometer8may2024(10, 0);
            var t = new TimeInHours6apr2024(1, 0);
            var v = s / t;
            Assert.Equal(expected: 10, actual: v.GetInKilometerPerHour());
        }

        [Fact]
        public void Test51()
        {
            var lengthInMeter = new LengthInMeter8may2024(1, 0);
            var lengthInKilometer = lengthInMeter.ConvertToKilometer();
            Assert.Equal(expected: 1, actual: lengthInKilometer.GetInMeter());
        }

        [Fact]
        public void Test52()
        {
            var lengthInKilometer = new LengthInKilometer8may2024(1, 0);
            var lengthInMeter = lengthInKilometer.ConvertToMeter();
            Assert.Equal(expected: 1, actual: lengthInMeter.GetInKilometer());
        }

        [Fact]
        public void Test53()
        {
            var oneKilometer = new LengthInKilometer8may2024(1, 0);
            var thousandMeters = oneKilometer.ConvertToMeter();
            Assert.Equal(expected: 1000, actual: thousandMeters.GetInMeter());
        }

        [Fact]
        public void Test54()
        {
            var oneMeter = new LengthInMeter8may2024(1, 0);
            var lengthInKilometer = oneMeter.ConvertToKilometer();
            Assert.Equal(expected: 0.001, actual: lengthInKilometer.GetInKilometer());
        }

        [Fact]
        public void Test55()
        {
            var oneMeter = new LengthInMeter8may2024(1, 0);
            var lengthInCentimeter = oneMeter.ConvertToCentimeter();
            Assert.Equal(expected: 100, actual: lengthInCentimeter.GetInCentimeter());
        }

        [Fact]
        public void Test56()
        {
            var oneMeter = new LengthInMeter8may2024(1, 0);
            var lengthInCentimeter = oneMeter.ConvertToCentimeter();
            Assert.Equal(expected: 1, actual: lengthInCentimeter.GetInMeter());
        }

        [Fact]
        public void Test57()
        {
            var oneCentimeter = new LengthInCentimeter8may2024(1, 0);
            var lengthInMeter = oneCentimeter.ConvertToMeter();
            Assert.Equal(expected: 1, actual: lengthInMeter.GetInCentimeter());
        }

        [Fact]
        public void Test58()
        {
            var oneCentimeter = new LengthInCentimeter8may2024(1, 0);
            var lengthInMeter = oneCentimeter.ConvertToMeter();
            Assert.Equal(expected: 0.01, actual: lengthInMeter.GetInMeter());
        }

        [Fact]
        public void Test59()
        {
            LengthInKilometer8may2024 lengthInKilometer = new LengthInKilometer8may2024(5, 0);
            LengthInKilometer8may2024 result = lengthInKilometer / 5;
            Assert.Equal(expected: 1, actual: result.GetInKilometer());
        }

        [Fact]
        public void Test60()
        {
            Console.WriteLine("Natuurkunde - Giancoli");
            Console.WriteLine("Eenheden, standaarden, SI, eenheden omzetten, orde van grootte schatten.");
            Console.WriteLine("Oefening 33");

            Console.WriteLine("Het global positioning system (GPS) kan worden gebruikt voor zeer nauwkeurige plaatsbepalingen met behulp van satellieten.");
            Console.WriteLine("Als één van de satellieten 20 000 km van je verwijderd is, welke onnauwkeurigheidspercentage in de afstand hoort er dan bij een onnauwkeurigheid van 2 m?");
            Console.WriteLine("Hoeveel significante cijfers zijn er nodig in de afstand?");

            var length1 = new LengthInMeter8may2024(2, 0);
            var length2 = new LengthInKilometer8may2024(20_000, 0);

            var onnauwkeurigheidspercentage = length1 / length2;

            Console.WriteLine("onnauwkeurigheidspercentage = " + onnauwkeurigheidspercentage); // 1E-07
            // 10E-5 procent = 0.00001 %
            // acht significante cijfers.

            Assert.Equal(expected: 1E-07, actual: onnauwkeurigheidspercentage, tolerance: 1E-07);
        }

        [Fact]
        public void Test61()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 40");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.29");

            Console.WriteLine("The acceleration due to gravity at the surface of Mars is roughly 4 m/s^2");
            Console.WriteLine("If an astronaut on Mars were to toss a wrench upward with a speed of 10 m/s,");
            Console.WriteLine("find (a) how long it would rise;");
            Console.WriteLine("(b) how high it would go;");
            Console.WriteLine("(c) its speed at t = 3 s;");
            Console.WriteLine("and (d) its displacement at t = 3 s.");

            Console.WriteLine("Answersing:");
            Console.WriteLine("(a)");
            var g = new AccelerationInMeterPerSecondSquared17may2024(4);
            var velocity_initial = new VelocityInMeterPerSecond13may2024(10);
            var velocity_final = new VelocityInMeterPerSecond13may2024(0);
            var time_rise = (velocity_initial - velocity_final) / g;
            Console.WriteLine("t = " + time_rise + " is how long it would rise.");
            // t = 2,5 s is how long it would rise.
            Assert.Equal(expected: 2.5, actual: time_rise.GetInSeconds(), tolerance: 0.1);

            Console.WriteLine("(b)");
            var h = velocity_initial.Square() / (2 * g);
            Console.WriteLine("s_max = " + h + " is how high it would go.");
            // s_max = 12,5 m is how high it would go.
            Assert.Equal(expected: 12.5, actual: h.GetInMeter(), tolerance: 0.1);

            Console.WriteLine("(c)");
            var t = new TimeInSeconds8may2024(3, 0) - time_rise;
            var v_3 = g * t;
            Console.WriteLine("v_3 = " + v_3 + " is the speed downward after 3 seconds.");
            // v_3 = 2 m/s is the speed downward after 3 seconds.
            Assert.Equal(expected: 2, actual: v_3.GetInMeterPerSecond(), tolerance: 0.1);

            Console.WriteLine("(d)");
            var s_3 = (velocity_initial.Square() / 2 - v_3.Square() / 2) / g;
            Console.WriteLine("s_3 = " + s_3 + " is the displacement at t = 3 s");
            // s_3 = 12 m is the displacement at t = 3 s
            Assert.Equal(expected: 12, actual: s_3.GetInMeter(), tolerance: 0.1);
        }

        [Fact]
        public void Test62()
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
            Assert.Equal(expected: -13.6, actual: x_a.GetInMeter(), tolerance: 0.1);

            var t_b = new TimeInSeconds8may2024(0.25, 0);

            var x_b = velocity_initial * t_b - (g * t_b.Square()) / 2.0;
            Console.WriteLine("x_b = " + x_b);
            // x_b = 0,4434375 m
            Assert.Equal(expected: 0.44, actual: x_b.GetInMeter(), tolerance: 0.01);
        }
    }
}
