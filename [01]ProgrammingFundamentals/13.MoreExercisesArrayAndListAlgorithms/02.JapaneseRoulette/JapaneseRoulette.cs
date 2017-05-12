namespace _02.JapaneseRoulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JapaneseRoulette
    {
        public static void Main()
        {
            var cylinder = Console.ReadLine().Split().Select(int.Parse).ToList();
            var players = Console.ReadLine().Split();

            var hasBeenShot = false;

            for (int i = 0; i < players.Length; i++)
            {
                var currentPlayerParams = players[i].Split(',');

                var rotations = int.Parse(currentPlayerParams[0]);
                var direction = currentPlayerParams[1];

                if (direction == "Right")
                    SpinRight(cylinder, rotations);
                else
                    SpinLeft(cylinder, rotations);

                var bulletIndex = FindBullet(cylinder);

                if (bulletIndex == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    hasBeenShot = true;
                    break;
                }

                SpinRight(cylinder, 1);
            }

            if(!hasBeenShot)
                Console.WriteLine("Everybody got lucky!");

        }

        private static int FindBullet(List<int> cylinder)
        {
            var bulletIndex = -1;

            for (int i = 0; i < cylinder.Count; i++)
            {
                if (cylinder[i] == 1)
                {
                    bulletIndex = i;
                    break;
                }   
            }

            return bulletIndex;
        }

        public static void SpinLeft(List<int> cylinder, int rotations)
        {
            rotations = rotations % cylinder.Count;

            for (int i = 0; i < rotations; i++)
            {
                var firstElement = cylinder[0];

                for (int j = 0; j < cylinder.Count - 1; j++)
                {
                    cylinder[j] = cylinder[j + 1];
                }

                cylinder[cylinder.Count - 1] = firstElement;
            }
        }

        public static void SpinRight(List<int> cylinder, int rotations)
        {
            rotations = rotations % cylinder.Count;

            for (int i = 0; i < rotations; i++)
            {
                var lastElement = cylinder[cylinder.Count - 1];

                for (int j = cylinder.Count - 1; j > 0; j--)
                {
                    cylinder[j] = cylinder[j - 1];
                }

                cylinder[0] = lastElement;
            }
        }
    }
}
