namespace _3.Greeting
{
    using System;
  
    class Greeting
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {secondName}. You are {age} years old.");
        }
    }
}
