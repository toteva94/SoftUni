namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }

        public string PrintTopic()
        {
            return $"Exercises: {Topic}";
        }

        public string PrintCourseName()
        {
            return $"Problems for exercises and homework for the \"{CourseName}\" course @ SoftUni.";
        }

        public string PrintJudgeContestLink()
        {
            return $"Check your solutions here: {JudgeContestLink}";
        }
    }

    public class Exercises
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var exercises = new List<Exercise>();

            while (input != "go go go")
            {
                var currentExercise = ReadExercise(input);

                exercises.Add(currentExercise);

                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine(exercise.PrintTopic());
                Console.WriteLine(exercise.PrintCourseName());
                Console.WriteLine(exercise.PrintJudgeContestLink());

                var count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }

        public static Exercise ReadExercise(string input)
        {
            var exerciseElements = input
                .Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            return new Exercise
            {
                Topic = exerciseElements[0],
                CourseName = exerciseElements[1],
                JudgeContestLink = exerciseElements[2],
                Problems = exerciseElements.Skip(3).ToList()
            };
        }

    }
}

