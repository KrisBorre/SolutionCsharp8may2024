namespace LibraryPhysicalUnits8may2024
{
    public class TemperatureInFahrenheit : ITemperature
    {
        private double m_TemperatureInFahrenheit;
        private double m_PrecisionInFahrenheit;

        public TemperatureInFahrenheit(double temperatureInFahrenheit, double precisionInFahrenheit)
        {
            m_TemperatureInFahrenheit = temperatureInFahrenheit;
            m_PrecisionInFahrenheit = precisionInFahrenheit;
        }

        public double GetInFahrenheit()
        {
            return m_TemperatureInFahrenheit;
        }

        public double GetInCelsius()
        {
            return TemperatureCalculation9may2024.ConvertFahrenheitIntoCelsius(m_TemperatureInFahrenheit);
        }

        public double GetPrecisionInFahrenheit()
        {
            return m_PrecisionInFahrenheit;
        }

        public double GetPrecisionInCelsius()
        {
            return TemperatureCalculation9may2024.ConvertFahrenheitIntoCelsius(m_PrecisionInFahrenheit);
        }

        public override string ToString()
        {
            return m_TemperatureInFahrenheit + " \u00B0F";
        }
    }
}
