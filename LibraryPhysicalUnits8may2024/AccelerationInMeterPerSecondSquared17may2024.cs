namespace LibraryPhysicalUnits8may2024
{
    public class AccelerationInMeterPerSecondSquared17may2024 : IAcceleration
    {
        private double m_AccelerationInMeterPerSecondSquared;
        private double m_PrecisionInMeterPerSecondSquared;

        public AccelerationInMeterPerSecondSquared17may2024(double accelerationInMeterPerSecondSquared, double precisionInMeterPerSecondSquared = 0)
        {
            m_AccelerationInMeterPerSecondSquared = accelerationInMeterPerSecondSquared;
            m_PrecisionInMeterPerSecondSquared = precisionInMeterPerSecondSquared;
        }

        public double GetInMeterPerSecondSquared()
        {
            return m_AccelerationInMeterPerSecondSquared;
        }

        public double GetPrecisionInMeterPerSecondSquared()
        {
            return m_PrecisionInMeterPerSecondSquared;
        }

        public override string ToString()
        {
            return m_AccelerationInMeterPerSecondSquared + " m / s^2";
        }

        public static VelocityInMeterPerSecond13may2024 operator *(AccelerationInMeterPerSecondSquared17may2024 acceleration1, ITime6apr2024 time2)
        {
            var result = VelocityCalculation9may2024.Multiply(acceleration1, time2);
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator *(ITime6apr2024 time1, AccelerationInMeterPerSecondSquared17may2024 acceleration2)
        {
            var result = VelocityCalculation9may2024.Multiply(acceleration1: acceleration2, time2: time1);
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator *(double factor, AccelerationInMeterPerSecondSquared17may2024 b)
        {
            var result = new AccelerationInMeterPerSecondSquared17may2024(factor * b.GetInMeterPerSecondSquared(), factor * b.GetPrecisionInMeterPerSecondSquared());
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator *(AccelerationInMeterPerSecondSquared17may2024 a, double factor)
        {
            var result = new AccelerationInMeterPerSecondSquared17may2024(a.GetInMeterPerSecondSquared() * factor, a.GetPrecisionInMeterPerSecondSquared() * factor);
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator +(AccelerationInMeterPerSecondSquared17may2024 a, AccelerationInMeterPerSecondSquared17may2024 b)
        {
            var result = AccelerationCalculation9may2024.Add(a, b);
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator -(AccelerationInMeterPerSecondSquared17may2024 a, AccelerationInMeterPerSecondSquared17may2024 b)
        {
            var result = AccelerationCalculation9may2024.Substract(a, b);
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator +(AccelerationInMeterPerSecondSquared17may2024 a)
        {
            var result = new AccelerationInMeterPerSecondSquared17may2024(a.GetInMeterPerSecondSquared(), a.GetPrecisionInMeterPerSecondSquared());
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator -(AccelerationInMeterPerSecondSquared17may2024 a)
        {
            var result = new AccelerationInMeterPerSecondSquared17may2024(-a.GetInMeterPerSecondSquared(), a.GetPrecisionInMeterPerSecondSquared());
            return result;
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator /(AccelerationInMeterPerSecondSquared17may2024 a, double factor)
        {
            var result = new AccelerationInMeterPerSecondSquared17may2024(a.GetInMeterPerSecondSquared() / factor, a.GetInMeterPerSecondSquared() / factor);
            return result;
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 operator *(AccelerationInMeterPerSecondSquared17may2024 acceleration1, ILength14feb2024 length2)
        {
            var result = VelocitySquaredCalculation18may2024.Multiply(acceleration1, length2);
            return result;
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 operator *(ILength14feb2024 length1, AccelerationInMeterPerSecondSquared17may2024 acceleration2)
        {
            var result = VelocitySquaredCalculation18may2024.Multiply(acceleration2, length1);
            return result;
        }
    }
}
