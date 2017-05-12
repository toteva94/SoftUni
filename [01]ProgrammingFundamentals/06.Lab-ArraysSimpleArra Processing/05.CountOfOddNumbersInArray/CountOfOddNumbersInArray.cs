namespace _5.CountOfOddNumbersInArray
{
    using System;
    using System.Linq;
 
   public class CountOfOddNumbersInArray
    {
       public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
