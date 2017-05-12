namespace _01.HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceInMeters = decimal.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var speed = 1000;
            var flapsPerSecond = 100;

            var metersTraveled = (wingFlaps / speed) * distanceInMeters;
            var flapsSeconds = wingFlaps / flapsPerSecond;
            var secondsForResting = (wingFlaps / endurance) * 5;
            var secondsPassed = flapsSeconds + secondsForResting;

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}
