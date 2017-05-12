namespace _3.ExactProductofRealNumbers
{
    using System;

    public class ExactProductofRealNumbers
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            decimal sum = decimal.Parse(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                sum *= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
