namespace _01.ArrayContainsElement
{
    using System;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numberToCheck = int.Parse(Console.ReadLine());

            var isInList = false;

            foreach (var number in numbers)
            {
                if(number == numberToCheck)
                {
                    isInList = true;
                    Console.WriteLine("yes");
                }
            }

            if(!isInList)
                Console.WriteLine("no");
        }
    }
}
