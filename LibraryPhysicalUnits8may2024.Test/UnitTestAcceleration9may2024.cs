namespace LibraryPhysicalUnits8may2024.Test
{
    public class UnitTestAcceleration9may2024
    {
        [Fact]
        public void Test1()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Exercise 3.9");

            Console.WriteLine("A truck starts from rest and moves with a constant acceleration of 5 m/s^2");

            Console.WriteLine("Find its speed and the distance traveled after 4 s has elapsed.");

            var acceleration = new AccelerationInMeterPerSecondSquared17may2024(5);
            var t = new TimeInSeconds8may2024(4, 0);

            var speed = acceleration * t;

            Console.WriteLine("The speed is " + speed); // 20 m/s
            Assert.Equal(expected: "20 m/s", actual: speed.ToString());

            var distance = 0.5 * acceleration * t * t;

            Console.WriteLine("The distance is " + distance); // 40 m
            Assert.Equal(expected: "40 m", actual: distance.ToString());
        }

        [Fact]
        public void Test2()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Constant acceleration problems");

            Console.WriteLine("Exercise 3.10");

            Console.WriteLine("A box slides down an incline with uniform acceleration.");

            Console.WriteLine("It starts from rest and attains a speed of 2.7 m/s in 3 s.");

            Console.WriteLine("Find (a) the acceleration and (b) the distance moved in the first 6 s.");

            var speed = new VelocityInMeterPerSecond13may2024(2.7);
            var t = new TimeInSeconds8may2024(3, 0);

            var acceleration = speed / t;

            Console.WriteLine("The acceleration is " + acceleration); // 0,9 m / s^2
            Assert.Equal(expected: "0,9 m / s^2", actual: acceleration.ToString());

            var time2 = new TimeInSeconds8may2024(6, 0);

            var distance = 0.5 * acceleration * time2 * time2;
            Console.WriteLine("The distance is " + distance); // 16,200000000000003 m
            Console.WriteLine("The distance in meter = " + distance.GetInMeter()); // 16,200000000000003
            Assert.Equal(expected: 16.2, actual: distance.GetInMeter(), 0.001);
        }

        [Fact]
        public void Test3()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");

            Console.WriteLine("Constant acceleration problems");

            Console.WriteLine("Exercise 3.12");

            Console.WriteLine("A car is accelerating uniformly as it passes two checkpoints that are 30 m apart.");

            Console.WriteLine("The time taken between checkpoints is 4 s and the car's speed at the checkpoint is 5 m/s");

            Console.WriteLine("Find the car's acceleration and its speed at the second checkpoint.");

            var distance = new LengthInMeter8may2024(30, 0);

            var time = new TimeInSeconds8may2024(4, 0);

            var speed_checkpoint1 = new VelocityInMeterPerSecond13may2024(5);

            var acceleration = 2 * (distance / time - speed_checkpoint1) / time;

            Console.WriteLine("The acceleration is " + acceleration); // 1,25 m / s^2
            Assert.Equal(expected: "1,25 m / s^2", actual: acceleration.ToString());

            var speed_checkpoint2 = speed_checkpoint1 + acceleration * time;

            Console.WriteLine("The speed at the second checkpoint is " + speed_checkpoint2); // 10 m/s
            Assert.Equal(expected: "10 m/s", actual: speed_checkpoint2.ToString());
        }

        [Fact]
        public void Test4()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.16");

            Console.WriteLine("An object moving at 13 m/s slows uniformly at a rate of 2 m/s each second for a time of 6 s.");

            Console.WriteLine("Determine (a) it final speed (b) its average speed during the 6 s, and (c) the distance moved in the 6 seconds.");

            var velocity_initial = new VelocityInMeterPerSecond13may2024(13);

            var velocity_change = new VelocityInMeterPerSecond13may2024(-2);
            var each_second = new TimeInSeconds8may2024(1, 0);
            var acceleration = velocity_change / each_second;

            var time = new TimeInSeconds8may2024(6, 0);

            var velocity_final = velocity_initial + acceleration * time;
            Console.WriteLine("the final speed is " + velocity_final); // 1 m/s
            Assert.Equal(expected: "1 m/s", actual: velocity_final.ToString());

            var distance = velocity_initial * time + 0.5 * acceleration * time * time;
            Console.WriteLine("The distance is " + distance); // 42 m
            Assert.Equal(expected: "42 m", actual: distance.ToString());

            var average_speed = distance / time;
            Console.WriteLine("The average speed is " + average_speed); // 7 m/s
            Assert.Equal(expected: "7 m/s", actual: average_speed.ToString());
        }

        [Fact]
        public void Test5()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 40");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.23");

            Console.WriteLine("A ball thrown vertically upwards returns to its starting point is 4 s.");
            Console.WriteLine("Find its initial speed.");

            var acceleration = new AccelerationInMeterPerSecondSquared17may2024(-9.81);

            var time = new TimeInSeconds8may2024(2, 0);

            var initial_speed = -acceleration * time;

            Console.WriteLine("The initial speed is " + initial_speed); // 19,62 m/s
            Assert.Equal(expected: "19,62 m/s", actual: initial_speed.ToString());
        }

        [Fact]
        public void Test6()
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 50");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Oefening 25");

            Console.WriteLine("Een auto die volgens een rechte lijn rijdt, begint op t=0 bij x=0.");
            Console.WriteLine("Hij passeert het punt x = 25,0 m met een snelheid van 11,0 m/s op t = 3,00 s.");
            Console.WriteLine("Hij passeert het punt x = 385 m met een snelheid van 45,0 m/s op t = 20,0 s.");

            Console.WriteLine("Bepaal (a) de gemiddelde snelheid en");
            Console.WriteLine("       (b) de gemiddelde versnelling tussen t = 3,00 s en t = 20,0 s");

            var length1 = new LengthInMeter8may2024(25, 0.1);
            var length2 = new LengthInMeter8may2024(385, 1);

            var time1 = new TimeInSeconds8may2024(3, 0.01);
            var time2 = new TimeInSeconds8may2024(20, 0.1);

            var gemiddelde_snelheid = (length2 - length1) / (time2 - time1);
            Console.WriteLine("De gemiddelde snelheid is " + gemiddelde_snelheid); // 21,176470588235293 m/s
            Assert.Equal(expected: 21.176, actual: gemiddelde_snelheid.GetInMeterPerSecond(), tolerance: 0.01);
            // 21,2 m/s

            var velocity1 = new VelocityInMeterPerSecond13may2024(11, 0.1);
            var velocity2 = new VelocityInMeterPerSecond13may2024(45, 0.1);

            var gemiddelde_versnelling = (velocity2 - velocity1) / (time2 - time1);
            Console.WriteLine("De gemiddelde versnelling is " + gemiddelde_versnelling); // 2 m / s^2
            Assert.Equal(expected: 2, actual: gemiddelde_versnelling.GetInMeterPerSecondSquared(), tolerance: 0.01);
            // 2,00 m/s^2
        }

        [Fact]
        public void Test7()
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Oefening 27");

            Console.WriteLine("Een deeltje beweegt langs de x-as.");
            Console.WriteLine("Zijn plaats als functie van de tijd wordt gegeven door x = 6,8 t + 8,5 t^2 met t in seconden en x in meter.");
            Console.WriteLine("Wat is de versnelling als functie van de tijd?");

            // x = 6,8 t + 8,5 t^2
            // v = 6,8 + 8,5 *2 * t
            // a = 8,5 * 2
            var versnelling = new AccelerationInMeterPerSecondSquared17may2024(8.5 * 2);
            Console.WriteLine("De versnelling is " + versnelling); // 17 m / s^2
            Assert.Equal(expected: 17, actual: versnelling.GetInMeterPerSecondSquared(), tolerance: 0.1);
            // 17,0 m/s^2
        }

        [Fact]
        public void Test8()
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Beweging bij constante versnelling");
            Console.WriteLine("Oefening 33");
            Console.WriteLine("Een honkbalwerper gooit een honkbal met een snelheid van 41 m/s.");
            Console.WriteLine("Geef een schatting van de gemiddelde versnelling van de bal tijdens het werpen.");
            Console.WriteLine("Bij het gooien van de honkbal versnelt de werper de bal door een verplaatsing van circa 3,5 m, van achter het lichaam tot het punt waar deze wordt losgelaten.");

            var snelheid = new VelocityInMeterPerSecond13may2024(41);

            var verplaatsing = new LengthInMeter8may2024(3.5, 0);

            var acceleration_multiplied_with_time = snelheid;

            // s = (a t^2) / 2

            // verplaatsing = (acceleration_multiplied_with_time * t ) / 2

            var t = (2 * verplaatsing) / acceleration_multiplied_with_time;
            Console.WriteLine("t = " + t); // 0,17073170731707318 s

            var a = acceleration_multiplied_with_time / t;
            Console.WriteLine("a = " + a); // 240,14285714285714 m / s^2
            Assert.Equal(expected: 240, actual: a.GetInMeterPerSecondSquared(), tolerance: 1);
            // 240 m/s^2
        }

        [Fact]
        public void Test9()
        {
            Console.WriteLine("Natuurkunde - Giancoli - page 51");
            Console.WriteLine("Hoofdstuk 2");
            Console.WriteLine("Beweging bij constante versnelling");
            Console.WriteLine("Oefening 35");

            Console.WriteLine("Een hardloopster van wereldklasse kan in de eerste 15,0 meter van een race een topsnelheid bereiken (van circa 11,5 m/s).");
            Console.WriteLine("Wat is de gemiddelde versnelling van deze hardloopster en hoe lang doet zij erover om die snelheid te bereiken?");

            var fifteenMeter = new LengthInMeter8may2024(15, 0.1);
            var topsnelheid = new VelocityInMeterPerSecond13may2024(11.5, 0.1);

            // s = (a t^2) / 2  
            // s = (v * t) / 2
            // (2*s)/v = t
            var t = (2 * fifteenMeter) / topsnelheid;
            Console.WriteLine("t = " + t.GetInSeconds() + " seconden"); // 2,608695652173913 seconden
            Assert.Equal(expected: 2.61, actual: t.GetInSeconds(), tolerance: 0.01);
            // 2,61 s

            var gemiddelde_versnelling = topsnelheid / t;
            Console.WriteLine("De gemiddelde versnelling van de hardloopster is " + gemiddelde_versnelling); // 4,408333333333333 m / s^2
            Assert.Equal(expected: 4.41, actual: gemiddelde_versnelling.GetInMeterPerSecondSquared(), tolerance: 0.01);
            // 4,41 m/s^2
        }

        [Fact]
        public void Test10()
        {
            Console.WriteLine("Schaum's Physics");
            Console.WriteLine("Chapter3: Kinematics in one dimension");
            Console.WriteLine("page 41");
            Console.WriteLine("Constant acceleration problems");
            Console.WriteLine("Exercise 3.31");

            Console.WriteLine("A proton in a uniform electric field moves along a straight line with constant acceleration.");
            Console.WriteLine("Starting from rest it attains a velocity of 1000 km/s in a distance of 1 cm.");
            Console.WriteLine("(a) What is the acceleration?");
            Console.WriteLine("(b) What time is required to reach the given velocity?");

            var v = new VelocityInMeterPerSecond13may2024(1_000_000);

            var s = new LengthInCentimeter8may2024(1, 0);

            var a_times_t = v;

            var t = (2 * s) / a_times_t;

            var a = a_times_t / t;

            Console.WriteLine("a = " + a); // a = 50000000000000 m / s^2
            Assert.Equal(expected: 5.0E+13, actual: a.GetInMeterPerSecondSquared(), tolerance: 1);

            Console.WriteLine("t = " + t); // t = 2E-08 s
            Assert.Equal(expected: 2.0E-8, actual: t.GetInSeconds(), tolerance: 1.0E-8);
        }
    }
}
