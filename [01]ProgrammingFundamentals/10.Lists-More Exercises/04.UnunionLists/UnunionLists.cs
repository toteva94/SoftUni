namespace _04.UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            // var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
            // var n = int.Parse(Console.ReadLine());
            // 
            // for (int i = 0; i < n; i++)
            // {
            //     var lists = Console.ReadLine().Split().Select(int.Parse).ToList();
            // 
            //     foreach (var number in lists)
            //     {
            //         if (primalList.Contains(number))
            //             primalList.Remove(number);
            //         else
            //             primalList.Add(number);
            //     }
            // 
            // }
            // 
            // primalList.Sort();
            // Console.WriteLine(string.Join(" ", primalList));

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 0; j < list.Count; j++)
                {
                    if (numbers.Contains(list[j]))
                    {
                        numbers.RemoveAll(x => x == list[j]);
                    }
                    else
                    {
                        numbers.Add(list[j]);

                    }
                }
            }
            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }      
    }
}
