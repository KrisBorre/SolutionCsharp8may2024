using LibraryIntegrationWork9May2024;
using LibraryPhysicalUnits8may2024;

namespace ConsoleWorkRequiredToCompressASpring9May2024
{
    internal class ForceLinearOscillator : IntegrandAbstractClass14Feb2024
    {
        private double k;

        public ForceLinearOscillator(double k = 50.0)
        {
            this.k = k;
        }

        public override IntegrandAbstractClass14Feb2024 Clone()
        {
            ForceLinearOscillator clone = new ForceLinearOscillator(this.k);
            return clone;
        }

        public override ForceInNewton Function(LengthInMeter8may2024 x)
        {
            return new ForceInNewton(k * x.GetInMeter());
        }

        public override string ToString()
        {
            return $"{k} x";
        }
    }
}
