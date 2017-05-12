namespace _03.CriticalBreakpoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Line
    {
        public long X1 { get; set; }

        public long Y1 { get; set; }

        public long X2 { get; set; }

        public long Y2 { get; set; }
    }
    public class CriticalBreakpoint
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var linesData = new List<Line>();

            while (input != "Break it.")
            {
                var inputParams = input.Split().Select(long.Parse).ToArray();

                var currentLine = new Line
                {
                    X1 = inputParams[0],
                    Y1 = inputParams[1],
                    X2 = inputParams[2],
                    Y2 = inputParams[3],
                };

                linesData.Add(currentLine);

                input = Console.ReadLine();
            }

            var hasBreakpoint = true;
            BigInteger actualRatio = 0;

            foreach (var line in linesData)
            {
                long criticalRatio = Math.Abs((line.X2 + line.Y2) - (line.X1 + line.Y1));

                if(actualRatio == 0 && criticalRatio != 0)
                {
                    actualRatio = criticalRatio;
                }

                if ((criticalRatio != actualRatio) && (criticalRatio != 0))
                {
                    hasBreakpoint = false;
                    break;
                }
            }

            if (hasBreakpoint)
            {
                BigInteger totalRatio = BigInteger.Pow(actualRatio, linesData.Count);
                BigInteger criticalBreakpoint = 0;
                BigInteger.DivRem(totalRatio, linesData.Count, out criticalBreakpoint);

                foreach (var line in linesData)
                {
                    Console.WriteLine($"Line: [{line.X1}, {line.Y1}, {line.X2}, {line.Y2}]");
                }

                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}
