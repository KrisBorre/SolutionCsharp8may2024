namespace LibraryPhysicalUnits8may2024
{
    public static class EnergyCalculation9may2024
    {
        public static EnergyInJoule14feb2024 Add(IEnergy energy1, IEnergy energy2)
        {
            double result = energy1.GetInJoule() + energy2.GetInJoule();
            double accuracy = Math.Sqrt(Math.Pow(energy1.GetPrecisionInJoule(), 2) + Math.Pow(energy2.GetPrecisionInJoule(), 2));
            return new EnergyInJoule14feb2024(result, accuracy);
        }

    }
}
