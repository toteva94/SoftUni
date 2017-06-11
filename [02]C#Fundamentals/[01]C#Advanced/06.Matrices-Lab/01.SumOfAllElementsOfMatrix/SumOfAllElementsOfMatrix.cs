namespace _01.SumOfAllElementsOfMatrix
{
    using System;
    using System.Linq;
    public class SumOfAllElementsOfMatrix
    {
        public static void Main()
        {
            var colsAndRows = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = colsAndRows[0];
            var columns = colsAndRows[1];

            var numbers = new int[rows, columns];

            for (var rowsIndex = 0; rowsIndex < rows; rowsIndex++)
            {
                var currentRowsElements = Console.ReadLine()
                    .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (var collIndex = 0; collIndex < columns; collIndex++)
                {
                    var value = currentRowsElements[collIndex];
                    numbers[rowsIndex, collIndex] = value;
                }
            }

            var sumOfMatrixsElements = numbers.Cast<int>().Sum();

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sumOfMatrixsElements);
        }
    }
}
