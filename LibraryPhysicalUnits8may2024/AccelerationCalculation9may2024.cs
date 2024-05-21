namespace LibraryPhysicalUnits8may2024
{
    public class AccelerationCalculation9may2024
    {
        public static AccelerationInMeterPerSecondSquared17may2024 Add(IAcceleration acceleration1, IAcceleration acceleration2)
        {
            double result = acceleration1.GetInMeterPerSecondSquared() + acceleration2.GetInMeterPerSecondSquared();
            double accuracy = Math.Sqrt(Math.Pow(acceleration1.GetPrecisionInMeterPerSecondSquared(), 2) + Math.Pow(acceleration2.GetPrecisionInMeterPerSecondSquared(), 2));
            return new AccelerationInMeterPerSecondSquared17may2024(result, accuracy);
        }

        public static AccelerationInMeterPerSecondSquared17may2024 Substract(IAcceleration acceleration1, IAcceleration acceleration2)
        {
            double result = acceleration1.GetInMeterPerSecondSquared() - acceleration2.GetInMeterPerSecondSquared();
            double accuracy = Math.Sqrt(Math.Pow(acceleration1.GetPrecisionInMeterPerSecondSquared(), 2) + Math.Pow(acceleration2.GetPrecisionInMeterPerSecondSquared(), 2));
            return new AccelerationInMeterPerSecondSquared17may2024(result, accuracy);
        }

        public static AccelerationInMeterPerSecondSquared17may2024 Divide(IVelocity6apr2024 velocity1, ITime6apr2024 time2)
        {
            double result = velocity1.GetInMeterPerSecond() / time2.GetInSeconds();
            double first = velocity1.GetPrecisionInMeterPerSecond() / time2.GetInSeconds();
            double second = (time2.GetPrecisionInSeconds() * velocity1.GetInMeterPerSecond()) / Math.Pow(time2.GetInSeconds(),2);
            double accuracy = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2));
            return new AccelerationInMeterPerSecondSquared17may2024(result, accuracy);
        }
    }
}
