namespace _5.CalculateTriangleArea
{
    using System;

    public class CalculateTriangleArea
    {
       public static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var triangleArea = GetTriangleArea(width, height);

            Console.WriteLine(triangleArea);
        }

        public static double GetTriangleArea(double a, double b)
        {
            var area = a * b / 2;
            return area;
        }
    }
}
