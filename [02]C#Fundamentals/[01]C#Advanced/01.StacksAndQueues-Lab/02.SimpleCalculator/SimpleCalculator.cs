namespace _02.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SimpleCalculator
    {
        public static void Main()
        {
            var expression = Console.ReadLine().Split();

            var expressionParts = new Stack<string>(expression.Reverse());

            while (expressionParts.Count > 1)
            {
                var firstNumber = int.Parse(expressionParts.Pop());
                var currentOperator = expressionParts.Pop();
                var secondNumber = int.Parse(expressionParts.Pop());

                expressionParts.Push(currentOperator == "+"
                    ? (firstNumber + secondNumber).ToString()
                    : (firstNumber - secondNumber).ToString());
            }

            Console.WriteLine(expressionParts.Pop());
        }
    }
}