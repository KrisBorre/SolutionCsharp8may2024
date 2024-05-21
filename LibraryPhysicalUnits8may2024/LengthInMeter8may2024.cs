namespace LibraryPhysicalUnits8may2024
{
    public class LengthInMeter8may2024 : ILength14feb2024
    {
        private double m_LengthInMeter;
        private double m_PrecisionInMeter;

        public LengthInMeter8may2024(double lengthInMeter, double accuracyInMeter)
        {
            m_LengthInMeter = lengthInMeter;
            m_PrecisionInMeter = accuracyInMeter;
        }

        public double GetInMeter()
        {
            return m_LengthInMeter;
        }

        public double GetInKilometer()
        {
            return LengthCalculation9may2024.ConvertMeterIntoKilometer(m_LengthInMeter);
        }

        public double GetInCentimeter()
        {
            return LengthCalculation9may2024.ConvertMeterIntoCentimeter(m_LengthInMeter);
        }

        public double GetPrecisionInMeter()
        {
            return m_PrecisionInMeter;
        }

        public override string ToString()
        {
            return m_LengthInMeter + " m";
        }

        public LengthInMeter8may2024 MultiplyBy(double factor)
        {
            var result = new LengthInMeter8may2024(this.m_LengthInMeter * factor, this.m_PrecisionInMeter * factor);
            return result;
        }

        public static LengthInMeter8may2024 operator *(double factor, LengthInMeter8may2024 b)
        {
            var result = new LengthInMeter8may2024(factor * b.GetInMeter(), factor * b.GetPrecisionInMeter());
            return result;
        }

        public static LengthInMeter8may2024 operator *(LengthInMeter8may2024 a, double factor)
        {
            var result = new LengthInMeter8may2024(a.GetInMeter() * factor, a.GetPrecisionInMeter() * factor);
            return result;
        }

        public LengthInMeter8may2024 DivideBy(double factor)
        {
            var result = new LengthInMeter8may2024(this.m_LengthInMeter / factor, this.m_PrecisionInMeter / factor);
            return result;
        }

        //public static InvertedLengthInMeter operator /(double factor, LengthInMeter b)
        //{
        //    var result = new InvertedLengthInMeter(factor / b.GetInMeter(), factor / b.GetPrecisionInMeter());
        //    return result;
        //}

        public static LengthInMeter8may2024 operator /(LengthInMeter8may2024 a, double factor)
        {
            var result = new LengthInMeter8may2024(a.GetInMeter() / factor, a.GetPrecisionInMeter() / factor);
            return result;
        }

        public static AreaInSquareMeter8may2024 operator *(LengthInMeter8may2024 a, LengthInMeter8may2024 b)
        {
            var result = AreaCalculation8may2024.Multiply(a, b);
            return result;
        }

        public static AreaInSquareMeter8may2024 operator *(LengthInMeter8may2024 a, LengthInCentimeter8may2024 b)
        {
            var result = AreaCalculation8may2024.Multiply(a, b);
            return result;
        }

        public static AreaInSquareMeter8may2024 operator *(LengthInCentimeter8may2024 a, LengthInMeter8may2024 b)
        {
            var result = AreaCalculation8may2024.Multiply(a, b);
            return result;
        }

        public static AreaInSquareMeter8may2024 operator *(LengthInMeter8may2024 a, LengthInKilometer8may2024 b)
        {
            var result = AreaCalculation8may2024.Multiply(a, b);
            return result;
        }

        public static AreaInSquareMeter8may2024 operator *(LengthInKilometer8may2024 a, LengthInMeter8may2024 b)
        {
            var result = AreaCalculation8may2024.Multiply(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator +(LengthInMeter8may2024 a, LengthInMeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator +(LengthInMeter8may2024 a, LengthInCentimeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator +(LengthInCentimeter8may2024 a, LengthInMeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator +(LengthInMeter8may2024 a, LengthInKilometer8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator +(LengthInKilometer8may2024 a, LengthInMeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInMeter8may2024 a, LengthInCentimeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInMeter8may2024 a, LengthInMeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInCentimeter8may2024 a, LengthInMeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInMeter8may2024 a, LengthInKilometer8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInKilometer8may2024 a, LengthInMeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInMeter8may2024 a)
        {
            var result = new LengthInMeter8may2024(-a.GetInMeter(), a.GetPrecisionInMeter());
            return result;
        }

        public LengthInCentimeter8may2024 ConvertToCentimeter()
        {
            double lengthInCentimeter = LengthCalculation9may2024.ConvertMeterIntoCentimeter(m_LengthInMeter);
            double precisionInCentimeter = LengthCalculation9may2024.ConvertMeterIntoCentimeter(m_PrecisionInMeter);
            return new LengthInCentimeter8may2024(lengthInCentimeter, precisionInCentimeter);
        }

        public LengthInKilometer8may2024 ConvertToKilometer()
        {
            double lengthInKilometer = LengthCalculation9may2024.ConvertMeterIntoKilometer(m_LengthInMeter);
            double precisionInKilometer = LengthCalculation9may2024.ConvertMeterIntoKilometer(m_PrecisionInMeter);
            return new LengthInKilometer8may2024(lengthInKilometer, precisionInKilometer);
        }

        public static VelocityInMeterPerSecond13may2024 operator /(LengthInMeter8may2024 length1, ITime6apr2024 time2)
        {
            var result = VelocityCalculation9may2024.Divide(length1: length1, time2: time2);
            return result;
        }

        public static TimeInSeconds8may2024 operator /(LengthInMeter8may2024 length1, IVelocity6apr2024 velocity2)
        {
            var result = TimeCalculation13may2024.Divide(length1: length1, velocity2: velocity2);
            return result;
        }

        public AreaInSquareMeter8may2024 Square()
        {
            var result = AreaCalculation8may2024.Multiply(this, this);
            return result;
        }

        public static double operator /(LengthInMeter8may2024 a, ILength14feb2024 b)
        {
            double result = a.GetInMeter() / b.GetInMeter();
            return result;
        }
    }
}
