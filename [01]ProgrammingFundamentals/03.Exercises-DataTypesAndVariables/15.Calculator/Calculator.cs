namespace _15.Calculator
{
    using System;

    public class Calculator
    {
       public static void Main(string[] args)
        {
            var operand1 = int.Parse(Console.ReadLine());
            var calcOperator = Console.ReadLine();
            var operand2 = int.Parse(Console.ReadLine());

            switch (calcOperator)
            {
                case "+": Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}"); break;
                case "-": Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}"); break;
                case "*": Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}"); break;
                case "/": Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}"); break;


                default: Console.WriteLine($"{operand1} % {operand2} = {operand1 % operand2}");
                    break;
            }
        }
    }
}
