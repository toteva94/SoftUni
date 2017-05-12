namespace _3.SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var min = numbers.Min();
            Console.WriteLine(min);
        }
    }
}
