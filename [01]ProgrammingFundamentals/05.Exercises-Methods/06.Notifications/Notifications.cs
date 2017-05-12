namespace console
{
    using System;

    class  NumbersToWords

    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < amount; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < -999)
                {
                    Console.WriteLine("too small");
                }
                else if ((num >= 100 && num <= 999) || (num <= -100 && num >= -999))
                {
                    PrintNumber(num);
                }
                else if (num > 999)
                {
                    Console.WriteLine("too large");
                }
            }

        }

        private static void PrintNumber(int a)
        {

            if (a < 0)
            {
                Console.Write("minus ");
                a = Math.Abs(a);
            }
            int hundreds = a / 100;
            int tens = a % 100 / 10;
            int ones = a % 10;
            switch (hundreds)
            {
                case 1: Console.Write("one-hundred"); break;
                case 2: Console.Write("two-hundred"); break;
                case 3: Console.Write("three-hundred"); break;
                case 4: Console.Write("four-hundred"); break;
                case 5: Console.Write("five-hundred"); break;
                case 6: Console.Write("six-hundred"); break;
                case 7: Console.Write("seven-hundred"); break;
                case 8: Console.Write("eight-hundred"); break;
                case 9: Console.Write("nine-hundred"); break;

            }
            if (tens > 0)
            {
                Console.Write(" and ");
                if (tens == 1)
                {
                    switch (ones)
                    {
                        case 1: Console.Write("eleven"); break;
                        case 2: Console.Write("twelve"); break;
                        case 3: Console.Write("thirteen"); break;
                        case 4: Console.Write("fourteen"); break;
                        case 5: Console.Write("fifteen"); break;
                        case 6: Console.Write("sixteen"); break;
                        case 7: Console.Write("seventeen"); break;
                        case 8: Console.Write("eighteen"); break;
                        case 9: Console.Write("nineteen"); break;
                    }
                }
                else
                {
                    switch (tens)
                    {
                        case 2: Console.Write("twenty"); break;
                        case 3: Console.Write("thirty"); break;
                        case 4: Console.Write("forty"); break;
                        case 5: Console.Write("fifty"); break;
                        case 6: Console.Write("sixty"); break;
                        case 7: Console.Write("seventy"); break;
                        case 8: Console.Write("eighty"); break;
                        case 9: Console.Write("ninety"); break;
                    }
                    if (ones > 0)
                    {
                        Console.Write(" ");
                        switch (ones)
                        {
                            case 1: Console.Write("one"); break;
                            case 2: Console.Write("two"); break;
                            case 3: Console.Write("three"); break;
                            case 4: Console.Write("four"); break;
                            case 5: Console.Write("five"); break;
                            case 6: Console.Write("six"); break;
                            case 7: Console.Write("seven"); break;
                            case 8: Console.Write("eight"); break;
                            case 9: Console.Write("nine"); break;
                        }
                    }
                }
                Console.WriteLine();
            }
            else
            {
                if (ones > 0)
                {
                    Console.Write(" and ");
                    switch (ones)
                    {
                        case 1: Console.Write("one"); break;
                        case 2: Console.Write("two"); break;
                        case 3: Console.Write("three"); break;
                        case 4: Console.Write("four"); break;
                        case 5: Console.Write("five"); break;
                        case 6: Console.Write("six"); break;
                        case 7: Console.Write("seven"); break;
                        case 8: Console.Write("eight"); break;
                        case 9: Console.Write("nine"); break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
