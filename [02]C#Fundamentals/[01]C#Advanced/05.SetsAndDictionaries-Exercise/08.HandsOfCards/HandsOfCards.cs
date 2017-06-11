using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace _08.HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var playersAndCards = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "JOKER")
                {
                    break;
                }

                var currentNameAndCards = inputLine
                    .Split(new[] {':'});
                var currentPlayer = currentNameAndCards[0];
                var currentCards = currentNameAndCards[1]
                    .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                if (!playersAndCards.ContainsKey(currentPlayer))
                {
                    playersAndCards[currentPlayer] = new HashSet<string>();
                }

                foreach (var currentCard in currentCards)
                {
                    playersAndCards[currentPlayer].Add(currentCard);
                }

            }

            PrintScore(playersAndCards);

        }
    

    private static void PrintScore(Dictionary<string, HashSet<string>> playersAndCards)
        {
            foreach (var playerAndCard in playersAndCards)
            {
                var score = CalculateScore(playerAndCard.Value);
                Console.WriteLine($"{playerAndCard.Key}: {score}");
            }
        }

        private static int CalculateScore(HashSet<string> cards)
        {
            var totalScore = 0;

            foreach (var card in cards)
            {
                var type = card.Last();
                var power = card.Substring(0,card.Length - 1);

                int currentCardScore;
                var isDigit = int.TryParse(power, out currentCardScore);

                if (!isDigit)
                {
                    switch (power)
                    {
                        case "J":
                            currentCardScore = 11;
                            break;
                        case "Q":
                            currentCardScore = 12;
                            break;
                        case "K":
                            currentCardScore = 13;
                            break;
                        default:
                            currentCardScore = 14;
                            break;
                    }
                }

                switch (type)
                {
                    case 'S':
                        currentCardScore *= 4;
                        break;
                    case 'H':
                        currentCardScore *= 3;
                        break;
                    case 'D':
                        currentCardScore *= 2;
                        break;
                    default:
                        currentCardScore *= 1;
                        break;
                }

                totalScore += currentCardScore;
            }

            return totalScore;
        }
    }
}
