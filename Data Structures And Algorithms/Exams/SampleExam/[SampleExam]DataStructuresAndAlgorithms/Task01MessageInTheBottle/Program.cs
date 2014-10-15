using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01MessageInTheBottle
{
    public class State
    {
        public string Obtained { get; set; }

        public string Remained { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string secredCode = Console.ReadLine();
            string cipher = Console.ReadLine();
            var tokens = new Dictionary<char, string>();
            var letter = '\0';

            for (int i = 0; i < cipher.Length; i++)
            {
                if (cipher[i] >= 'A' && cipher[i] <= 'Z')
                {
                    tokens.Add(cipher[i], "");
                    letter = cipher[i];
                }
                else
                {
                    tokens[letter] += cipher[i];
                }
            }

            var queue = new Queue<State>();
            queue.Enqueue(
                new State()
                {
                    Obtained = "",
                    Remained = secredCode
                });
            var results = new List<string>();
            
            while (queue.Count > 0)
            {
                var currentState = queue.Dequeue();

                foreach (var token in tokens)
                {
                    if (currentState.Remained.StartsWith(token.Value))
                    {
                        var newState = new State()
                        {
                            Obtained = currentState.Obtained + token.Key,
                            Remained = currentState.Remained.Remove(0, token.Value.Length)
                        };

                        if (newState.Remained.Length == 0)
                        {
                            results.Add(newState.Obtained);
                        }
                        else
                        {
                            queue.Enqueue(newState);
                        }
                    }
                }
            }

            Console.WriteLine(results.Count());
            results.Sort();
            foreach (var message in results)
            {
                Console.WriteLine(message);
            }
        }
    }
}