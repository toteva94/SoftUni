namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
    public class DistanceBetweenPoints
    { 
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }

        private static Point ReadPoint()
        {
            var PointParts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                X = PointParts[0],
                Y = PointParts[1]
            };
        }
    }
}
