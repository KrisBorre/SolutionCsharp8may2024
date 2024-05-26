namespace LibraryPhysicalUnits8may2024
{
    public static class VelocitySquaredCalculation18may2024
    {
        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 Add(IVelocitySquared18may2024 velocitySquared1, IVelocitySquared18may2024 velocitySquared2)
        {
            double result = velocitySquared1.GetInSquareMeterPerSquareSecond() + velocitySquared2.GetInSquareMeterPerSquareSecond();
            double accuracy = Math.Sqrt(Math.Pow(velocitySquared1.GetPrecisionInSquareMeterPerSquareSecond(), 2) + Math.Pow(velocitySquared2.GetPrecisionInSquareMeterPerSquareSecond(), 2));
            return new VelocitySquaredInSquareMeterPerSquareSecond18may2024(result, accuracy);
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 Substract(IVelocitySquared18may2024 velocitySquared1, IVelocitySquared18may2024 velocitySquared2)
        {
            double result = velocitySquared1.GetInSquareMeterPerSquareSecond() - velocitySquared2.GetInSquareMeterPerSquareSecond();
            double accuracy = Math.Sqrt(Math.Pow(velocitySquared1.GetPrecisionInSquareMeterPerSquareSecond(), 2) + Math.Pow(velocitySquared2.GetPrecisionInSquareMeterPerSquareSecond(), 2));
            return new VelocitySquaredInSquareMeterPerSquareSecond18may2024(result, accuracy);
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 Multiply(IVelocity6apr2024 velocity1, IVelocity6apr2024 velocity2)
        {
            double result = velocity1.GetInMeterPerSecond() * velocity2.GetInMeterPerSecond();
            double accuracy = Math.Sqrt(Math.Pow(velocity1.GetPrecisionInMeterPerSecond() * velocity2.GetInMeterPerSecond(), 2) + Math.Pow(velocity2.GetPrecisionInMeterPerSecond() * velocity1.GetInMeterPerSecond(), 2));
            return new VelocitySquaredInSquareMeterPerSquareSecond18may2024(result, accuracy);
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 Multiply(IAcceleration acceleration1, ILength14feb2024 length2)
        {
            double result = acceleration1.GetInMeterPerSecondSquared() * length2.GetInMeter();
            double accuracy = Math.Sqrt(Math.Pow(acceleration1.GetPrecisionInMeterPerSecondSquared() * length2.GetInMeter(), 2) + Math.Pow(length2.GetPrecisionInMeter() * acceleration1.GetPrecisionInMeterPerSecondSquared(), 2));
            return new VelocitySquaredInSquareMeterPerSquareSecond18may2024(result, accuracy);
        }
    }
}
