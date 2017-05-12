namespace _04.CubicMessages
{
    using System;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-z]+)(?<rightPart>[^a-zA-z]+)?$";

            var encryptedLine = Console.ReadLine();

            while (encryptedLine != "Over!")
            {
                var match = Regex.Match(encryptedLine, pattern);

                if (!match.Success)
                {
                    encryptedLine = Console.ReadLine();
                    continue;
                }

                var messageLength = int.Parse(Console.ReadLine());

                var message = match.Groups["message"].Value;

                if (message.Length != messageLength)
                {
                    encryptedLine = Console.ReadLine();
                    continue;
                }

                var leftPart = match.Groups["leftPart"].Value;
                var rightPart = match.Groups["rightPart"].Value;

                var verificationCode = string.Empty;

                var verificationIndexes = leftPart + rightPart;

                foreach (var ch in verificationIndexes)
                {
                    int index;
                    var isDigit = int.TryParse(ch.ToString(), out index);
                    var isValidIndex = index >= 0 && index < message.Length;

                    if (isDigit && isValidIndex)
                    {
                        var currentMessageChar = message[index];
                        verificationCode += currentMessageChar;
                    }
                    else
                    {
                        verificationCode += " ";
                    }

                }

                Console.WriteLine($"{message} == {verificationCode}");

                encryptedLine = Console.ReadLine();
            }
        }
    }
}
