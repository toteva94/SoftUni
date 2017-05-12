namespace _6.OddNumbersAtOddPositions
{
    using System;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {nums[i]}");
                }
            }
        }
    }
}
