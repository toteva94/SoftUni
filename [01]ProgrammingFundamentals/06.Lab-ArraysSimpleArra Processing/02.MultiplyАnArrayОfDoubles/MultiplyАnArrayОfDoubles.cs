namespace _2.MultiplyАnArrayОfDoubles
{
    using System;
    using System.Linq;

    public class MultiplyАnArrayОfDoubles
    {
       public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= p;
            }

            var result = string.Join(" ",nums);
            Console.WriteLine(result);
        }
    }
}
