namespace LibraryPhysicalUnits8may2024
{
    public class LengthInKilometer8may2024 : ILength14feb2024
    {
        private double m_LengthInKilometer;
        private double m_PrecisionInKilometer;

        public LengthInKilometer8may2024(double lengthInKilometer, double accuracyInKilometer)
        {
            m_LengthInKilometer = lengthInKilometer;
            m_PrecisionInKilometer = accuracyInKilometer;
        }

        public double GetInKilometer()
        {
            return m_LengthInKilometer;
        }

        public double GetInMeter()
        {
            return LengthCalculation9may2024.ConvertKilometerIntoMeter(m_LengthInKilometer);
        }

        public double GetInCentimeter()
        {
            return LengthCalculation9may2024.ConvertKilometerIntoCentimeter(m_LengthInKilometer);
        }

        public double GetPrecisionInKilometer()
        {
            return m_PrecisionInKilometer;
        }

        public double GetPrecisionInMeter()
        {
            return LengthCalculation9may2024.ConvertKilometerIntoMeter(m_PrecisionInKilometer);
        }

        public override string ToString()
        {
            return m_LengthInKilometer + " km";
        }

        public LengthInMeter8may2024 ConvertToMeter()
        {
            double lengthInMeter = LengthCalculation9may2024.ConvertKilometerIntoMeter(m_LengthInKilometer);
            double precisionInMeter = LengthCalculation9may2024.ConvertKilometerIntoMeter(m_PrecisionInKilometer);
            return new LengthInMeter8may2024(lengthInMeter, precisionInMeter);
        }

        public LengthInKilometer8may2024 MultiplyBy(double factor)
        {
            var result = new LengthInKilometer8may2024(this.m_LengthInKilometer * factor, this.m_PrecisionInKilometer * factor);
            return result;
        }

        public static LengthInKilometer8may2024 operator *(double factor, LengthInKilometer8may2024 b)
        {
            var result = new LengthInKilometer8may2024(factor * b.GetInKilometer(), factor * b.GetPrecisionInKilometer());
            return result;
        }

        public static LengthInKilometer8may2024 operator *(LengthInKilometer8may2024 a, double factor)
        {
            var result = new LengthInKilometer8may2024(a.GetInKilometer() * factor, a.GetPrecisionInKilometer() * factor);
            return result;
        }

        public static AreaInSquareKilometer8may2024 operator *(LengthInKilometer8may2024 a, LengthInKilometer8may2024 b)
        {
            AreaInSquareMeter8may2024 areaInSquareMeter = AreaCalculation8may2024.Multiply(a, b);
            return areaInSquareMeter.ConvertToSquareKilometer();
        }

        public static LengthInMeter8may2024 operator +(LengthInKilometer8may2024 a, LengthInKilometer8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInKilometer8may2024 operator /(LengthInKilometer8may2024 a, double factor)
        {
            var result = new LengthInKilometer8may2024(a.GetInKilometer() / factor, a.GetPrecisionInKilometer() / factor);
            return result;
        }

        public static VelocityInMeterPerSecond13may2024 operator /(LengthInKilometer8may2024 length1, ITime6apr2024 time2)
        {
            var result = VelocityCalculation9may2024.Divide(length1: length1, time2: time2);
            return result;
        }

        public AreaInSquareKilometer8may2024 Square()
        {
            var result = AreaCalculation8may2024.Multiply(this, this);
            return result.ConvertToSquareKilometer();
        }

        public static double operator /(LengthInKilometer8may2024 a, ILength14feb2024 b)
        {
            double result = a.GetInKilometer() / b.GetInKilometer();
            return result;
        }
    }
}
