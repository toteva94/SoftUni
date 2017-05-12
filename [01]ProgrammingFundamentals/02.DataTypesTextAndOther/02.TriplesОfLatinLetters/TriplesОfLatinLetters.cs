namespace _2.TriplesОfLatinLetters
{
    using System;

    class TriplesОfLatinLetters
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        var firstLetter = (char)(i + 'a');
                        var secondLetter = (char)(j + 'a');
                        var thirdLetter = (char)(k + 'a');

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
