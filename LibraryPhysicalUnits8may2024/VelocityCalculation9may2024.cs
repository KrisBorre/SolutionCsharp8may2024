namespace LibraryPhysicalUnits8may2024
{
    public class VelocityCalculation9may2024
    {
        public static double ConvertKilometerPerHourIntoMeterPerSecond(double velocity)
        {
            return velocity / 3.6;
        }

        public static double ConvertMeterPerSecondIntoKilometerPerHour(double velocity)
        {
            return velocity * 3.6;
        }

        /// <summary>
        /// Precondition: velocity1 and velocity2 are independently measured
        /// </summary>
        /// <param name="velocity1"></param>
        /// <param name="velocity2"></param>
        /// <returns></returns>
        public static VelocityInMeterPerSecond13may2024 Add(IVelocity6apr2024 velocity1, IVelocity6apr2024 velocity2)
        {
            double result = velocity1.GetInMeterPerSecond() + velocity2.GetInMeterPerSecond();
            double accuracy = Math.Sqrt(Math.Pow(velocity1.GetPrecisionInMeterPerSecond(), 2) + Math.Pow(velocity2.GetPrecisionInMeterPerSecond(), 2));
            return new VelocityInMeterPerSecond13may2024(result, accuracy);
        }

        public static VelocityInMeterPerSecond13may2024 Substract(IVelocity6apr2024 velocity1, IVelocity6apr2024 velocity2)
        {
            double result = velocity1.GetInMeterPerSecond() - velocity2.GetInMeterPerSecond();
            double accuracy = Math.Sqrt(Math.Pow(velocity1.GetPrecisionInMeterPerSecond(), 2) + Math.Pow(velocity2.GetPrecisionInMeterPerSecond(), 2));
            return new VelocityInMeterPerSecond13may2024(result, accuracy);
        }

        public static VelocityInMeterPerSecond13may2024 Divide(ILength14feb2024 length1, ITime6apr2024 time2)
        {
            double result = length1.GetInMeter() / time2.GetInSeconds();
            double first = length1.GetPrecisionInMeter() / time2.GetInSeconds();
            double second = (time2.GetPrecisionInSeconds() * length1.GetInMeter()) / Math.Pow(time2.GetInSeconds(), 2);
            double accuracy = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2));
            return new VelocityInMeterPerSecond13may2024(result, accuracy);
        }

        public static VelocityInMeterPerSecond13may2024 Multiply(IAcceleration acceleration1, ITime6apr2024 time2)
        {
            double result = acceleration1.GetInMeterPerSecondSquared() * time2.GetInSeconds();
            double accuracy = Math.Sqrt(Math.Pow(acceleration1.GetPrecisionInMeterPerSecondSquared() * time2.GetInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds() * acceleration1.GetInMeterPerSecondSquared(), 2));
            return new VelocityInMeterPerSecond13may2024(result, accuracy);
        }
    }
}
