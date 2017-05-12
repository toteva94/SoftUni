namespace _03.CamelsBack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var buildings = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camelsBack = int.Parse(Console.ReadLine());

            var rounds = 0;

            if (buildings.Count == camelsBack)
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            else
            {
                while (buildings.Count > camelsBack)
                {
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);
                    rounds++;
                }


                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }

        }

    }
}

