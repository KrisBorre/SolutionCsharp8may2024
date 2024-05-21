using LibraryIntegrationWork9May2024;
using LibraryPhysicalUnits8may2024;

namespace ConsoleWorkRequiredToCompressASpring10May2024
{
    internal class ForceLinearOscillator : IntegrandAbstractClass14Feb2024
    {
        private SpringInNewtonPerMeter k;

        public ForceLinearOscillator()
        {
            this.k = new SpringInNewtonPerMeter(50.0, 0);
        }

        public ForceLinearOscillator(SpringInNewtonPerMeter k)
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
            return k * x;
        }

        public override string ToString()
        {
            return $"{k} x";
        }
    }
}
