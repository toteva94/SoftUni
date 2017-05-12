namespace _04.DrawAfilledSquare
{
    using System;

    public class DrawAfilledSquare
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintFilledSquare(number);
        }

        public static void PrintFilledSquare(int num)
        {
            PrintHeaderAndFooter(num);
            for (int i = 0; i < num - 2; i++)
            {
                PrintBody(num);
            }
            PrintHeaderAndFooter(num);
        }

        public static void PrintHeaderAndFooter(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }

        public static void PrintBody(int num)
        {
            Console.Write('-');
            for (int rows = 1; rows < num; rows++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine('-');
        }
    }
}
