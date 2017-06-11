namespace _01.StudentsResults
{
    using System;

    public class StudentsResults
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            Console.WriteLine($"{"Name",-10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average",7}|");

            for (var i = 0; i < count; i++)
            {
                var currentStudentResult = Console.ReadLine()
                    .Split(new[] {' ', '-', ','}, StringSplitOptions.RemoveEmptyEntries);

                var student = currentStudentResult[0];
                var cAdvResult = double.Parse(currentStudentResult[1]);
                var cOopResult = double.Parse(currentStudentResult[2]);
                var advOopResult = double.Parse(currentStudentResult[3]);
                var average = (cAdvResult + cOopResult + advOopResult) / 3;

                Console.WriteLine($"{student,-10}|{cAdvResult,7:F2}|{cOopResult,7:F2}|{advOopResult,7:F2}|{average,7:F4}|");
            }
        }
    }
}
