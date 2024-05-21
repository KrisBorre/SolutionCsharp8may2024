namespace LibraryPhysicalUnits8may2024
{
    // https://en.wikipedia.org/wiki/Category:Units_of_area
    public class AreaInSquareMeter8may2024 : IArea8may2024
    {
        private double m_AreaInSquareMeter;
        private double m_PrecisionInSquareMeter;

        public AreaInSquareMeter8may2024(double areaInSquareMeter, double precisionInSquareMeter)
        {
            m_AreaInSquareMeter = areaInSquareMeter;
            m_PrecisionInSquareMeter = precisionInSquareMeter;
        }

        public double GetInSquareMeter()
        {
            return m_AreaInSquareMeter;
        }

        public double GetInSquareCentimeter()
        {
            return AreaCalculation8may2024.ConvertSquareMeterIntoSquareCentimeter(m_AreaInSquareMeter);
        }

        public double GetPrecisionInSquareMeter()
        {
            return m_PrecisionInSquareMeter;
        }

        public double GetInSquareKilometer()
        {
            return AreaCalculation8may2024.ConvertSquareMeterIntoSquareKilometer(m_AreaInSquareMeter);
        }

        public double GetPrecisionInSquareKilometer()
        {
            return AreaCalculation8may2024.ConvertSquareMeterIntoSquareKilometer(m_PrecisionInSquareMeter);
        }

        public AreaInSquareMeter8may2024 MultiplyBy(double factor)
        {
            var result = new AreaInSquareMeter8may2024(this.m_AreaInSquareMeter * factor, this.m_PrecisionInSquareMeter * factor);
            return result;
        }

        public static AreaInSquareMeter8may2024 operator *(double factor, AreaInSquareMeter8may2024 b)
        {
            var result = new AreaInSquareMeter8may2024(factor * b.GetInSquareMeter(), factor * b.GetPrecisionInSquareMeter());
            return result;
        }

        public static AreaInSquareMeter8may2024 operator *(AreaInSquareMeter8may2024 a, double factor)
        {
            var result = new AreaInSquareMeter8may2024(a.GetInSquareMeter() * factor, a.GetPrecisionInSquareMeter() * factor);
            return result;
        }

        public AreaInSquareMeter8may2024 DivideBy(double factor)
        {
            var result = new AreaInSquareMeter8may2024(this.m_AreaInSquareMeter / factor, this.m_PrecisionInSquareMeter / factor);
            return result;
        }

        public static AreaInSquareMeter8may2024 operator /(AreaInSquareMeter8may2024 a, double factor)
        {
            var result = new AreaInSquareMeter8may2024(a.GetInSquareMeter() / factor, a.GetPrecisionInSquareMeter() / factor);
            return result;
        }

        public static double operator /(AreaInSquareMeter8may2024 a, IArea8may2024 b)
        {
            double result = a.GetInSquareMeter() / b.GetInSquareMeter();
            return result;
        }

        public override string ToString()
        {
            return m_AreaInSquareMeter + " m^2";
        }

        public AreaInSquareKilometer8may2024 ConvertToSquareKilometer()
        {
            double areaInSquareKilometer = AreaCalculation8may2024.ConvertSquareMeterIntoSquareKilometer(m_AreaInSquareMeter);
            double precisionInSquareKilometer = AreaCalculation8may2024.ConvertSquareMeterIntoSquareKilometer(m_PrecisionInSquareMeter);
            return new AreaInSquareKilometer8may2024(areaInSquareKilometer, precisionInSquareKilometer);
        }

    }
}
