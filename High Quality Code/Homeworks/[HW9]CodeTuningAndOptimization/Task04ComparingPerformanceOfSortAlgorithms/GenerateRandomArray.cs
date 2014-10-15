using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04ComparingPerformanceOfSortAlgorithms
{
    class GenerateRandomArray
    {
        private static Random randomNumber = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~`!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?";

        public static int[] GetRandomIntArray(int length)
        {
            int[] value = new int[length];

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = randomNumber.Next(int.MinValue, int.MaxValue);
            }

            return value;
        }

        public static double[] GetRandomDoubleArray(int length)
        {
            double[] value = new double[length];

            for (int i = 0; i < value.Length; i++)
            {
                int sign = randomNumber.Next(0, 2);
                if (sign == 0)
                {
                    value[i] = randomNumber.NextDouble() * double.MaxValue;
                }
                else
                {
                    value[i] = randomNumber.NextDouble() * double.MinValue;
                }
            }

            return value;
        }

        public static string[] GetRandomStringArray(int length, int stringMaxSize)
        {
            string[] value = new string[length];

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = GetRandomString(randomNumber.Next(1, stringMaxSize + 1));
            }

            return value;
        }

        public static string GetRandomString(int size)
        {
            char[] buffer = new char[size];
            int length = chars.Length;

            for (int i = 0; i < size; i++)
            {
                buffer[i] = chars[randomNumber.Next(length)];
            }

            return new string(buffer);
        }
    }
}