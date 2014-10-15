using System;
using System.Collections.Generic;

/* Write a method that adds two positive integer numbers represented as arrays of digits
* (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
* Each of the numbers that will be added could have up to 10 000 digits.*/

class Task08SumTwoIntLikeArr
{
    static void Main(string[] args)
    {
        int firstSize, secondSize;
        Console.WriteLine("Enter size of the first array: ");
        firstSize = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter seize of the second array: ");
        secondSize = int.Parse(Console.ReadLine());

        // I use lists instead arrays
        List<int> firstList = new List<int>(); 
        List<int> secondList = new List<int>();

        if (firstSize > secondSize) // If the first number size is bigger than second
        {
            Console.WriteLine("Initialize first array");
            firstList = InitializingArray(firstList, 0, firstSize); // Simple initializing the first list
            
            // for loop to fill the first (firstSzie - secondSize) indexes with '0'. To equal number positions.
            // This prevent out of bound exception
            for (int i = 0; i < firstSize - secondSize; i++)
            {
                secondList.Add(0);
            }
            Console.WriteLine("Initialize second array");
            secondList = InitializingArray(secondList, firstSize - secondSize, firstSize); // And filling the rest of the list with user input values
        }
        else // This is the same as the if, but when second number is bigger than first
        {
            for (int i = 0; i < secondSize - firstSize; i++)
            {
                firstList.Add(0);
            }
            Console.WriteLine("Initialize first array");
            firstList = InitializingArray(firstList, secondSize - firstSize, secondSize);
            Console.WriteLine("Initialize second array");
            secondList = InitializingArray(secondList, 0, secondSize);
        }

        CalculateSum(firstList, secondList);  // Calculating the sum
    }

    static void CalculateSum(List<int> firstList, List<int> secondList)
    {
        bool flag = false; // carry flag when we sum digits which make a number(5+7 -> 2 in cell and 1 carry)
        List<int> list = new List<int>(); // the summed number

        // Reverse for loop. Need to be done by the task. Or in the end just Array.Reverse(list); Its the same.
        // '+1' is carry bit. There is no chance to have '+2" carry bit because biggest digits are 9+9 which is 18 - 8 in cell and 1 carry
        for (int i = firstList.Count - 1; i >= 0; i--)
        {
            if (firstList[i] + secondList[i] < 10)
            {
                if (flag == true) // If there is carry
                {
                    if (firstList[i] + secondList[i] + 1 < 10)
                    {
                        list.Add(firstList[i] + secondList[i] + 1);
                        flag = false; // We don't have carry!
                    }
                    else
                    {
                        list.Add((firstList[i] + secondList[i] + 1) % 10);
                        flag = true; // We have carry!
                    }
                }
                else // He we don't have carry so just sum
                {
                    list.Add(firstList[i] + secondList[i]);
                    flag = false;
                }
            }
            else
            {
                if (flag == true)
                {
                    list.Add((firstList[i] + secondList[i]) % 10 + 1);
                }
                else
                {
                    list.Add((firstList[i] + secondList[i]) % 10);
                }
                flag = true; // Here we always have carry by the main if.
            }
        }
        PrintSumReversed(list, flag); // Printing the sum
    }

    static void PrintSumReversed(List<int> list, bool flag)
    {
        if (flag == true)
            list.Add(1); // Ok this is a trick :) When we sum 999+001 = (1) 000.
        // Well I don't have position for it(1) and just add it at the end.
                        
        // Simple print
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }

    static List<int> InitializingArray(List<int> array, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            Console.Write("array[{0}] = ", i);
            array.Add(int.Parse(Console.ReadLine()));
        }
        return array;
    }
}