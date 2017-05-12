namespace _3.ExchangeVariableValues
{
    using System;
  
    public class ExchangeVariableValues
    {
       public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
