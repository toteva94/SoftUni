namespace _01.CharityMarathon
{
    using System;

   public class CharityMarathon
    {
       public static void Main()
        {
            var marathonDay = double.Parse(Console.ReadLine());
            var runnersCount = double.Parse(Console.ReadLine());
            var avarageLaps = double.Parse(Console.ReadLine());
            var lapLenght = double.Parse(Console.ReadLine());
            var trackCapacity = double.Parse(Console.ReadLine());
            var donationPerKilometer = decimal.Parse(Console.ReadLine());

            var maximumRunners = trackCapacity * marathonDay;
            var totalRunners = 0d;

            if (runnersCount > maximumRunners)
            {
                totalRunners = maximumRunners;
            }
            else
            {
                totalRunners = runnersCount;
            }

            var totalMeters = totalRunners * avarageLaps * lapLenght;
            var totalKilometers = totalMeters / 1000;
            var totalMoneyRaised = (decimal)totalKilometers * donationPerKilometer;

            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}
