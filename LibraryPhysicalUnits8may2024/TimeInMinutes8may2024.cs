namespace LibraryPhysicalUnits8may2024
{
    public class TimeInMinutes8may2024 : ITime6apr2024
    {
        private double m_TimeInMinutes;
        private double m_PrecisionInMinutes;

        public TimeInMinutes8may2024(double timeInMinutes, double accuracyInMinutes)
        {
            m_TimeInMinutes = timeInMinutes;
            m_PrecisionInMinutes = accuracyInMinutes;
        }

        public double GetInMinutes()
        {
            return m_TimeInMinutes;
        }

        public double GetInSeconds()
        {
            return TimeCalculation13may2024.ConvertMinutesIntoSeconds(m_TimeInMinutes);
        }

        public double GetInMilliseconds()
        {
            return TimeCalculation13may2024.ConvertMinutesIntoMilliseconds(m_TimeInMinutes);
        }

        public double GetInHours()
        {
            return TimeCalculation13may2024.ConvertMinutesIntoHours(m_TimeInMinutes);
        }

        public double GetPrecisionInMinutes()
        {
            return m_PrecisionInMinutes;
        }

        public double GetPrecisionInSeconds()
        {
            return TimeCalculation13may2024.ConvertMinutesIntoSeconds(m_PrecisionInMinutes);
        }

        public double GetPrecisionInMilliseconds()
        {
            return TimeCalculation13may2024.ConvertMinutesIntoMilliseconds(m_PrecisionInMinutes);
        }

        public double GetPrecisionInHours()
        {
            return TimeCalculation13may2024.ConvertMinutesIntoHours(m_PrecisionInMinutes);
        }

        public override string ToString()
        {
            return m_TimeInMinutes + " min";
        }

        public static TimeInSeconds8may2024 operator +(TimeInMinutes8may2024 a, TimeInMinutes8may2024 b)
        {
            var result = TimeCalculation13may2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds8may2024 operator +(TimeInSeconds8may2024 a, TimeInMinutes8may2024 b)
        {
            var result = TimeCalculation13may2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds8may2024 operator +(TimeInMinutes8may2024 a, TimeInSeconds8may2024 b)
        {
            var result = TimeCalculation13may2024.Add(a, b);
            return result;
        }
    }
}
