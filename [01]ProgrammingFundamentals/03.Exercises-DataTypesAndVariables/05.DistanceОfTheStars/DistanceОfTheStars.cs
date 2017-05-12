namespace _5.DistanceОfTheStars
{
    using System;

    public class DistanceОfTheStars
    {
        public static void Main(string[] args)
        {
            decimal fromEarthToNearestStar = 4.22M * 9450000000000;
            decimal theCenterOfOutGalaxy = 26000M * 9450000000000;
            decimal diameterOfTheMilkyWay = 100000M * 9450000000000;
            decimal fromEarthToTheEdge = 46500000000M * 9450000000000M;

            Console.WriteLine("{0:e2}", fromEarthToNearestStar);
            Console.WriteLine("{0:e2}", theCenterOfOutGalaxy);
            Console.WriteLine("{0:e2}", diameterOfTheMilkyWay);
            Console.WriteLine("{0:e2}", fromEarthToTheEdge);
        }
    }
}
