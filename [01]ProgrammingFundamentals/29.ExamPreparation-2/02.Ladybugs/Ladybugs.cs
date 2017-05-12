namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugsIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
           

            var field = new int[fieldSize];

            foreach (var ladybugIndex in ladybugsIndexes)
            {
                if (ladybugIndex < 0 || ladybugIndex >= fieldSize)
                {
                    continue;
                }

                field[ladybugIndex] = 1;
            }

            while (true)
            {
                var input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                var command = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                
                var currentLadybugIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLenght = int.Parse(command[2]);

                if (currentLadybugIndex < 0 || currentLadybugIndex >= fieldSize)
                {
                    continue;
                }
                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }

                field[currentLadybugIndex] = 0;
                var position = currentLadybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLenght;
                    }
                    else
                    {
                        position -= flyLenght;
                    }

                    if (position >= fieldSize || position < 0)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }

              
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
