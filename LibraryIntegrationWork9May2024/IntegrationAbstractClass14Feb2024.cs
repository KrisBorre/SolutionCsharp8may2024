using LibraryPhysicalUnits8may2024;

namespace LibraryIntegrationWork9May2024
{
    public abstract class IntegrationAbstractClass14Feb2024
    {
        protected IntegrandAbstractClass14Feb2024 integrand;

        internal IntegrandAbstractClass14Feb2024 Integrand
        {
            get
            {
                return integrand;
            }
        }

        protected Method14Feb2024 method;

        internal Method14Feb2024 Method
        {
            get
            {
                return method;
            }
        }

        // Limits of integration and current value of integral.
        protected LengthInMeter8may2024 m_a, m_b;

        public LengthInMeter8may2024 a
        {
            get { return this.m_a; }
            set
            {
                this.m_a = value;
                this.m_n = 0;
                solution = null;
            }
        }

        public LengthInMeter8may2024 b
        {
            get { return this.m_b; }
            set
            {
                this.m_b = value;
                this.m_n = 0;
                solution = null;
            }
        }

        protected int m_n;

        public IntegrationAbstractClass14Feb2024(IntegrandAbstractClass14Feb2024 integrand, LengthInMeter8may2024 a, LengthInMeter8may2024 b)
        {
            this.integrand = integrand;
            this.m_a = a;
            this.m_b = b;
            this.m_n = 0;
        }

        protected WorkInJoule? solution = null;

        public abstract WorkInJoule Next();

        public override string ToString()
        {
            return "The integral solution";
        }

        public abstract IntegrationAbstractClass14Feb2024 Clone();

    }
}
