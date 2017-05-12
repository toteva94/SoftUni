namespace _09.Altitude
{
    using System;
    using System.Linq;

   public class Altitude
    {
       public static void Main()
        {
            string[] altitudeChanges = Console.ReadLine().Split(' ').ToArray();
            long currentAltitude = long.Parse(altitudeChanges[0]);
            for (long i = 1, j = 2; i < altitudeChanges.Length; i++, j++)
            {
                if (altitudeChanges[i].Contains("up"))
                {
                    currentAltitude += long.Parse(altitudeChanges[j]);
                }
                else if (altitudeChanges[i].Contains("down"))
                {
                    currentAltitude -= long.Parse(altitudeChanges[j]);
                    if (currentAltitude <= 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }
            if (currentAltitude > 0)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", currentAltitude);
            }
        }
    }
}
