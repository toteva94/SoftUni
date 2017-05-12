namespace _02.ArrayManipulator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var currentCommand = input.Split();
                var commandName = currentCommand[0];

                switch (commandName)
                {
                    case "exchange":
                        var index = int.Parse(currentCommand[1]);
                        inputArray = Exchange(inputArray, index);
                        break;
                    case "max":
                        var evenOrOdd = FindEvenOrOdd(inputArray, currentCommand[1]);
                        FindMaxElement(inputArray, evenOrOdd);
                        break;
                    case "min":
                        evenOrOdd = FindEvenOrOdd(inputArray, currentCommand[1]);
                        FindMinElement(inputArray, evenOrOdd);
                        break;
                    case "first":
                        var count = int.Parse(currentCommand[1]);
                        evenOrOdd = FindEvenOrOdd(inputArray, currentCommand[2]);
                        FindFirstElements(inputArray, count, evenOrOdd);
                        break;
                    case "last":
                        count = int.Parse(currentCommand[1]);
                        evenOrOdd = FindEvenOrOdd(inputArray, currentCommand[2]);
                        FindLastElements(inputArray, count, evenOrOdd);
                        break;

                }
            }

            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        private static void FindLastElements(int[] inputArray, int count, int[] evenOrOdd)
        {
            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var lastElements = evenOrOdd.Reverse().Take(count).Reverse().ToArray();
            Console.WriteLine($"[{string.Join(", ", lastElements)}]");
        }

        private static void FindFirstElements(int[] inputArray, int count, int[] evenOrOdd)
        {
            if(count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var firstElements = evenOrOdd.Take(count).ToArray();

            Console.WriteLine($"[{string.Join(", ",firstElements)}]");

        }

        private static int[] FindEvenOrOdd(int[] inputArray, string v)
        {
            int[] evenOrOddElements;

            if (v == "even")
            {
                evenOrOddElements = inputArray.Where(x => x % 2 == 0).ToArray();
            }
            else
            {
                evenOrOddElements = inputArray.Where(x => x % 2 == 1).ToArray();
            }

            return evenOrOddElements;
        }

        private static void FindMinElement(int[] inputArray, int[] evenOrOdd)
        {

            if (!evenOrOdd.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var minElement = evenOrOdd.Min();
            var minElementIndex = Array.LastIndexOf(inputArray, minElement);
            Console.WriteLine(minElementIndex);
        }

        private static void FindMaxElement(int[] inputArray, int[] evenOrOdd)
        {

            if (!evenOrOdd.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var maxElement = evenOrOdd.Max();
            var maxElementIndex = Array.LastIndexOf(inputArray, maxElement);
            Console.WriteLine(maxElementIndex);
        }

        private static int[] Exchange(int[] inputArray, int index)
        {
            var indexIsValid = index >= 0 && index < inputArray.Length;

            if (!indexIsValid)
            {
                Console.WriteLine("Invalid index");
                return inputArray;
            }

            var leftPart = inputArray.Take(index + 1);
            var rightPart = inputArray.Skip(index + 1);

            var manipulatedArray = rightPart.Concat(leftPart).ToArray();
            return manipulatedArray;
        }
    }
}
