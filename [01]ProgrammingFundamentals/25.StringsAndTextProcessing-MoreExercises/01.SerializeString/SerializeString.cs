namespace _01.SerializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var resultChar = new HashSet<string>();
            var index = -1;
            var resultStr = string.Empty;

            foreach (var character in input)
            {
                resultStr += character + ":";

                while (true)
                {
                    index = input.IndexOf(character, index + 1);

                    if (index < 0)
                        break;

                    resultStr += index + "/";
                }

                resultStr = resultStr.TrimEnd('/');
                resultChar.Add(resultStr);
                resultStr = string.Empty;

            }

            Console.WriteLine(string.Join(Environment.NewLine, resultChar));
        }

    }
}

