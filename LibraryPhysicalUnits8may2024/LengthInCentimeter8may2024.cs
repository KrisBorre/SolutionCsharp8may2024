namespace LibraryPhysicalUnits8may2024
{
    public class LengthInCentimeter8may2024 : ILength14feb2024
    {
        private double m_LengthInCentimeter;
        private double m_PrecisionInCentimeter;

        public LengthInCentimeter8may2024(double lengthInCentimeter, double accuracyInCentimeter)
        {
            m_LengthInCentimeter = lengthInCentimeter;
            m_PrecisionInCentimeter = accuracyInCentimeter;
        }

        public double GetInCentimeter()
        {
            return m_LengthInCentimeter;
        }

        public double GetInKilometer()
        {
            return LengthCalculation9may2024.ConvertCentimeterIntoKilometer(m_LengthInCentimeter);
        }

        public double GetInMeter()
        {
            return LengthCalculation9may2024.ConvertCentimeterIntoMeter(m_LengthInCentimeter);
        }

        public double GetPrecisionInCentimeter()
        {
            return m_PrecisionInCentimeter;
        }

        public double GetPrecisionInMeter()
        {
            return LengthCalculation9may2024.ConvertCentimeterIntoMeter(m_PrecisionInCentimeter);
        }

        public override string ToString()
        {
            return m_LengthInCentimeter + " m";
        }


        public static LengthInMeter8may2024 operator +(LengthInCentimeter8may2024 a, LengthInCentimeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator +(LengthInCentimeter8may2024 a, LengthInKilometer8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator +(LengthInKilometer8may2024 a, LengthInCentimeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Add(a, b);
            return result;
        }


        public static LengthInMeter8may2024 operator -(LengthInCentimeter8may2024 a, LengthInCentimeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInCentimeter8may2024 a, LengthInKilometer8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }

        public static LengthInMeter8may2024 operator -(LengthInKilometer8may2024 a, LengthInCentimeter8may2024 b)
        {
            var result = LengthCalculation9may2024.Substract(a, b);
            return result;
        }


        public LengthInCentimeter8may2024 MultiplyBy(double factor)
        {
            var result = new LengthInCentimeter8may2024(this.m_LengthInCentimeter * factor, this.m_PrecisionInCentimeter * factor);
            return result;
        }

        public static LengthInCentimeter8may2024 operator *(double factor, LengthInCentimeter8may2024 b)
        {
            var result = new LengthInCentimeter8may2024(factor * b.GetInCentimeter(), factor * b.GetPrecisionInCentimeter());
            return result;
        }

        public static LengthInCentimeter8may2024 operator *(LengthInCentimeter8may2024 a, double factor)
        {
            var result = new LengthInCentimeter8may2024(a.GetInCentimeter() * factor, a.GetPrecisionInCentimeter() * factor);
            return result;
        }

        public LengthInMeter8may2024 ConvertToMeter()
        {
            double lengthInMeter = LengthCalculation9may2024.ConvertCentimeterIntoMeter(m_LengthInCentimeter);
            double precisionInMeter = LengthCalculation9may2024.ConvertCentimeterIntoMeter(m_PrecisionInCentimeter);
            return new LengthInMeter8may2024(lengthInMeter, precisionInMeter);
        }

        public static double operator /(LengthInCentimeter8may2024 a, ILength14feb2024 b)
        {
            double result = a.GetInCentimeter() / b.GetInCentimeter();
            return result;
        }
    }
}
