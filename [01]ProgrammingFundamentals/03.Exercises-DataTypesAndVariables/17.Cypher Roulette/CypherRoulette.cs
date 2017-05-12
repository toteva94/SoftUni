namespace _17.Cypher_Roulette
{
    using System;

    public class CypherRoulette
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;
            string lastStr = string.Empty;

            bool addToEnd = true;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();

                if (str.Equals(lastStr))
                {
                    result = string.Empty;
                    i--;
                    continue;
                }
            
                lastStr = str;
               

                if (str.Equals("spin"))
                {
                    addToEnd = !addToEnd;
                    i--;
                }
                else if (addToEnd == true)
                {
                    result += str;
                }
                else if (addToEnd == false)
                {
                    result = str + result;
                }
            }

            Console.WriteLine(result);
        }
    }
}
