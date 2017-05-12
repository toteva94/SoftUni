namespace _03.PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        static void PrintTriangle(int num)
        {
            for (int rows = 1; rows <= num; rows++)
            {
                PrintLine(rows);
            }
            for (int rows2 = num - 1; rows2 >= 1; rows2--)
            {
                PrintLine(rows2);
            }
        }

        private static void PrintLine(int r)
        {
            for (int cols = 1; cols <= r; cols++)
            {
                Console.Write(cols + " ");
            }

            Console.WriteLine();
        }
    }
}
