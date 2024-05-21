namespace LibraryPhysicalUnits8may2024
{
    // https://en.wikipedia.org/wiki/Category:Units_of_area
    public class AreaCalculation8may2024
    {
        public static double ConvertSquareMeterIntoSquareKilometer(double length)
        {
            return length / 1000000;
        }

        public static double ConvertSquareKilometerIntoSquareMeter(double length)
        {
            return length * 1000000;
        }

        public static double ConvertSquareMeterIntoSquareCentimeter(double length)
        {
            return length * 10000;
        }

        public static double ConvertSquareCentimeterIntoSquareMeter(double length)
        {
            return length / 10000;
        }

        public static AreaInSquareMeter8may2024 Add(IArea8may2024 area1, IArea8may2024 area2)
        {
            double result = area1.GetInSquareMeter() + area2.GetInSquareMeter();
            double accuracy = Math.Sqrt(Math.Pow(area1.GetPrecisionInSquareMeter(), 2) + Math.Pow(area2.GetPrecisionInSquareMeter(), 2));
            return new AreaInSquareMeter8may2024(result, accuracy);
        }

        public static AreaInSquareMeter8may2024 Substract(IArea8may2024 area1, IArea8may2024 area2)
        {
            double result = area1.GetInSquareMeter() - area2.GetInSquareMeter();
            double accuracy = Math.Sqrt(Math.Pow(area1.GetPrecisionInSquareMeter(), 2) + Math.Pow(area2.GetPrecisionInSquareMeter(), 2));
            return new AreaInSquareMeter8may2024(result, accuracy);
        }

        public static AreaInSquareMeter8may2024 Multiply(ILength14feb2024 length1, ILength14feb2024 length2)
        {
            double result = length1.GetInMeter() * length2.GetInMeter();
            double accuracy = Math.Sqrt(Math.Pow(length1.GetPrecisionInMeter() * length2.GetInMeter(), 2) + Math.Pow(length2.GetPrecisionInMeter() * length1.GetInMeter(), 2));
            return new AreaInSquareMeter8may2024(result, accuracy);
        }
    }
}
