using System;
using System.Collections.Generic;

class Task14QuickSort
{
    /* Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your array: ");
        int size = int.Parse(Console.ReadLine()); //Getting array size
        int[] array = new int[size];
        Console.WriteLine("Initialize your array");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine()); //Initializing the array
        }
        Console.WriteLine("QuickSort By Iterative Method");
        QuickSort_Iterative(array, 0, size - 1);
        for (int i = 0; i < size; i++)
            Console.Write(array[i] + " ");
    }

    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;
            while (numbers[right] > pivot)
                right--;
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    struct QuickPosInfo
    {
        public int left;
        public int right;
    };

    static public void QuickSort_Iterative(int[] numbers, int left, int right)
    {
        if (left >= right)
            return; // Invalid index range
        List<QuickPosInfo> list = new List<QuickPosInfo>();
        QuickPosInfo info;
        info.left = left;
        info.right = right;
        list.Insert(list.Count, info);
        while (true)
        {
            if (list.Count == 0)
                break;
            left = list[0].left;
            right = list[0].right;
            list.RemoveAt(0);
            int pivot = Partition(numbers, left, right);   
            if (pivot > 1)
            {
                info.left = left;
                info.right = pivot - 1;
                list.Insert(list.Count, info);
            }
            if (pivot + 1 < right)
            {
                info.left = pivot + 1;
                info.right = right;
                list.Insert(list.Count, info);
            }
        }
    }
}