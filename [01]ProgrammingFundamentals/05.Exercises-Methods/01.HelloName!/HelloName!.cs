namespace _01.HelloName_
{
    using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            GetHelloSentence(name);
        }

        public static void GetHelloSentence(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
