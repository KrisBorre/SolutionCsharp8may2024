using LibraryIntegrationWork9May2024;
using LibraryPhysicalUnits8may2024;

namespace ConsoleWorkRequiredToCompressASpring9May2024
{
    internal class ForceNonLinearOscillator : IntegrandAbstractClass14Feb2024
    {
        private double k1;
        private double k2;

        public ForceNonLinearOscillator(double k1 = 50.0, double k2 = 1.0)
        {
            this.k1 = k1;
            this.k2 = k2;
        }

        public override IntegrandAbstractClass14Feb2024 Clone()
        {
            ForceNonLinearOscillator clone = new ForceNonLinearOscillator(this.k1, this.k2);
            return clone;
        }

        public override ForceInNewton Function(LengthInMeter8may2024 x)
        {
            return new ForceInNewton(k1 * x.GetInMeter() + k2 * x.GetInMeter() * x.GetInMeter());
        }

        public override string ToString()
        {
            return $"{k1} x + {k2} x^2";
        }
    }
}
