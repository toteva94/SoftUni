namespace _01.ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShootListElements
    {
        public static void Main()
        {

            var input = Console.ReadLine();

            var numList = new List<int>();
            var lastRemoved = -1;
            var output = string.Empty;

            while (input != "stop")
            {
                if (input == "bang")
                {
                    if (numList.Count == 0)
                    {
                        output = "nobody left to shoot! last one was {0}";
                        break;
                    }

                    var avarage = numList.Average();
                    lastRemoved = RemoveNumbers(numList, avarage);
                    DecrementNumbers(numList);
                }
                else
                {
                    var parsedInput = int.Parse(input);
                    numList.Insert(0, parsedInput);
                }

                input = Console.ReadLine();
            }

            if (numList.Count > 0 && output == string.Empty)
                Console.WriteLine("survivors: {0}", string.Join(" ", numList));
            else if (numList.Count == 0 && output == string.Empty)
                Console.WriteLine("you shot them all. last one was {0}", lastRemoved);
            else
                Console.WriteLine(output, lastRemoved);


        }

        private static void DecrementNumbers(List<int> numList)
        {
            for (int i = 0; i < numList.Count; i++)
            {
                numList[i]--;
            }
        }

        public static int RemoveNumbers(List<int> numList, double avarage)
        {
            var result = -1;

            if (numList.Count == 1)
            {
                Console.WriteLine("shot {0}", numList[0]);
                result = numList[0];
                numList.RemoveAt(0);
                return result;
            }

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] < avarage)
                {
                    Console.WriteLine("shot {0}", numList[i]);
                    result = numList[i];
                    numList.RemoveAt(i);
                    break;
                }

            }

            return result;
        }
    }
}
