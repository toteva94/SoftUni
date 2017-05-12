namespace _02.Stateless
{
    using System;
    using System.Linq;

    public class Stateless
    {
        static void Main(string[] args)
        {
            var state = Console.ReadLine();
            var fiction = Console.ReadLine();

            var resultStr = string.Empty;

            while (state != "collapse")
            {
                for (int i = 0; i < state.Length; i++)
                {
                    foreach (var element in state[i])
                    {

                    }
                    var index = state.IndexOf(fiction, i);
                   

                    if (index > 0)
                    {
                        var currentElement = state[index];
                        resultStr = state.Re
                    }
                }

                state = Console.ReadLine();
                fiction = Console.ReadLine();
            }
        }
    }
}
