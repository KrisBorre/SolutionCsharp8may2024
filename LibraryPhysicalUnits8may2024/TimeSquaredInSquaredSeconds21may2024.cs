namespace LibraryPhysicalUnits8may2024
{
    public class TimeSquaredInSquaredSeconds21may2024 : ITimeSquared
    {
        private double m_TimeInSquaredSeconds;
        private double m_PrecisionInSquaredSeconds;

        public TimeSquaredInSquaredSeconds21may2024(double timeInSquaredSeconds, double accuracyInSquaredSeconds)
        {
            m_TimeInSquaredSeconds = timeInSquaredSeconds;
            m_PrecisionInSquaredSeconds = accuracyInSquaredSeconds;
        }

        public double GetInSquaredSeconds()
        {
            return m_TimeInSquaredSeconds;
        }

        public double GetPrecisionInSquaredSeconds()
        {
            return m_PrecisionInSquaredSeconds;
        }

    }
}
