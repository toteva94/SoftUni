namespace _03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();

            var hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();

           

            long hornetsSumPower = hornets.Sum();
            var currentHornetIndex = 0;

            for (int i = 0; i < beehives.Count; i++)
            {
                var bees = beehives[i];

                if(bees >= hornetsSumPower)
                {
                    beehives[i] -= hornetsSumPower;
                    
                    if(currentHornetIndex < hornets.Count())
                    { 
                    hornetsSumPower -= hornets[currentHornetIndex];
                    currentHornetIndex++;
                    }
                }
                else 
                {
                    beehives[i] -= hornetsSumPower;
                    if(beehives[i] < 0)
                    {
                        beehives[i] = 0;
                    }
                }

            
            }

            if (beehives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ",beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets.Skip(currentHornetIndex)));
            }
        }
    }
}
