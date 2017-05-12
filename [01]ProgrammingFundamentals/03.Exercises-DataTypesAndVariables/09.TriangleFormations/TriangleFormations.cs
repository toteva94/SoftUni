using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            bool noRightAngles = false;
            bool valid = true;
            if((a + b > c) && (a + c > b) && (b + c > a))
                Console.WriteLine("Triangle is valid.");
            else
            {
                valid = false;
                Console.WriteLine("Invalid Triangle.");
            }
                
            if((a == b) && (a == c) && (b == c))
            {
                noRightAngles = true;
                Console.WriteLine("Triangle has no right angles");
            }
                
            var maxSide = Math.Max(a, Math.Max(b, c));
            if (maxSide == a && noRightAngles == false && valid)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            if (maxSide == b && noRightAngles == false && valid)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            if (maxSide == c && noRightAngles == false && valid)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
        }
    }
}
