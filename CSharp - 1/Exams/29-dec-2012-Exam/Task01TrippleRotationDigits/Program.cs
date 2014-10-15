using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        char temp;
        int length = input.Length;
        for (int i = 0; i < 3; i++)
        {
            if (array[length-1] == '0')
            {
                    length--;
            }

            else
                for (int j = length - 1; j > 0; j--)
                {
                    temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                }
        }
        for(int i = 0;i<length;i++)
            Console.Write(array[i]);
    }
}