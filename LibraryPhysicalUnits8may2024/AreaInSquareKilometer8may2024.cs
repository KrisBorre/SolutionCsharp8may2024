namespace LibraryPhysicalUnits8may2024
{
    public class AreaInSquareKilometer8may2024 : IArea8may2024
    {
        private double m_AreaInSquareKilometer;
        private double m_PrecisionInSquareKilometer;

        public AreaInSquareKilometer8may2024(double areaInSquareKilometer, double precisionInSquareKilometer)
        {
            m_AreaInSquareKilometer = areaInSquareKilometer;
            m_PrecisionInSquareKilometer = precisionInSquareKilometer;
        }

        public double GetInSquareKilometer()
        {
            return m_AreaInSquareKilometer;
        }

        public double GetInSquareCentimeter()
        {
            throw new NotImplementedException();
        }

        public double GetInSquareMeter()
        {
            return AreaCalculation8may2024.ConvertSquareKilometerIntoSquareMeter(m_AreaInSquareKilometer);
        }

        public double GetPrecisionInSquareMeter()
        {
            return AreaCalculation8may2024.ConvertSquareKilometerIntoSquareMeter(m_PrecisionInSquareKilometer);
        }

        public double GetPrecisionInSquareKilometer()
        {
            return m_PrecisionInSquareKilometer;
        }

        public AreaInSquareMeter8may2024 ConvertToSquareMeter()
        {
            double areaInSquareMeter = AreaCalculation8may2024.ConvertSquareKilometerIntoSquareMeter(m_AreaInSquareKilometer);
            double precisionInSquareMeter = AreaCalculation8may2024.ConvertSquareKilometerIntoSquareMeter(m_PrecisionInSquareKilometer);
            return new AreaInSquareMeter8may2024(areaInSquareMeter, precisionInSquareMeter);
        }

        public static AreaInSquareKilometer8may2024 operator *(double factor, AreaInSquareKilometer8may2024 b)
        {
            var result = new AreaInSquareKilometer8may2024(factor * b.GetInSquareKilometer(), factor * b.GetPrecisionInSquareKilometer());
            return result;
        }

        public static AreaInSquareKilometer8may2024 operator *(AreaInSquareKilometer8may2024 a, double factor)
        {
            var result = new AreaInSquareKilometer8may2024(a.GetInSquareKilometer() * factor, a.GetPrecisionInSquareKilometer() * factor);
            return result;
        }

        public static AreaInSquareKilometer8may2024 operator /(AreaInSquareKilometer8may2024 a, double factor)
        {
            var result = new AreaInSquareKilometer8may2024(a.GetInSquareKilometer() / factor, a.GetPrecisionInSquareKilometer() / factor);
            return result;
        }

        public static double operator /(AreaInSquareKilometer8may2024 a, IArea8may2024 b)
        {
            double result = a.GetInSquareKilometer() / b.GetInSquareKilometer();
            return result;
        }

        public override string ToString()
        {
            return m_AreaInSquareKilometer + " km^2";
        }
    }
}
