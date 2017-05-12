namespace _06.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Batteries
    {
        public static void Main()
        {
            var capacities = Console.ReadLine().Split().Select(double.Parse).ToList();
            var usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToList();
            var stressHours = int.Parse(Console.ReadLine());

            var totalHours = 0.0;
            var statusInPercentage = 0.0;
            var currentBattery = 1;
            
            for (int i = 0; i < capacities.Count; i++)
            {
                totalHours = capacities[i] - (usagePerHour[i] * stressHours);
                statusInPercentage = (totalHours * 100.0) / capacities[i];
                

                if(totalHours > 0)
                {
                    Console.WriteLine($"Battery {currentBattery}: {totalHours:f2} mAh ({statusInPercentage:f2})%");
                }
                else
                {
                   Console.WriteLine($"Battery {currentBattery}: dead (lasted {Math.Ceiling(capacities[i] / usagePerHour[i])} hours)");
                }
                
                currentBattery++;
            }
}
    }
}
