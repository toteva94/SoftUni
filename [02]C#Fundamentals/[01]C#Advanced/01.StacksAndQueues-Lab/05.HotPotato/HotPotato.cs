namespace _05.HotPotato
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    public class HotPotato
    {
        public static void Main()
        {
            var kids = Console.ReadLine().Split();
            var count = int.Parse(Console.ReadLine());

            var kidsCircle = new Queue<string>();

            foreach (var kid in kids)
            {
                kidsCircle.Enqueue(kid);
            }

            while (kidsCircle.Count > 1)
            {
                for (var i = 1; i < count; i++)
                {
                    var firstKid = kidsCircle.Dequeue();
                    kidsCircle.Enqueue(firstKid);
                }

                var recentlyRemovedKid = kidsCircle.Dequeue();

                Console.WriteLine($"Removed {recentlyRemovedKid}");
            }

            var lastOne = kidsCircle.Dequeue();

            Console.WriteLine($"Last is {lastOne}");
        }
    }
}