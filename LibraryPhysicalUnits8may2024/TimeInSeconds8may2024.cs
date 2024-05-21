namespace LibraryPhysicalUnits8may2024
{
    public class TimeInSeconds8may2024 : ITime6apr2024
    {
        private double m_TimeInSeconds;
        private double m_PrecisionInSeconds;

        public TimeInSeconds8may2024(double timeInSeconds, double accuracyInSeconds)
        {
            m_TimeInSeconds = timeInSeconds;
            m_PrecisionInSeconds = accuracyInSeconds;
        }

        public double GetInSeconds()
        {
            return m_TimeInSeconds;
        }

        public double GetInMilliseconds()
        {
            return TimeCalculation13may2024.ConvertSecondsIntoMilliseconds(m_TimeInSeconds);
        }

        public double GetInMinutes()
        {
            return TimeCalculation13may2024.ConvertSecondsIntoMinutes(m_TimeInSeconds);
        }

        public double GetInHours()
        {
            return TimeCalculation13may2024.ConvertSecondsIntoHours(m_TimeInSeconds);
        }

        public double GetPrecisionInSeconds()
        {
            return m_PrecisionInSeconds;
        }

        public double GetPrecisionInMilliseconds()
        {
            return TimeCalculation13may2024.ConvertSecondsIntoMilliseconds(m_PrecisionInSeconds);
        }

        public double GetPrecisionInHours()
        {
            return TimeCalculation13may2024.ConvertSecondsIntoHours(m_PrecisionInSeconds);
        }

        public override string ToString()
        {
            return m_TimeInSeconds + " s";
        }

        public static TimeInSeconds8may2024 operator +(TimeInSeconds8may2024 a, ITime6apr2024 b)
        {
            var result = TimeCalculation13may2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds8may2024 operator -(TimeInSeconds8may2024 a, ITime6apr2024 b)
        {
            var result = TimeCalculation13may2024.Substract(a, b);
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator /(LengthInKilometer8may2024 length1, TimeInSeconds8may2024 time2)
        {
            var result = VelocityCalculation9may2024.Divide(length1: length1, time2: time2);
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator /(VelocityInMeterPerSecond13may2024 velocity1, TimeInSeconds8may2024 time2)
        {
            var result = AccelerationCalculation9may2024.Divide(velocity1: velocity1, time2: time2);
            return result;
        }
    }
}
