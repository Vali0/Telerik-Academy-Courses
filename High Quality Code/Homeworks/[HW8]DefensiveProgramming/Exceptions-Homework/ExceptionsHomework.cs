using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr.Length == 0 || arr == null)
        {
            throw new ArgumentException("The given array has no elements or is null.");
        }
        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException("Start index should have a number from 0 to arr.length-1.");
        }
        if (count > arr.Length)
        {
            throw new ArgumentException("Count shouldn't be bigger than array length");
        }
        if (count + startIndex > arr.Length)
        {
            throw new ArgumentException("The sum of startIndex and counter shouldn't exceed the length of the array.");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        Debug.Assert(result.Count == count, "Returned array have lesser or bigger length than the input count.");

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (String.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentNullException("The given string is either empty or null.");
        }
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count can't be bigger than string length.");
        }
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("Count shouldn't be a negative number.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        Debug.Assert(result.Length == count, "Result string has different length than count.");

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException(String.Format(
                "The input number is either 1 or lower than it (negative number),the valid range is from [2.. {0}]", int.MaxValue));
        }
        
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        bool isPrime = CheckPrime(23);
        Console.WriteLine("23 is prime. -->{0}", isPrime);

        isPrime = CheckPrime(33);
        Console.WriteLine("33 is prime. -->{0}", isPrime);

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}