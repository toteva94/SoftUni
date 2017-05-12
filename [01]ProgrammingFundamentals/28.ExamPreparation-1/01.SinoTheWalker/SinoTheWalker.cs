namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var timeInput = Console.ReadLine();
            var leavingTime = DateTime.ParseExact(timeInput, "HH:mm:ss", CultureInfo.InvariantCulture);
            var numberOfSteps = decimal.Parse(Console.ReadLine());
            var timeInSeconds = decimal.Parse(Console.ReadLine());

            var secondsInADay = 60 * 60 * 24;
            var totalTime = (numberOfSteps * timeInSeconds) % secondsInADay;

            var arrivalTime = leavingTime.AddSeconds((double)totalTime).TimeOfDay;
            Console.WriteLine($"Time Arrival: {arrivalTime}");

        }
    }
}
