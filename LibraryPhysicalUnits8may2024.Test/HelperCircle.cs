namespace LibraryPhysicalUnits8may2024.Test
{
    internal class HelperCircle
    {
        public static AreaInSquareMeter8may2024 Square(LengthInMeter8may2024 x)
        {
            return x * x;
        }

        public static LengthInMeter8may2024 CalculateRadius(LengthInMeter8may2024 diameter)
        {
            return diameter / 2;
        }

        // https://en.wikipedia.org/wiki/Circumference
        public static LengthInMeter8may2024 CalculateCircumference(LengthInMeter8may2024 diameter)
        {
            return 2 * Math.PI * CalculateRadius(diameter);
        }

        // https://en.wikipedia.org/wiki/Circle
        public static AreaInSquareMeter8may2024 CalculateArea(LengthInMeter8may2024 diameter)
        {
            return Math.PI * Square(CalculateRadius(diameter));
        }
    }
}
