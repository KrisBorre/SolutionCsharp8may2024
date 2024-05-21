﻿
namespace LibraryPhysicalUnits8may2024
{
    public static class WorkCalculation9may2024
    {
        public static WorkInJoule Add(IEnergy energy1, IEnergy energy2)
        {
            double result = energy1.GetInJoule() + energy2.GetInJoule();
            double accuracy = Math.Sqrt(Math.Pow(energy1.GetPrecisionInJoule(), 2) + Math.Pow(energy2.GetPrecisionInJoule(), 2));
            return new WorkInJoule(result, accuracy);
        }

        public static WorkInJoule Substract(IEnergy energy1, IEnergy energy2)
        {
            double result = energy1.GetInJoule() - energy2.GetInJoule();
            double accuracy = Math.Sqrt(Math.Pow(energy1.GetPrecisionInJoule(), 2) + Math.Pow(energy2.GetPrecisionInJoule(), 2));
            return new WorkInJoule(result, accuracy);
        }

        public static WorkInJoule Multiply(IForce force1, ILength14feb2024 length2)
        {
            double result = force1.GetInNewton() * length2.GetInMeter();
            double accuracy = Math.Sqrt(Math.Pow(force1.GetPrecisionInNewton() * length2.GetInMeter(), 2) + Math.Pow(length2.GetPrecisionInMeter() * force1.GetInNewton(), 2));
            return new WorkInJoule(result, accuracy);
        }

        public static WorkInJoule Multiply(ILength14feb2024 length1, IForce force2)
        {
            double result = length1.GetInMeter() * force2.GetInNewton();
            double accuracy = Math.Sqrt(Math.Pow(length1.GetPrecisionInMeter() * force2.GetInNewton(), 2) + Math.Pow(force2.GetPrecisionInNewton() * length1.GetInMeter(), 2));
            return new WorkInJoule(result, accuracy);
        }
    }
}



