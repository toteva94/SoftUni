namespace _02.JSONstringify
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

    public class JSONstringify
    {
        public static void Main()
        {
            var students = new List<Student>();
            var inputLines = Console.ReadLine();

            while (inputLines != "stringify")
            {

                var currentStudentData = inputLines.Split(new[] { '-', '>', ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                
                var name = currentStudentData[0];
                var age = int.Parse(currentStudentData[1]);
                var grades = currentStudentData.Skip(2).Select(int.Parse).ToList();

                var currentStudent = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                };

                students.Add(currentStudent);

                inputLines = Console.ReadLine();
            }

            var output = "";

            output += "[";

            for (int i = 0; i < students.Count; i++)
            {
                var currentStudent = students[i];

                output += "{";

                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";

                output += "}";

                if(i < students.Count - 1)
                {
                    output += ",";
                }

            }

            output += "]";

            Console.WriteLine(output);
        }


    }
}
