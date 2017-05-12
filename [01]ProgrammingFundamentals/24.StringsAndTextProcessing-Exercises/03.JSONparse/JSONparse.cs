namespace _03.JSONparse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }
    }

    public class JSONparse
    {
        public static void Main()
        {
            var studentsData = new List<Student>();

            var input = Console.ReadLine().Split(new char[] {'}'},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length - 1; i++)
            {
                var currentStudent = input[i].Split(new char[] { '[', '}', ':', '"', ',', ' ', '{' , ']'}, StringSplitOptions.RemoveEmptyEntries);

                var newStudent = new Student
                {
                    Name = currentStudent[1],
                    Age = int.Parse(currentStudent[3]),
                    Grades = currentStudent.Skip(5).Select(int.Parse).ToList()
                };

                studentsData.Add(newStudent);
                
            }



            foreach (var student in studentsData)
            {
                if(student.Grades.Count > 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
            }
        }
    }
}
