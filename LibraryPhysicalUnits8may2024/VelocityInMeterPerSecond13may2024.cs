namespace LibraryPhysicalUnits8may2024
{
    public class VelocityInMeterPerSecond13may2024 : IVelocity6apr2024
    {
        private double m_VelocityInMeterPerSecond;
        private double m_PrecisionInMeterPerSecond;

        public override string ToString()
        {
            return m_VelocityInMeterPerSecond + " m/s";
        }

        public VelocityInMeterPerSecond13may2024(double velocityInMeterPerSecond, double precisionInMeterPerSecond = 0)
        {
            m_VelocityInMeterPerSecond = velocityInMeterPerSecond;
            m_PrecisionInMeterPerSecond = precisionInMeterPerSecond;
        }

        public double GetInMeterPerSecond()
        {
            return m_VelocityInMeterPerSecond;
        }

        public double GetInKilometerPerHour()
        {
            return VelocityCalculation9may2024.ConvertMeterPerSecondIntoKilometerPerHour(m_VelocityInMeterPerSecond);
        }

        public double GetPrecisionInMeterPerSecond()
        {
            return m_PrecisionInMeterPerSecond;
        }

        public double GetPrecisionInKilometerPerHour()
        {
            return VelocityCalculation9may2024.ConvertMeterPerSecondIntoKilometerPerHour(m_PrecisionInMeterPerSecond);
        }

        public static LengthInMeter8may2024 operator *(VelocityInMeterPerSecond13may2024 velocity1, ITime6apr2024 time2)
        {
            var result = LengthCalculation9may2024.Multiply(velocity1, time2);
            return result;
        }

        public static LengthInMeter8may2024 operator *(ITime6apr2024 time1, VelocityInMeterPerSecond13may2024 velocity2)
        {
            var result = LengthCalculation9may2024.Multiply(time1, velocity2);
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator +(VelocityInMeterPerSecond13may2024 a, VelocityInMeterPerSecond13may2024 b)
        {
            var result = VelocityCalculation9may2024.Add(a, b);
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator -(VelocityInMeterPerSecond13may2024 a, VelocityInMeterPerSecond13may2024 b)
        {
            var result = VelocityCalculation9may2024.Substract(a, b);
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator *(double factor, VelocityInMeterPerSecond13may2024 b)
        {
            var result = new VelocityInMeterPerSecond13may2024(factor * b.GetInMeterPerSecond(), factor * b.GetPrecisionInMeterPerSecond());
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator *(VelocityInMeterPerSecond13may2024 a, double factor)
        {
            var result = new VelocityInMeterPerSecond13may2024(a.GetInMeterPerSecond() * factor, a.GetPrecisionInMeterPerSecond() * factor);
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator /(VelocityInMeterPerSecond13may2024 a, double factor)
        {
            var result = new VelocityInMeterPerSecond13may2024(a.GetInMeterPerSecond() / factor, a.GetPrecisionInMeterPerSecond() / factor);
            return result;
        }
    }
}
