namespace _02.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var input = Console.ReadLine();

          

            while (input != "end")
            {
                var commandParts = input.Split();
                var command = commandParts[0];

                switch (command)
                {
                    case "reverse":
                        var reverseStart = int.Parse(commandParts[2]);
                        var reverseCount = int.Parse(commandParts[4]);

                        if (isValid(array, reverseStart, reverseCount))
                        {
                            Reverse(array, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        var sortStart = int.Parse(commandParts[2]);
                        var sortCount = int.Parse(commandParts[4]);

                        if (isValid(array, sortStart, sortCount))
                        {
                            Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                            break;

                    case "rollLeft":
                        var leftCount = int.Parse(commandParts[1]);

                        if (leftCount >= 0)
                        {
                            RollLeft(array, leftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":
                        var rightCount = int.Parse(commandParts[1]);

                        if (rightCount >= 0)
                        {
                            RollRight(array, rightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            
                Console.WriteLine($"[{string.Join(", ", array)}]");
            
        }


        private static void RollRight(List<string> array, int rightCount)
        {
            var rotations = rightCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                var lastElement = array[array.Count - 1];

                for (int j = array.Count - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = lastElement;
            }
        }

        private static void RollLeft(List<string> array, int leftCount)
        {
            var rotations = leftCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                var firstElement = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Count - 1] = firstElement;
            }
        }

        private static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }

        private static void Sort(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount, null);
        }

        private static bool isValid(List<string> array, int start, int count)
        {
            var result = start >= 0
                && start < array.Count
                && count >= 0
                && (start + count) <= array.Count;

            return result;
        }

    }
}
