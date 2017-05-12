﻿namespace _01.RabbitHole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RabbitHole
    {
        public static void Main()
        {
            var commands = Console.ReadLine().Split().ToList();
            var energy = int.Parse(Console.ReadLine());

            var currentIndex = 0;
            var lastBomb = false;

            while (energy > 0)
            {
                var commandParams = commands[currentIndex].Split('|').ToList();
                var currentCommand = commandParams[0];
                lastBomb = false;

                if (currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                var value = int.Parse(commandParams[1]);

                switch (currentCommand)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % commands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % commands.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        commands.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;
                        break;
                }

                if (commands[commands.Count - 1] != "RabbitHole")
                    commands.RemoveAt(commands.Count - 1);
                commands.Add("Bomb|" + energy);

            }

            if (energy <= 0 && lastBomb)
                Console.WriteLine("You are dead due to bomb explosion!");
            else if (energy <= 0 && !lastBomb)
                Console.WriteLine("You are tired. You can't continue the mission.");
        }
    }
}
