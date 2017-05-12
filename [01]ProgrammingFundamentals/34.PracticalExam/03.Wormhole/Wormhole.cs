namespace _03.Wormhole
{
    using System;
    using System.Linq;

    namespace Wormhole
    {
        public class Wormhole
        {
            public static void Main()
            {
                int[] wormholes = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentIndex = 0;
                int steps = 0;

                while (true)
                {
                    if (currentIndex == wormholes.Length - 1 && wormholes[wormholes.Length - 1] == 0)
                        break;

                    if (wormholes[currentIndex] == 0)
                    {
                        currentIndex++;
                        steps++;
                    }
                    else
                    {
                        var oldIndex = currentIndex;
                        currentIndex = wormholes[currentIndex];
                        wormholes[oldIndex] = 0;
                    }
                }

                Console.WriteLine(steps + 1);
            }
        }
    }
}


