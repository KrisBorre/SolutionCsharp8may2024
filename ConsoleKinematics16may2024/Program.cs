namespace ConsoleKinematics16may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 40");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.22");

            Console.WriteLine("A stone is thrown downward with initial speed 8 m/s from a height of 25 m.");
            Console.WriteLine("Find (a) the time it takes to reach the ground and (b) the speed with which it strikes.");

            decimal height = 25;
            decimal initial_speed = 8;
            decimal g = 9.81M;

            decimal t1 = 0; // initialisatie is noodzakelijk
            decimal t2 = 0;
            bool zijnGevonden = false;

            var vgl1 = new TweedeGraadsVergelijking13feb2024(g / 2, initial_speed, -height);
            Console.WriteLine(vgl1);
            vgl1.ZoekNulpunten(ref t1, ref t2, ref zijnGevonden);
            if (zijnGevonden)
            {
                Console.WriteLine("t1 = " + t1);
                Console.WriteLine("t2 = " + t2);
                Console.WriteLine("vgl1.YWaarde(" + t1 + ") = " + vgl1.YWaarde(t1));
                Console.WriteLine("vgl1.YWaarde(" + t2 + ") = " + vgl1.YWaarde(t2));

                decimal time;
                if (t1 > 0)
                {
                    time = t1;
                }
                else
                {
                    time = t2;
                }

                Console.WriteLine($"time = {time} s"); // 1,584895 s
                // time = 1.58 s
                decimal final_speed = initial_speed + g * time;
                Console.WriteLine($"final speed = {final_speed} m/s"); // 23,54782 m/s
                // final speed = 23.5 m/s
            }

            Console.ReadKey();
        }
    }
}
