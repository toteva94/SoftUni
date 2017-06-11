namespace _06.MathPotato
{
    using System;
    using System.Collections.Generic;
    public class MathPotato
    {
        private static void Main()
        {
            var kids = Console.ReadLine().Split();
            var count = int.Parse(Console.ReadLine());

            var kidsCircle = new Queue<string>();
            var cycle = 1;

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

                if (isPrime(cycle))
                {
                    var firstOne = kidsCircle.Peek(); 
                    Console.WriteLine($"Prime {firstOne}");
                }
                else
                {
                    var recentlyRemoved = kidsCircle.Dequeue();
                    Console.WriteLine($"Removed {recentlyRemoved}");
                }

                cycle++;
            }

            var lastOne = kidsCircle.Dequeue();

            Console.WriteLine($"Last is {lastOne}");
        }

        public static bool isPrime(int number)
        {
            switch (number)
            {
                case 1:
                    return false;
                case 2:
                    return true;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (var i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}