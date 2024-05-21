using LibraryIntegrationWork9May2024;
using LibraryPhysicalUnits8may2024;

namespace ConsoleWorkRequiredToCompressASpring10May2024
{
    internal class ForceNonLinearOscillator : IntegrandAbstractClass14Feb2024
    {
        private SpringInNewtonPerMeter k1;
        private SpringInNewtonPerSquareMeter k2;

        public ForceNonLinearOscillator()
        {
            this.k1 = new SpringInNewtonPerMeter(50.0, 0);
            this.k2 = new SpringInNewtonPerSquareMeter(1.0, 0);
        }

        public ForceNonLinearOscillator(SpringInNewtonPerMeter k1, SpringInNewtonPerSquareMeter k2)
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
            return k1 * x + k2 * x * x;
        }

        public override string ToString()
        {
            return $"{k1} x + {k2} x^2";
        }
    }
}
