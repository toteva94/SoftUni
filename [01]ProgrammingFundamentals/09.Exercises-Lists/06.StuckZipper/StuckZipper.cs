namespace _06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var idealDigitsNumber = CalculateIdealDigitsNumber(list1, list2);
            RemoveNeedlessElements(list1,idealDigitsNumber);
            RemoveNeedlessElements(list2,idealDigitsNumber);

            var insertionIndex = 1;

            for (int i = 0; i < list1.Count; i++)
            {
                var currentNumber = list1[i];

                list2.Insert(Math.Min(insertionIndex,list2.Count), currentNumber);

                insertionIndex += 2;
            }

            Console.WriteLine(string.Join(" ",list2));
        }

        private static void RemoveNeedlessElements(List<int> list, int idealDigitsNumber)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentNumber = list[i];
                var currentNumberOfDigits = CalculateDigitsNumber(currentNumber);

                if (currentNumberOfDigits > idealDigitsNumber)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        private static int CalculateIdealDigitsNumber(List<int> list1, List<int> list2)
        {
            var idealDigitsNumber = int.MaxValue;

            foreach (var number in list1)
            {
                var numberOfDigits = CalculateDigitsNumber(number);
                if (numberOfDigits < idealDigitsNumber)
                    idealDigitsNumber = numberOfDigits;
            }

            foreach (var number in list2)
            {
                var numberOfDigits = CalculateDigitsNumber(number);
                if (numberOfDigits < idealDigitsNumber)
                    idealDigitsNumber = numberOfDigits;
            }

            return idealDigitsNumber;
        }

        public static int CalculateDigitsNumber(int number)
        {
            var numberOfDigits = 0;

            while (number > 0)
            {
                numberOfDigits++;
                number /= 10;
            }

            return numberOfDigits;
        }
    }
}
