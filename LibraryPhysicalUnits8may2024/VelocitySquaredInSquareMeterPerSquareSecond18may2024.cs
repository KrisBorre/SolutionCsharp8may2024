namespace LibraryPhysicalUnits8may2024
{
    public class VelocitySquaredInSquareMeterPerSquareSecond18may2024 : IVelocitySquared18may2024
    {
        private double m_VelocitySquaredInSquareMeterPerSquareSecond;
        private double m_PrecisionInSquareMeterPerSquareSecond;

        public override string ToString()
        {
            return m_VelocitySquaredInSquareMeterPerSquareSecond + " (m/s)^2";
        }

        /// <summary>
        /// is a velocity squared.
        /// </summary>
        public VelocitySquaredInSquareMeterPerSquareSecond18may2024(double velocitySquaredInSquareMeterPerSquareSecond, double precisionInSquareMeterPerSquareSecond)
        {
            m_VelocitySquaredInSquareMeterPerSquareSecond = velocitySquaredInSquareMeterPerSquareSecond;
            m_PrecisionInSquareMeterPerSquareSecond = precisionInSquareMeterPerSquareSecond;
        }

        public double GetInSquareMeterPerSquareSecond()
        {
            return m_VelocitySquaredInSquareMeterPerSquareSecond;
        }

        public double GetPrecisionInSquareMeterPerSquareSecond()
        {
            return m_PrecisionInSquareMeterPerSquareSecond;
        }

        public VelocityInMeterPerSecond13may2024 SquareRoot()
        {
            var result = new VelocityInMeterPerSecond13may2024(Math.Sqrt(m_VelocitySquaredInSquareMeterPerSquareSecond));
            return result;
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 operator *(double factor, VelocitySquaredInSquareMeterPerSquareSecond18may2024 b)
        {
            var result = new VelocitySquaredInSquareMeterPerSquareSecond18may2024(factor * b.GetInSquareMeterPerSquareSecond(), factor * b.GetPrecisionInSquareMeterPerSquareSecond());
            return result;
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 operator *(VelocitySquaredInSquareMeterPerSquareSecond18may2024 a, double factor)
        {
            var result = new VelocitySquaredInSquareMeterPerSquareSecond18may2024(a.GetInSquareMeterPerSquareSecond() * factor, a.GetPrecisionInSquareMeterPerSquareSecond() * factor);
            return result;
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 operator +(VelocitySquaredInSquareMeterPerSquareSecond18may2024 a, VelocitySquaredInSquareMeterPerSquareSecond18may2024 b)
        {
            var result = VelocitySquaredCalculation18may2024.Add(a, b);
            return result;
        }

        public static VelocitySquaredInSquareMeterPerSquareSecond18may2024 operator -(VelocitySquaredInSquareMeterPerSquareSecond18may2024 a, VelocitySquaredInSquareMeterPerSquareSecond18may2024 b)
        {
            var result = VelocitySquaredCalculation18may2024.Substract(a, b);
            return result;
        }
    }
}
