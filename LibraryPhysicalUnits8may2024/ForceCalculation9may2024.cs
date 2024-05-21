namespace LibraryPhysicalUnits8may2024
{
    public static class ForceCalculation9may2024
    {
        public static ForceInNewton Add(IForce force1, IForce force2)
        {
            double result = force1.GetInNewton() + force2.GetInNewton();
            double accuracy = Math.Sqrt(Math.Pow(force1.GetPrecisionInNewton(), 2) + Math.Pow(force2.GetPrecisionInNewton(), 2));
            return new ForceInNewton(result, accuracy);
        }

        public static ForceInNewton Substract(IForce force1, IForce force2)
        {
            double result = force1.GetInNewton() - force2.GetInNewton();
            double accuracy = Math.Sqrt(Math.Pow(force1.GetPrecisionInNewton(), 2) + Math.Pow(force2.GetPrecisionInNewton(), 2));
            return new ForceInNewton(result, accuracy);
        }

        public static ForceInNewton Multiply(ISpring springInNewtonPerMeter1, ILength14feb2024 length2)
        {
            double result = springInNewtonPerMeter1.GetInNewtonPerMeter() * length2.GetInMeter();
            double accuracy = Math.Sqrt(Math.Pow(springInNewtonPerMeter1.GetPrecisionInNewtonPerMeter() * length2.GetInMeter(), 2) + Math.Pow(length2.GetPrecisionInMeter() * springInNewtonPerMeter1.GetInNewtonPerMeter(), 2));
            return new ForceInNewton(result, accuracy);
        }

        public static ForceInNewton Multiply(ILength14feb2024 length1, ISpring springInNewtonPerMeter2)
        {
            double result = length1.GetInMeter() * springInNewtonPerMeter2.GetInNewtonPerMeter();
            double accuracy = Math.Sqrt(Math.Pow(length1.GetPrecisionInMeter() * springInNewtonPerMeter2.GetInNewtonPerMeter(), 2) + Math.Pow(springInNewtonPerMeter2.GetPrecisionInNewtonPerMeter() * length1.GetInMeter(), 2));
            return new ForceInNewton(result, accuracy);
        }

        public static ForceInNewton Multiply(ISpring2 springInNewtonPerSquareMeter1, IArea8may2024 area2)
        {
            double result = springInNewtonPerSquareMeter1.GetInNewtonPerSquareMeter() * area2.GetInSquareMeter();
            double accuracy = Math.Sqrt(Math.Pow(springInNewtonPerSquareMeter1.GetPrecisionInNewtonPerSquareMeter() * area2.GetInSquareMeter(), 2) + Math.Pow(area2.GetPrecisionInSquareMeter() * springInNewtonPerSquareMeter1.GetInNewtonPerSquareMeter(), 2));
            return new ForceInNewton(result, accuracy);
        }

        public static ForceInNewton Multiply(IArea8may2024 area1, ISpring2 springInNewtonPerSquareMeter2)
        {
            double result = area1.GetInSquareMeter() * springInNewtonPerSquareMeter2.GetInNewtonPerSquareMeter();
            double accuracy = Math.Sqrt(Math.Pow(springInNewtonPerSquareMeter2.GetPrecisionInNewtonPerSquareMeter() * area1.GetInSquareMeter(), 2) + Math.Pow(area1.GetPrecisionInSquareMeter() * springInNewtonPerSquareMeter2.GetInNewtonPerSquareMeter(), 2));
            return new ForceInNewton(result, accuracy);
        }
    }
}
