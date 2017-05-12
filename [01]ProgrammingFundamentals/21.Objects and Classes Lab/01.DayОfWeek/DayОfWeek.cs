namespace _01.DayОfWeek
{
    using System;
    using System.Globalization;

    public class DayОfWeek
    {
        public static void Main()
        {
            var date = Console.ReadLine();
            var dateParse = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateParse.DayOfWeek);
        }
    }
}
