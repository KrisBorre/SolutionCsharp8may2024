using LibraryIntegrationWork9May2024;
using LibraryPhysicalUnits8may2024;

namespace ConsoleWorkRequiredToCompressASpring10May2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The work required to stretch or compress a spring. ");
            Console.WriteLine("The displacement from compression has a negative sign with units of meters.");
            Console.WriteLine("The displacement from stretching has a positive sign with units of meters.");
            Console.WriteLine("This is an exercise on the propagation of measurement errors in calculations.");

            Console.WriteLine("Suppose it takes a force of ( 10 \u00B1 1 ) Newton (in the negative direction) to compress a spring (0.2 ± 0.1) meter from the equilibrium position.");
            Console.WriteLine("How much work is done to stretch the spring (0.5 ± 0.1) m from the equilibrium position?");

            ForceInNewton F = new ForceInNewton(-10, 1); // F = -10 N plusminus 1 N
            LengthInMeter8may2024 x = new LengthInMeter8may2024(-0.2, 0.1); // x = -0.2 m plusminus 0.1 m

            var k = F / x; // k = 50 N/m
            Console.WriteLine($"spring constant is {k}");

            const int MAX = 20;
            NumericalIntegrator14Feb2024 integrator = new NumericalIntegrator14Feb2024(new ForceLinearOscillator(k), new LengthInMeter8may2024(0.0, 0), new LengthInMeter8may2024(0.5, 0.1));

            WorkInJoule work = new WorkInJoule(0);
            for (int j = 1; j <= MAX; j++)
            {
                work = integrator.Next();
                Console.WriteLine($"{j}        Work = {work}");
            }
            Console.WriteLine(integrator);

            Console.WriteLine("Solution: The work done to stretch the spring is 6.25 J.");
            // https://math.libretexts.org/Bookshelves/Calculus/Calculus_(OpenStax)/06%3A_Applications_of_Integration/6.05%3A_Physical_Applications_of_Integration

            /*
            The work required to stretch or compress a spring.
            The displacement from compression has a negative sign with units of meters.
            The displacement from stretching has a positive sign with units of meters.
            This is an exercise on the propagation of measurement errors in calculations.
            Suppose it takes a force of ( 10 ± 1 ) Newton (in the negative direction) to compress a spring (0.2 ± 0.1) meter from the equilibrium position.
            How much work is done to stretch the spring (0.5 ± 0.1) m from the equilibrium position?
            spring constant is 50 N/m
            1        Work = ( 6,25 ± 1,8750004166666205 ) Joule
            2        Work = ( 6,25 ± 1,3258255093525695 ) Joule
            3        Work = ( 6,25 ± 1,018625591521794 ) Joule
            4        Work = ( 6,25 ± 0,8513475897104892 ) Joule
            5        Work = ( 6,25 ± 0,7742608085471585 ) Joule
            6        Work = ( 6,25 ± 0,7426852942946573 ) Joule
            7        Work = ( 6,25 ± 0,7303009060603333 ) Joule
            8        Work = ( 6,25 ± 0,7253850613741726 ) Joule
            9        Work = ( 6,25 ± 0,7233502681402562 ) Joule
            10        Work = ( 6,25 ± 0,7224641351976313 ) Joule
            11        Work = ( 6,25 ± 0,7220601760998403 ) Joule
            12        Work = ( 6,25 ± 0,7218695354601311 ) Joule
            13        Work = ( 6,25 ± 0,7217774389059833 ) Joule
            14        Work = ( 6,25 ± 0,7217322936237699 ) Joule
            15        Work = ( 6,25 ± 0,7217099709655795 ) Joule
            16        Work = ( 6,25 ± 0,7216988781866233 ) Joule
            17        Work = ( 6,25 ± 0,721693350447696 ) Joule
            18        Work = ( 6,25 ± 0,7216905916190418 ) Joule
            19        Work = ( 6,25 ± 0,7216892135594484 ) Joule
            20        Work = ( 6,25 ± 0,7216885248919664 ) Joule
            The integral solution using integrand 50 N/m x and using boundaries from 0 m to 0,5 m using the extended trapezoidal rule is ( 6,25 ± 0,7216885248919664 ) Joule
            Solution: The work done to stretch the spring is 6.25 J.
            */

            Console.WriteLine("\nMaking errors is part of every growth and measurement process.\n");

            Console.WriteLine("Non-linear oscillator:");
            NumericalIntegrator14Feb2024 integrator2 = new NumericalIntegrator14Feb2024(new ForceNonLinearOscillator(), new LengthInMeter8may2024(0.0, 0), new LengthInMeter8may2024(0.5, 0.1));
            WorkInJoule work2 = new WorkInJoule(0);
            for (int j = 1; j <= MAX; j++)
            {
                work2 = integrator2.Next();
            }
            Console.WriteLine(integrator2);
            Console.WriteLine($"Work = {work2}");

            /*
            Non-linear oscillator:
            The integral solution using integrand 50 N/m x + 1 N/m^2 x^2 and using boundaries from 0 m to 0,5 m using the extended trapezoidal rule is ( 6,291666666667463 ± 0,7264990888775982 ) Joule
            Work = ( 6,291666666667463 ± 0,7264990888775982 ) Joule
            */

            Console.ReadKey();
        }
    }
}
