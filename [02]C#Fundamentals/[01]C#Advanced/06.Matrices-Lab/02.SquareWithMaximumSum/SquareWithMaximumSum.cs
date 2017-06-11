namespace _02.SquareWithMaximumSum
{
    using System;
    using System.Linq;

    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            //Declare and initialize the matrix
            var matrixSize = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSize[0];
            var columns = matrixSize[1];

            var numbers = new int[rows, columns];

            for (var rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                var currentRowElements = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (var colIndex = 0; colIndex < columns; colIndex++)
                {
                    var currentValue = currentRowElements[colIndex];
                    numbers[rowIndex, colIndex] = currentValue;
                }
            }

            //Find the maximum sum platform of size 2x2
            var bestSum = int.MinValue;
            var bestRowIndex = 0;
            var bestColIndex = 0;

            for (var rowIndex = 0; rowIndex < rows - 1; rowIndex++)
            {
                for (var colIndex = 0; colIndex < columns - 1; colIndex++)
                {
                    var currentSum = numbers[rowIndex, colIndex] + numbers[rowIndex, colIndex + 1]
                                     + numbers[rowIndex + 1, colIndex] + numbers[rowIndex + 1, colIndex + 1];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRowIndex = rowIndex;
                        bestColIndex = colIndex;
                    }
                }
            }

            //Print the result

            Console.WriteLine($"{numbers[bestRowIndex,bestColIndex]} {numbers[bestRowIndex,bestColIndex + 1]}");
            Console.WriteLine($"{numbers[bestRowIndex + 1,bestColIndex]} {numbers[bestRowIndex + 1,bestColIndex + 1]}");
            Console.WriteLine($"{bestSum}");
        }
    }
}
