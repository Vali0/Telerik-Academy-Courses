namespace Task04LongestSequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FindLongestEqualSequence
    {
        static void Main(string[] args)
        {
            string line = "";
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter single number on different line (empty line or whitespace to end)");

            do
            {
                line = Console.ReadLine();
                bool canParse = TryToParse(line);

                if (canParse)
                {
                    numbers.Add(int.Parse(line));
                }
            }
            while (!String.IsNullOrWhiteSpace(line));

            var result = LongestEqualSequence(numbers);
            Console.WriteLine(string.Join(", ", result));
        }

        public static List<int> LongestEqualSequence(List<int> numbers)
        {
            int bestStartIndex = 0;
            int bestEndIndex = 0;
            int maxSequence = 0;

            int tempStartIndex = 0;
            int tempSequence = 0;

            int len = numbers.Count;
            int currentMember = numbers[0];
            for (int i = 1; i < len; i++)
            {
                if (i != len - 1)
                {
                    if (currentMember != numbers[i])
                    {
                        tempSequence = i - tempStartIndex;
                        if (maxSequence < tempSequence)
                        {
                            bestStartIndex = tempStartIndex;
                            bestEndIndex = i;
                            maxSequence = tempSequence;
                        }

                        currentMember = numbers[i];
                        tempStartIndex = i;
                    }
                }
                else
                {
                    tempSequence = i - tempStartIndex;
                    if (maxSequence < tempSequence)
                    {
                        bestStartIndex = tempStartIndex;
                        if (currentMember == numbers[i])
                        {
                            bestEndIndex = i + 1;
                        }
                        else
                        {
                            bestEndIndex = i;
                        }
                        maxSequence = tempSequence;
                    }
                }
            }

            List<int> resultSequence = new List<int>();

            for (int i = bestStartIndex; i < bestEndIndex; i++)
            {
                resultSequence.Add(numbers[i]);
            }

            return resultSequence;
        }

        private static bool TryToParse(string input)
        {
            int number = 0;
            bool isParsed = Int32.TryParse(input, out number);

            return isParsed;
        }
    }
}