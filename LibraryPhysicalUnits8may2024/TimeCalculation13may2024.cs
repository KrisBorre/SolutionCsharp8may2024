namespace LibraryPhysicalUnits8may2024
{
    public static class TimeCalculation13may2024
    {
        public static double ConvertMillisecondsIntoSeconds(double time)
        {
            return time / 1000.0;
        }

        public static double ConvertSecondsIntoMilliseconds(double time)
        {
            return time * 1000.0;
        }

        public static double ConvertHoursIntoSeconds(double time)
        {
            return time * 3600.0;
        }

        public static double ConvertSecondsIntoHours(double time)
        {
            return time / 3600.0;
        }

        public static double ConvertSecondsIntoMinutes(double time)
        {
            return time / 60.0;
        }

        public static double ConvertMinutesIntoSeconds(double time)
        {
            return time * 60.0;
        }

        public static double ConvertMinutesIntoMilliseconds(double time)
        {
            return time * 60000.0;
        }

        public static double ConvertMillisecondsIntoMinutes(double time)
        {
            return time / 60000.0;
        }

        public static double ConvertHoursIntoMinutes(double time)
        {
            return time * 60.0;
        }

        public static double ConvertMinutesIntoHours(double time)
        {
            return time / 60.0;
        }

        public static double ConvertMillisecondsIntoHours(double time)
        {
            return time / 3600000.0;
        }

        public static double ConvertHoursIntoMilliseconds(double time)
        {
            return time * 3600000.0;
        }

        public static TimeInSeconds8may2024 Add(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double result = time1.GetInSeconds() + time2.GetInSeconds();
            double accuracy = Math.Sqrt(Math.Pow(time1.GetPrecisionInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds(), 2));
            return new TimeInSeconds8may2024(result, accuracy);
        }

        public static TimeInSeconds8may2024 Substract(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double result = time1.GetInSeconds() - time2.GetInSeconds();
            double accuracy = Math.Sqrt(Math.Pow(time1.GetPrecisionInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds(), 2));
            return new TimeInSeconds8may2024(result, accuracy);
        }

        public static TimeInSeconds8may2024 Divide(ILength14feb2024 length1, IVelocity6apr2024 velocity2)
        {
            double result = length1.GetInMeter() / velocity2.GetInMeterPerSecond();
            double first = length1.GetPrecisionInMeter() / velocity2.GetInMeterPerSecond();
            double second = (velocity2.GetPrecisionInMeterPerSecond() * length1.GetInMeter()) / Math.Pow(velocity2.GetInMeterPerSecond(), 2);
            double accuracy = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2));
            return new TimeInSeconds8may2024(result, accuracy);
        }

        public static TimeInSeconds8may2024 Divide(IVelocity6apr2024 velocity1, IAcceleration acceleration2)
        {
            double result = velocity1.GetInMeterPerSecond() / acceleration2.GetInMeterPerSecondSquared();
            return new TimeInSeconds8may2024(result, 0);
        }
    }
}
