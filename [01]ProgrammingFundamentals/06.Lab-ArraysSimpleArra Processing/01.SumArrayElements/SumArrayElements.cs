namespace _1.SumArrayElements
{
    using System;

   public class SumArrayElements
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numArray = new int[n];

            for (int i = 0; i < numArray.Length; i++)
            {
                var nums = int.Parse(Console.ReadLine());
                numArray[i] += nums;
            }

            var sum = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }

            Console.WriteLine(sum);
        }
    }
}
