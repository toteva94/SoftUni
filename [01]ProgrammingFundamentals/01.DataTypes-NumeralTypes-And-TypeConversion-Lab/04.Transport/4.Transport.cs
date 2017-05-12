namespace _4.Transport
{
    using System;

   public class Transport

    {
       public static void Main(string[] args)
        {
            var passengers = int.Parse(Console.ReadLine());
            var courses = (int)Math.Ceiling((double)passengers / 24);

            Console.WriteLine(courses);
        }
    }
}
