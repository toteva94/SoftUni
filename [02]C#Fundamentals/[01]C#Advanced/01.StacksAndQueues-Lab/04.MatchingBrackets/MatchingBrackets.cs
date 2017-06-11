namespace _04.MatchingBrackets
{
    using System;
    using System.Collections.Generic;
    public class MatchingBrackets
    {
        public static void Main()
        {
            var expession = Console.ReadLine();

            var result = new Stack<int>();

            for (var i = 0; i < expession.Length; i++)
            {
                var element = expession[i];

                switch (element)
                {
                    case '(':
                        result.Push(i);
                        break;
                    case ')':
                        var startIndex = result.Pop();
                        var contents = expession.Substring(startIndex, i - startIndex + 1);
                        Console.WriteLine(contents);
                        break;
                }
            }
        }
    }
}