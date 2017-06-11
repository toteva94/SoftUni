namespace _02.SoftUniParty
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    public class SoftUniParty
    {
        public static void Main()
        {
            var reservationsList = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                reservationsList.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                reservationsList.Remove(input);
                input = Console.ReadLine();
            }

            if (reservationsList.Any())
            {
                Console.WriteLine(reservationsList.Count);

                foreach (var guestNumber in reservationsList)
                {
                    Console.WriteLine(guestNumber);
                }
            }
            else
            {
                Console.WriteLine(reservationsList.Count);
            }
        }
    }
}