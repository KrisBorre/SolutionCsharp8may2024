using LibraryIntegrationWork9May2024;
using LibraryPhysicalUnits8may2024;

namespace ConsoleWorkRequiredToCompressASpring9May2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The work required to stretch or compress a spring. (compression in centimeters)");
            Console.WriteLine("Suppose it takes a force of 10 N (in the negative direction) to compress a spring 0.2 m from the equilibrium position. ");
            Console.WriteLine("How much work is done to stretch the spring 0.5 cm from the equilibrium position?");

            var displacement = new LengthInCentimeter8may2024(0.5, 0);

            const int MAX = 8;
            NumericalIntegrator14Feb2024 integrator1 = new NumericalIntegrator14Feb2024(new ForceLinearOscillator(), new LengthInMeter8may2024(0.0, 0), displacement.ConvertToMeter());

            WorkInJoule work1 = new WorkInJoule(0);
            for (int j = 1; j <= MAX; j++)
            {
                work1 = integrator1.Next();
            }
            Console.WriteLine(integrator1);
            Console.WriteLine($"Work = {work1}");

            /*
            The work required to stretch or compress a spring. (compression in centimeters)
            Suppose it takes a force of 10 N (in the negative direction) to compress a spring 0.2 m from the equilibrium position.
            How much work is done to stretch the spring 0.5 cm from the equilibrium position?
            The integral solution using integrand 50 x and using boundaries from 0 m to 0,005 m using the extended trapezoidal rule is ( 0,000625 ± 0 ) Joule
            Work = ( 0,000625 ± 0 ) Joule
            */

            Console.WriteLine();
            Console.WriteLine("Non-linear oscillator:");

            NumericalIntegrator14Feb2024 integrator2 = new NumericalIntegrator14Feb2024(new ForceNonLinearOscillator(), new LengthInMeter8may2024(0.0, 0), displacement.ConvertToMeter());

            WorkInJoule work2 = new WorkInJoule(0);
            for (int j = 1; j <= MAX; j++)
            {
                work2 = integrator2.Next();
            }
            Console.WriteLine(integrator2);
            Console.WriteLine($"Work = {work2}");

            /*
            Non-linear oscillator:
            The integral solution using integrand 50 x + 1 x^2 and using boundaries from 0 m to 0,005 m using the extended trapezoidal rule is ( 0,0006250416679382325 ± 0 ) Joule
            Work = ( 0,0006250416679382325 ± 0 ) Joule
            */

            Console.ReadKey();
        }
    }
}
