namespace _2.CirclePerimeter_12_Digits_Precision_
{
    using System;

   public class CirclePerimeter
    {
       public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}" , 2 * Math.PI * radius);
        }
    }
}
