namespace LibraryPhysicalUnits8may2024
{
    public class SpringInNewtonPerSquareMeter : ISpring2
    {
        private double m_SpringInNewtonPerSquareMeter;
        private double m_PrecisionInNewtonPerSquareMeter;

        public SpringInNewtonPerSquareMeter(double springInNewtonPerSquareMeter, double precisionInNewtonPerSquareMeter)
        {
            m_SpringInNewtonPerSquareMeter = springInNewtonPerSquareMeter;
            m_PrecisionInNewtonPerSquareMeter = precisionInNewtonPerSquareMeter;
        }

        public double GetInNewtonPerSquareMeter()
        {
            return m_SpringInNewtonPerSquareMeter;
        }

        public double GetPrecisionInNewtonPerSquareMeter()
        {
            return m_PrecisionInNewtonPerSquareMeter;
        }

        public override string ToString()
        {
            return m_SpringInNewtonPerSquareMeter + " N/m^2";
        }

        public SpringInNewtonPerSquareMeter MultiplyBy(double factor)
        {
            var result = new SpringInNewtonPerSquareMeter(this.m_SpringInNewtonPerSquareMeter * factor, this.m_PrecisionInNewtonPerSquareMeter * factor);
            return result;
        }

        public static SpringInNewtonPerSquareMeter operator *(double factor, SpringInNewtonPerSquareMeter b)
        {
            var result = new SpringInNewtonPerSquareMeter(factor * b.GetInNewtonPerSquareMeter(), factor * b.GetPrecisionInNewtonPerSquareMeter());
            return result;
        }

        public static SpringInNewtonPerSquareMeter operator *(SpringInNewtonPerSquareMeter a, double factor)
        {
            var result = new SpringInNewtonPerSquareMeter(a.GetInNewtonPerSquareMeter() * factor, a.GetPrecisionInNewtonPerSquareMeter() * factor);
            return result;
        }

        public static SpringInNewtonPerSquareMeter operator +(SpringInNewtonPerSquareMeter a, SpringInNewtonPerSquareMeter b)
        {
            var result = Spring2Calculation9may2024.Add(a, b);
            return result;
        }

        public SpringInNewtonPerSquareMeter DivideBy(double factor)
        {
            var result = new SpringInNewtonPerSquareMeter(this.m_SpringInNewtonPerSquareMeter / factor, this.m_PrecisionInNewtonPerSquareMeter / factor);
            return result;
        }

        public static SpringInNewtonPerSquareMeter operator /(SpringInNewtonPerSquareMeter a, double factor)
        {
            var result = new SpringInNewtonPerSquareMeter(a.GetInNewtonPerSquareMeter() / factor, a.GetPrecisionInNewtonPerSquareMeter() / factor);
            return result;
        }

        public static ForceInNewton operator *(SpringInNewtonPerSquareMeter springInNewtonPerSquareMeter1, IArea8may2024 area2)
        {
            var result = ForceCalculation9may2024.Multiply(springInNewtonPerSquareMeter1, area2);
            return result;
        }

        public static ForceInNewton operator *(IArea8may2024 area1, SpringInNewtonPerSquareMeter springInNewtonPerSquareMeter2)
        {
            var result = ForceCalculation9may2024.Multiply(area1, springInNewtonPerSquareMeter2);
            return result;
        }

        public static SpringInNewtonPerMeter operator *(SpringInNewtonPerSquareMeter springInNewtonPerSquareMeter1, ILength14feb2024 length2)
        {
            var result = SpringCalculation9may2024.Multiply(springInNewtonPerSquareMeter1, length2);
            return result;
        }

        public static SpringInNewtonPerMeter operator *(ILength14feb2024 length1, SpringInNewtonPerSquareMeter springInNewtonPerSquareMeter2)
        {
            var result = SpringCalculation9may2024.Multiply(length1, springInNewtonPerSquareMeter2);
            return result;
        }
    }
}
