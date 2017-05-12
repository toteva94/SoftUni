namespace _06.FilterBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var salary = new Dictionary<string, decimal>();
            var age = new Dictionary<string, long>();
            var position = new Dictionary<string, string>();

            while(input != "filter base")
            {
                var elements = input.Split();
                var name = elements[0];
                var secondElement = elements[elements.Length - 1];

                long intNumber = 0;
                var decimalNumber = 0M;

                if (long.TryParse(secondElement, out intNumber))
                {
                    age[name] = intNumber;
                }
                else if(decimal.TryParse(secondElement, out decimalNumber))
                {
                    salary[name] = decimalNumber;
                }
                else
                {
                    position[name] = secondElement;
                }

                input = Console.ReadLine();
            }


            input = Console.ReadLine();
             
            if(input == "Age")
            {
                foreach (var person in age.Keys)
                {
                    Console.WriteLine($"Name: {person}");
                    Console.WriteLine($"Age: {age[person]}");
                    Console.WriteLine("====================");
                }
            }
            else if (input == "Salary")
            {
                foreach (var person in salary.Keys)
                {
                    Console.WriteLine($"Name: {person}");
                    Console.WriteLine($"Salary: {salary[person]:f2}");
                    Console.WriteLine("====================");
                }
            }
            else
            {
                foreach (var person in position.Keys)
                {
                    Console.WriteLine($"Name: {person}");
                    Console.WriteLine($"Position: {position[person]}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
