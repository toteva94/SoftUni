namespace _03.SortArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortArrayOfStrings
    {
        static void Main()
        {
            //  var input = Console.ReadLine().Split().ToList();

            //  for (var i = 1; i < input.Count; i++)
            //{

            // var j = i - 1;
            // while ((j >= 0) && (input[j].CompareTo(input[i]) > 0))
            // {
            // input[j + 1] = input[j];

            //j--;
            //  }

            //  }

            // Console.WriteLine(string.Join(" ",input));

            List<string> input = Console.ReadLine().Split(' ').ToList();
            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < input.Count - 1; i++)
                {
                    var present = input[i];
                    var next = input[i + 1];

                    if ((present.CompareTo(next) == 1))
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        unsorted = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }

    }
}
