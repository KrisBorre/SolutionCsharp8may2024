using LibraryPhysicalUnits8may2024;

namespace ConsoleKinematics17may2024
{
    internal class TweedeGraadsVergelijking17may2024
    {
        private AccelerationInMeterPerSecondSquared17may2024 a;
        private VelocityInMeterPerSecond13may2024 b;
        private LengthInMeter8may2024 c;

        public TweedeGraadsVergelijking17may2024(AccelerationInMeterPerSecondSquared17may2024 a, VelocityInMeterPerSecond13may2024 b, LengthInMeter8may2024 c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public LengthInMeter8may2024 YWaarde(TimeInSeconds8may2024 t)
        {
            return (a * t * t + b * t + c);
        }

        public double Discriminant
        {
            get { return (b.GetInMeterPerSecond() * b.GetInMeterPerSecond() - 4 * a.GetInMeterPerSecondSquared() * c.GetInMeter()); }
        }

        public void ZoekNulpunten(out TimeInSeconds8may2024 t1, out TimeInSeconds8may2024 t2, out bool heeftNulpunten)
        {
            heeftNulpunten = false;
            t1 = new TimeInSeconds8may2024(0, 0);
            t2 = new TimeInSeconds8may2024(0, 0);
            double d = Discriminant;
            if (d >= 0)
            {
                heeftNulpunten = true;
                t1 = new TimeInSeconds8may2024((-b.GetInMeterPerSecond() + Math.Sqrt(d)) / (2 * a.GetInMeterPerSecondSquared()), 0);
                t2 = new TimeInSeconds8may2024((-b.GetInMeterPerSecond() - Math.Sqrt(d)) / (2 * a.GetInMeterPerSecondSquared()), 0);
            }
        }

        public override string ToString()
        {
            return a + " * t^2 + " + b + " * t + " + c;
        }
    }
}
