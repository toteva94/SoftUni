namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
               var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var distance = CalculateDistance(firstPoint, secondPoint);

                    if(distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }
        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]

            };
        }
    }
}
