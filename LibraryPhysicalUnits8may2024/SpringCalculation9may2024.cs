namespace LibraryPhysicalUnits8may2024
{
    public class SpringCalculation9may2024
    {
        public static SpringInNewtonPerMeter Add(ISpring spring1, ISpring spring2)
        {
            double result = spring1.GetInNewtonPerMeter() + spring2.GetInNewtonPerMeter();
            double accuracy = Math.Sqrt(Math.Pow(spring1.GetPrecisionInNewtonPerMeter(), 2) + Math.Pow(spring2.GetPrecisionInNewtonPerMeter(), 2));
            return new SpringInNewtonPerMeter(result, accuracy);
        }

        public static SpringInNewtonPerMeter Substract(ISpring spring1, ISpring spring2)
        {
            double result = spring1.GetInNewtonPerMeter() - spring2.GetInNewtonPerMeter();
            double accuracy = Math.Sqrt(Math.Pow(spring1.GetPrecisionInNewtonPerMeter(), 2) + Math.Pow(spring2.GetPrecisionInNewtonPerMeter(), 2));
            return new SpringInNewtonPerMeter(result, accuracy);
        }

        public static SpringInNewtonPerMeter Divide(IForce force1, ILength14feb2024 length2)
        {
            double result = force1.GetInNewton() / length2.GetInMeter();
            double first = length2.GetPrecisionInMeter() / force1.GetInNewton();
            double second = (force1.GetPrecisionInNewton() * length2.GetInMeter()) / Math.Pow(length2.GetInMeter(), 2);
            double accuracy = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2));
            return new SpringInNewtonPerMeter(result, accuracy);
        }

        public static SpringInNewtonPerMeter Multiply(ISpring2 springInNewtonPerSquareMeter1, ILength14feb2024 length2)
        {
            double result = springInNewtonPerSquareMeter1.GetInNewtonPerSquareMeter() * length2.GetInMeter();
            double accuracy = Math.Sqrt(Math.Pow(length2.GetPrecisionInMeter() * springInNewtonPerSquareMeter1.GetInNewtonPerSquareMeter(), 2) + Math.Pow(springInNewtonPerSquareMeter1.GetPrecisionInNewtonPerSquareMeter() * length2.GetInMeter(), 2));
            return new SpringInNewtonPerMeter(result, accuracy);
        }

        public static SpringInNewtonPerMeter Multiply(ILength14feb2024 length1, ISpring2 springInNewtonPerSquareMeter2)
        {
            double result = length1.GetInMeter() * springInNewtonPerSquareMeter2.GetInNewtonPerSquareMeter();
            double accuracy = Math.Sqrt(Math.Pow(length1.GetPrecisionInMeter() * springInNewtonPerSquareMeter2.GetInNewtonPerSquareMeter(), 2) + Math.Pow(springInNewtonPerSquareMeter2.GetPrecisionInNewtonPerSquareMeter() * length1.GetInMeter(), 2));
            return new SpringInNewtonPerMeter(result, accuracy);
        }
    }
}
