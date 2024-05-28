namespace LibraryPhysicalUnits8may2024
{
    public class TimeSquaredCalculation21may2024
    {
        public static TimeSquaredInSquaredSeconds21may2024 Multiply(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double result = time1.GetInSeconds() * time2.GetInSeconds();
            double accuracy = Math.Sqrt(Math.Pow(time1.GetPrecisionInSeconds() * time2.GetInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds() * time1.GetInSeconds(), 2));
            return new TimeSquaredInSquaredSeconds21may2024(result, accuracy);
        }
    }
}
