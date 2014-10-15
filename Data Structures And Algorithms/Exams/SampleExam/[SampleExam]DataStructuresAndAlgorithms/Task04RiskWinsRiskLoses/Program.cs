using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04RiskWinsRiskLoses
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialNumber = Console.ReadLine();
            string targetNumber = Console.ReadLine();
            int numberOfForbidden = int.Parse(Console.ReadLine());
            string[] forbidden = new string[numberOfForbidden];

            for (int i = 0; i < numberOfForbidden; i++)
            {
                forbidden[i] = Console.ReadLine();
            }

            int[] number = ConvertToIntArray(initialNumber);
            int[] target = ConvertToIntArray(targetNumber);

            int count = 0;
            int direction = 1;

            for (int i = 0; i < number.Length; i++)
            {
                int startDigit = number[i];
                int endDigit = target[i];
                count += Math.Min(Math.Abs(startDigit - endDigit), Math.Min(startDigit - endDigit + 10, endDigit - startDigit + 10));
            }

            //for (int i = 0; i < number.Length; i++)
            //{
            //    bool firstDirection = false;
            //    bool secondDirection = false;

            //    if (number[i] < target[i])
            //    {
            //        direction = 1;
            //    }
            //    else
            //    {
            //        direction = -1;
            //    }

            //    int oldNumberPosition = number[i];
            //    int oldCount = count;
            //    while (number[i] != target[i])
            //    {
            //        number[i] += direction;
            //        count++;
            //        if (number[i] == 10)
            //        {
            //            number[i] = 0;
            //        }
            //        if (number[i] == -1)
            //        {
            //            number[i] = 9;
            //        }

            //        foreach (var item in forbidden)
            //        {
            //            int convertedNumber = Convert.ToInt32(item[i]) - 48;
            //            if (number[i] == convertedNumber)
            //            {
            //                number[i] = oldNumberPosition;
            //                direction = -direction;
            //                count = oldCount;

            //                if (firstDirection)
            //                {
            //                    secondDirection = true;
            //                }
            //                else
            //                {
            //                    firstDirection = true;
            //                }

            //                break;
            //            }
            //        }

            //        if (firstDirection && secondDirection)
            //        {
            //            break;
            //        }
            //    }

            //    if (firstDirection && secondDirection)
            //    {
            //        count = -1;
            //        break;
            //    }
            //}

            Console.WriteLine(count);
        }

        static int[] ConvertToIntArray(string number)
        {
            int[] result = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                result[i] = Convert.ToInt32(number[i]) - 48;
            }

            return result;
        }
    }
}