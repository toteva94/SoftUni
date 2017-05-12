namespace _01.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var schoolbook = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!schoolbook.ContainsKey(name))
                    schoolbook[name] = new List<double>();
                schoolbook[name].Add(grade);

            }


            foreach (var pair in schoolbook)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;

                var average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                    Console.Write($"{grade:f2} ");

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
