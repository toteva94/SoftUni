namespace _02.MinMethod
{
    using System;

    public class Program
    {
       public static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var minOfFirstAndSecond = GetMin(firstNumber, secondNumber);
            var result = Math.Min(thirdNumber, minOfFirstAndSecond);

            Console.WriteLine(result);
        }

        public static int GetMin(int firstNumber, int secondNumber)
        {
            var minNum = Math.Min(firstNumber, secondNumber);
            return minNum;
        }
    }
}
