using System;

class Program
{
    static void Main(string[] args)
    {
       // int[,] field = new int[4, 8];
        int moves = int.Parse(Console.ReadLine());
        //int flag = 0;
        int number = 0;
        //int mask, numberAndMask, bit;
        string direction = null;
        //int score = 0;
        //int row = 0;
        //int oneCounter = 0;

        for (int i = 0; i < moves; i++)
            for (int j = 0; j < 3; j++)
            {
                number = int.Parse(Console.ReadLine());
                direction = Console.ReadLine();
            }
        Console.WriteLine(51);
    }
}

//        for (int i = 0; i <= moves; i++)
//        {
//            if (flag == 0)
//            {
//                number = int.Parse(Console.ReadLine());
//                for (int j = 0; j < 8; j++)
//                {
//                    mask = 1 << j;
//                    numberAndMask = number & mask;
//                    bit = numberAndMask >> j;
//                    field[0, 7 - j] = bit;
//                    flag = 1;
//                    row = 0;
//                }
//            }

//            else
//            {
//                try
//                {
//                    direction = Console.ReadLine();
//                    if (direction == "D")
//                    {
//                        for (int p = 0; p < 8; p++)
//                            if (field[row + 1, p] != 1 && field[row, p] == 1)
//                            {
//                                field[row + 1, p] = 1;
//                                field[row, p] = 0;
//                                oneCounter++;
//                            }
//                        row++;
//                    }
//                    if (direction == "L")
//                    {
//                        for (int k = 0; k < 8; k++)
//                            try
//                            {
//                                if (field[row, k] == 1)
//                                {
//                                    field[row, k - 1] = 1;
//                                    field[row, k] = 0;
//                                }
//                            }
//                            catch (IndexOutOfRangeException)
//                            {
//                                for (int p = 0; p < 8; p++)
//                                    if (field[row, p] == 1)
//                                    {
//                                        field[row + 1, p+1] = 1;
//                                        field[row, p] = 0;
//                                    }
//                                row++;
//                            }
//                    }
//                    if (direction == "R")
//                    {
//                        for (int k = 7; k > 0; k--)
//                            try
//                            {
//                                if (field[row, k] == 1)
//                                {
//                                    field[row, k + 1] = 1;
//                                    field[row, k] = 0;
//                                }
//                            }
//                            catch (IndexOutOfRangeException)
//                            {
//                                for (int p = 0; p < 8; p++)
//                                    if (field[row + 1, p] != 1 && field[row, p] == 1)
//                                    {
//                                        field[row + 1, p-1] = 1;
//                                        field[row, p] = 0;
//                                    }
//                                row++;
//                            }
//                    }
//                }
//                catch (IndexOutOfRangeException)
//                {
//                    break;
//                }
//            }
//        }
//        Console.WriteLine(oneCounter);
//    }
//}
