using System;

class Task13MergeSort
{
    /*
    * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
     * This kind of sorting uses divide and conquer algorithm. 
     * Read about it here: http://en.wikipedia.org/wiki/Divide_and_conquer_algorithm"
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

        Console.WriteLine("Sorted array: ");
        MergeSort(array, 0, size - 1);
        foreach (var item in array)
        {
            Console.Write(item + " ");	 
        }
    }

    static public void Merging(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);
        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }
        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];
        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];
        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void MergeSort(int[] numbers, int left, int right)
    {
        int mid;
        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSort(numbers, left, mid);
            MergeSort(numbers, (mid + 1), right);
            Merging(numbers, left, (mid + 1), right);
        }
    }
}