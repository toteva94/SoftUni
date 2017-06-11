using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.AcademyGraduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var studentsData = new SortedDictionary<string,List<double>>();

            for (var i = 0; i < count; i++)
            {
                var currentStudent = Console.ReadLine();
                var currentGrades = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => double.Parse(n,CultureInfo.InvariantCulture))
                    .ToArray();

                if (!studentsData.ContainsKey(currentStudent))
                {
                    studentsData[currentStudent] = new List<double>();
                }

                foreach (var grade in currentGrades)
                {
                    studentsData[currentStudent].Add(grade);
                }

            }

            foreach (var studentAndGrades in studentsData)
            {
               

                Console.WriteLine($"{studentAndGrades.Key} is graduated with {studentAndGrades.Value.Average()}");
            }
        }
    }
}