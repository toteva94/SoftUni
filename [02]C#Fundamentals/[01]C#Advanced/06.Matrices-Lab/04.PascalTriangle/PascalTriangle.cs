namespace _04.PascalTriangle
{
    using System;
    public class PascalTriangle
    {
        public static void Main()
        {
            //Get triangle hight
            var height = int.Parse(Console.ReadLine());

            var triangle = new long[height][];

            //Initialize the top element
            triangle[0] = new long[1];
            triangle[0][0] = 1;

            //Calculate the Pascal's triangle
            for (var rowIndex = 0; rowIndex < height; rowIndex++)
            {

                triangle[rowIndex] = new long[rowIndex + 1]; //Get triangle's columns 
                triangle[rowIndex][0] = 1;  //Initialize null column

                for (var colIndex = 1; colIndex < rowIndex; colIndex++)
                {
                    triangle[rowIndex][colIndex] = triangle[rowIndex - 1][colIndex] +
                                                   triangle[rowIndex - 1][colIndex - 1];

                }

                triangle[rowIndex][rowIndex] = 1; //Initialize last colum
            }

            //Print the Pascal's triangle
            for (var rowIndex = 0; rowIndex < triangle.Length; rowIndex++)
            {
                for (var colIndex = 0; colIndex < triangle[rowIndex].Length; colIndex++)
                {
                    Console.Write($"{triangle[rowIndex][colIndex]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
