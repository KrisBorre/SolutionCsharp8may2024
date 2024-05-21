﻿namespace LibraryPhysicalUnits8may2024
{
    public class LengthCalculation9may2024
    {
        public static double ConvertCentimeterIntoKilometer(double length)
        {
            return length / 100000;
        }

        public static double ConvertKilometerIntoCentimeter(double length)
        {
            return length * 100000;
        }

        public static double ConvertMeterIntoKilometer(double length)
        {
            return length / 1000;
        }

        public static double ConvertKilometerIntoMeter(double length)
        {
            return length * 1000;
        }

        public static double ConvertMeterIntoCentimeter(double length)
        {
            return length * 100;
        }

        public static double ConvertCentimeterIntoMeter(double length)
        {
            return length / 100;
        }

        public static double ConvertMeterIntoFeet(double lengthInMeter)
        {
            return lengthInMeter / 0.3048;
        }

        public static double ConvertFeetIntoMeter(double lengthInFeet)
        {
            return lengthInFeet * 0.3048;
        }

        public static LengthInMeter8may2024 Add(ILength14feb2024 length1, ILength14feb2024 length2)
        {
            double result = length1.GetInMeter() + length2.GetInMeter();
            double accuracy = Math.Sqrt(Math.Pow(length1.GetPrecisionInMeter(), 2) + Math.Pow(length2.GetPrecisionInMeter(), 2));
            return new LengthInMeter8may2024(result, accuracy);
        }

        public static LengthInMeter8may2024 Substract(ILength14feb2024 length1, ILength14feb2024 length2)
        {
            double result = length1.GetInMeter() - length2.GetInMeter();
            double accuracy = Math.Sqrt(Math.Pow(length1.GetPrecisionInMeter(), 2) + Math.Pow(length2.GetPrecisionInMeter(), 2));
            return new LengthInMeter8may2024(result, accuracy);
        }

        public static LengthInMeter8may2024 Multiply(IVelocity6apr2024 velocity1, ITime6apr2024 time2)
        {
            double result = velocity1.GetInMeterPerSecond() * time2.GetInSeconds();
            double accuracy = Math.Sqrt(Math.Pow(velocity1.GetPrecisionInMeterPerSecond() * time2.GetInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds() * velocity1.GetInMeterPerSecond(), 2));
            return new LengthInMeter8may2024(result, accuracy);
        }

        public static LengthInMeter8may2024 Multiply(ITime6apr2024 time1, IVelocity6apr2024 velocity2)
        {
            double result = time1.GetInSeconds() * velocity2.GetInMeterPerSecond();
            double accuracy = Math.Sqrt(Math.Pow(velocity2.GetPrecisionInMeterPerSecond() * time1.GetInSeconds(), 2) + Math.Pow(time1.GetPrecisionInSeconds() * velocity2.GetInMeterPerSecond(), 2));
            return new LengthInMeter8may2024(result, accuracy);
        }


    }
}