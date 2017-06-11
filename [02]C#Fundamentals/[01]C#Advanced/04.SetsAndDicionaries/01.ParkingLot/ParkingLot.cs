namespace _01.ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class ParkingLot
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (true)
            {
                if (input == "END")
                {
                    break;
                }
                var commandsAndPlates = input
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var command = commandsAndPlates[0];
                var plate = commandsAndPlates[1];

                if (command == "IN")
                {
                    parking.Add(plate);
                }
                else
                {
                    if (parking.Any())
                    {
                        parking.Remove(plate);
                    }
                }
                input = Console.ReadLine();
            }

            if (parking.Any())
            {
                foreach (var plate in parking)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}