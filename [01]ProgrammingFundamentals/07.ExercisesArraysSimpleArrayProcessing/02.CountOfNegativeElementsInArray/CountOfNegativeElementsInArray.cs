namespace _2.CountOfNegativeElementsInArray
{
    using System;
    using System.Linq;

   public class CountOfNegativeElementsInArray
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                var elements = int.Parse(Console.ReadLine());

                numbers[i] += elements;
            }
           
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    count++;
            }

           Console.WriteLine(count);
        }
    }
}
