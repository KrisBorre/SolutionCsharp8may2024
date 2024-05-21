namespace LibraryPhysicalUnits8may2024.Test
{
    public class UnitTestArea8may2024
    {
        [Fact]
        public void Test1()
        {
            IArea8may2024 area = new AreaInSquareMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: area.GetInSquareMeter());
            Assert.Equal(expected: 50000, actual: area.GetInSquareCentimeter());
        }

        [Fact]
        public void Test2()
        {
            AreaInSquareMeter8may2024 area = new AreaInSquareMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: area.GetInSquareMeter());
            Assert.Equal(expected: 50000, actual: area.GetInSquareCentimeter());
        }

        [Fact]
        public void Test3()
        {
            AreaInSquareCentimeter8may2024 area = new AreaInSquareCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: area.GetInSquareCentimeter());
        }

        [Fact]
        public void Test4()
        {
            AreaInSquareCentimeter8may2024 area = new AreaInSquareCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: area.GetInSquareCentimeter());
            Assert.Equal(expected: 0.0002, actual: area.GetInSquareMeter());
        }

        [Fact]
        public void Test5()
        {
            AreaInSquareMeter8may2024 area1 = new AreaInSquareMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: area1.GetInSquareMeter());
            Assert.Equal(expected: 50000, actual: area1.GetInSquareCentimeter());

            AreaInSquareCentimeter8may2024 area2 = new AreaInSquareCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: area2.GetInSquareCentimeter());
            Assert.Equal(expected: 0.0002, actual: area2.GetInSquareMeter());

            IArea8may2024 totalArea = AreaCalculation8may2024.Add(area1, area2);

            Assert.Equal(expected: 5.0002, actual: totalArea.GetInSquareMeter(), tolerance: 0.00001);
            Assert.Equal(expected: 50002, actual: totalArea.GetInSquareCentimeter(), tolerance: 0.00001);
        }

        [Fact]
        public void Test6()
        {
            AreaInSquareMeter8may2024 area = new AreaInSquareMeter8may2024(5, 0);
            var result = area.MultiplyBy(3);
            Assert.Equal(expected: 15, actual: result.GetInSquareMeter());
        }

        [Fact]
        public void Test7()
        {
            AreaInSquareMeter8may2024 area = new AreaInSquareMeter8may2024(5, 0);
            var result = area.MultiplyBy(3);
            Assert.Equal(expected: 150000, actual: result.GetInSquareCentimeter());
        }

        [Fact]
        public void Test8()
        {
            AreaInSquareMeter8may2024 area = new AreaInSquareMeter8may2024(5, 0);
            var result = area * 3;
            Assert.Equal(expected: 15, actual: result.GetInSquareMeter());
        }

        [Fact]
        public void Test9()
        {
            AreaInSquareMeter8may2024 area = new AreaInSquareMeter8may2024(5, 0);
            var result = 3 * area;
            Assert.Equal(expected: 15, actual: result.GetInSquareMeter());
        }

        [Fact]
        public void Test10()
        {
            AreaInSquareMeter8may2024 area = new AreaInSquareMeter8may2024(10, 0);
            var result = area.DivideBy(5);
            Assert.Equal(expected: 2, actual: result.GetInSquareMeter());
        }

        [Fact]
        public void Test11()
        {
            AreaInSquareMeter8may2024 area = new AreaInSquareMeter8may2024(10, 0);
            var result = area / 5;
            Assert.Equal(expected: 2, actual: result.GetInSquareMeter());
        }


        [Fact]
        public void Test12()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(3, 0);

            LengthInMeter8may2024 length2 = new LengthInMeter8may2024(4, 0);

            AreaInSquareMeter8may2024 result = length1 * length2;

            Assert.Equal(expected: 12, actual: result.GetInSquareMeter());
        }

        [Fact]
        public void Test13()
        {
            LengthInMeter8may2024 length1 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length1.GetInMeter());

            LengthInCentimeter8may2024 length2 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length2.GetInCentimeter());

            AreaInSquareMeter8may2024 result = length1 * length2;

            Assert.Equal(expected: 0.1, actual: result.GetInSquareMeter());
        }


        [Fact]
        public void Test14()
        {
            LengthInCentimeter8may2024 length1 = new LengthInCentimeter8may2024(2, 0);
            Assert.Equal(expected: 2, actual: length1.GetInCentimeter());
            Assert.Equal(expected: 0.02, actual: length1.GetInMeter());

            LengthInMeter8may2024 length2 = new LengthInMeter8may2024(5, 0);
            Assert.Equal(expected: 5, actual: length2.GetInMeter());
            Assert.Equal(expected: 500, actual: length2.GetInCentimeter());

            AreaInSquareMeter8may2024 result = length1 * length2;

            Assert.Equal(expected: 0.1, actual: result.GetInSquareMeter());
        }

        [Fact]
        public void Test15()
        {
            double x = 1;
            var lengthInMeter = new LengthInMeter8may2024(x, 0);
            var area = HelperCircle.CalculateArea(diameter: lengthInMeter);
            Assert.Equal(expected: 0.7853981633974483, actual: area.GetInSquareMeter(), tolerance: 0.000001);
        }

        [Fact]
        public void Test16()
        {
            double x = 0.35;
            var lengthInMeter = new LengthInMeter8may2024(x, 0);
            var area = HelperCircle.CalculateArea(diameter: lengthInMeter);
            Assert.Equal(expected: 0.09621127501618, actual: area.GetInSquareMeter(), tolerance: 0.000001);
        }

        [Theory]
        [InlineData(1, 0.7853981633974483)]
        [InlineData(0.35, 0.09621127501618)]
        public void Test17(double input, double expected)
        {
            double x = input;
            var lengthInMeter = new LengthInMeter8may2024(x, 0);
            var area = HelperCircle.CalculateArea(diameter: lengthInMeter);
            Assert.Equal(expected: expected, actual: area.GetInSquareMeter(), tolerance: 0.000001);
        }

        [Fact]
        public void Test18()
        {
            AreaInSquareKilometer8may2024 areaInSquareKilometer = new AreaInSquareKilometer8may2024(1, 0);
            AreaInSquareMeter8may2024 areaInSquareMeter = areaInSquareKilometer.ConvertToSquareMeter();
            Assert.Equal(expected: 1_000_000, actual: areaInSquareMeter.GetInSquareMeter());
        }

        [Fact]
        public void Test19()
        {
            AreaInSquareKilometer8may2024 areaInSquareKilometer = new AreaInSquareKilometer8may2024(1, 0);
            AreaInSquareMeter8may2024 areaInSquareMeter = areaInSquareKilometer.ConvertToSquareMeter();
            Assert.Equal(expected: 1, actual: areaInSquareMeter.GetInSquareKilometer());
        }

        [Fact]
        public void Test20()
        {
            AreaInSquareMeter8may2024 areaInSquareMeter = new AreaInSquareMeter8may2024(1, 0);
            AreaInSquareKilometer8may2024 areaInSquareKilometer = areaInSquareMeter.ConvertToSquareKilometer();
            Assert.Equal(expected: 1, actual: areaInSquareKilometer.GetInSquareMeter());
        }

        [Fact]
        public void Test21()
        {
            AreaInSquareMeter8may2024 areaInSquareMeter = new AreaInSquareMeter8may2024(1, 0);
            AreaInSquareKilometer8may2024 areaInSquareKilometer = areaInSquareMeter.ConvertToSquareKilometer();
            Assert.Equal(expected: 0.000001, actual: areaInSquareKilometer.GetInSquareKilometer());
        }

        [Fact]
        public void Test22()
        {
            LengthInKilometer8may2024 lengthInKilometer = new LengthInKilometer8may2024(2, 0);
            var areaInSquareKilometer = lengthInKilometer.Square();
            Assert.Equal(expected: 4, actual: areaInSquareKilometer.GetInSquareKilometer());
        }

        [Fact]
        public void Test23()
        {
            LengthInMeter8may2024 lengthInMeter = new LengthInMeter8may2024(3, 0);
            var areaInSquareMeter = lengthInMeter.Square();
            Assert.Equal(expected: 9, actual: areaInSquareMeter.GetInSquareMeter());
        }

        [Fact]
        public void Test24()
        {
            AreaInSquareKilometer8may2024 area = new AreaInSquareKilometer8may2024(2, 0);
            AreaInSquareKilometer8may2024 result = area * 3;
            Assert.Equal(expected: 6, actual: result.GetInSquareKilometer());
        }

        [Fact]
        public void Test25()
        {
            AreaInSquareKilometer8may2024 area = new AreaInSquareKilometer8may2024(2, 0);
            AreaInSquareKilometer8may2024 result = 3 * area;
            Assert.Equal(expected: 6, actual: result.GetInSquareKilometer());
        }

        [Fact]
        public void Test26()
        {
            AreaInSquareKilometer8may2024 area = new AreaInSquareKilometer8may2024(12, 0);
            AreaInSquareKilometer8may2024 result = area / 3;
            Assert.Equal(expected: 4, actual: result.GetInSquareKilometer());
        }

        [Fact]
        public void Test27()
        {
            AreaInSquareKilometer8may2024 area1 = new AreaInSquareKilometer8may2024(12, 0);
            AreaInSquareKilometer8may2024 area2 = new AreaInSquareKilometer8may2024(4, 0);
            Assert.Equal(expected: 3, actual: area1 / area2);
        }

        [Fact]
        public void Test28()
        {
            AreaInSquareMeter8may2024 area1 = new AreaInSquareMeter8may2024(8, 0);
            AreaInSquareMeter8may2024 area2 = new AreaInSquareMeter8may2024(4, 0);
            Assert.Equal(expected: 2, actual: area1 / area2);
        }

        [Fact]
        public void Test29()
        {
            Console.WriteLine("Natuurkunde - Giancoli - pagina 17");
            Console.WriteLine("Oefening 17");
            Console.WriteLine("De diameter van de maan is 3480 km.");
            Console.WriteLine("(a) Hoe groot is het buitenoppervlak van de maan.");
            Console.WriteLine("(b) Hoeveel keer groter is het buitenoppervlak van de Aarde?");

            var diameter_moon = new LengthInKilometer8may2024(3480, 0);
            var radius_moon = diameter_moon / 2;
            var surface_moon = 4 * Math.PI * radius_moon.Square();

            Console.WriteLine("Oppervlak van de maan is " + surface_moon); // 38_045_943,67.. km^2
            Assert.Equal(expected: 38_045_943.7, actual: surface_moon.GetInSquareKilometer(), tolerance: 1);

            var radius_earth = new LengthInMeter8may2024(6_500_000, 0);
            var surface_earth = 4 * Math.PI * radius_earth.Square();

            Console.WriteLine("Oppervlak van de aarde is " + surface_earth); // 530_929_158_456_675,06 m^2
            Assert.Equal(expected: 530_929_158, actual: surface_earth.GetInSquareKilometer(), tolerance: 1);

            double ratio = surface_earth / surface_moon;
            Console.WriteLine($"De oppervlak van de aarde is {ratio} keer groter dan de oppervlakte van de maan."); // 13,95
            Assert.Equal(expected: 14, actual: ratio, tolerance: 1);
        }
    }
}
