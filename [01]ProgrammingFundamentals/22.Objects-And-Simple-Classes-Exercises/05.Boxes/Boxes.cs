namespace _05.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public static int CalculateWidth(Point UpperLeft, Point UpperRight)
        {
            return (int)Point.CalculateDistance(UpperLeft, UpperRight);
        }

        public static int CalculateHeight(Point UpperLeft, Point BottomLeft)
        {
            return (int)Point.CalculateDistance(UpperLeft, BottomLeft);
        }

        public int Width
        {
            get
            {
                return CalculateWidth(UpperLeft, UpperRight);
            }
        }

        public int Height
        {
            get
            {
                return CalculateHeight(UpperLeft, BottomLeft);
            }
        }
        public static int CalculatePerimeter(int width, int height)
        {
            return (int)((2 * width) + (2 * height));
        }

        public int Perimeter
        {
            get
            {
                return CalculatePerimeter(Width, Height);
            }
        }
        public static int CalculateArea(int width, int height)
        {
            return (int)(width * height);
        }

        public int Area
        {
            get
            {
                return CalculateArea(Width, Height);
            }
        }
    }


    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }

    }
    public class Boxes
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var boxesData = new List<Box>();

            while (input != "end")
            {
                var currentBox = ReadBox(input);

                boxesData.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxesData)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.Perimeter}");
                Console.WriteLine($"Area: {box.Area}");
            }
        }

        private static Box ReadBox(string input)
        {
            var PointParts = input
                .Split(new char[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return new Box
            {
                UpperLeft = new Point
                {
                    X = PointParts[0],
                    Y = PointParts[1]
                },

                UpperRight = new Point
                {
                    X = PointParts[2],
                    Y = PointParts[3]
                },

                BottomLeft = new Point
                {
                    X = PointParts[4],
                    Y = PointParts[5]
                },

                BottomRight = new Point
                {
                    X = PointParts[6],
                    Y = PointParts[7]
                }
            };

        }


    }
}
