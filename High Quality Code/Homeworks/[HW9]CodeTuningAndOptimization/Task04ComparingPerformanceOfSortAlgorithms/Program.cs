using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04ComparingPerformanceOfSortAlgorithms
{
    class Program
    {
        public static void DisplayPerformance(Action method, string methodName)
        {
            Console.WriteLine(methodName + " starting: ");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            method();
            timer.Stop();
            Console.WriteLine(methodName + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");
        }

        private static void InsertionSortAlgorithmPerformance<T>(T[] array)
        where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Algorithms.InsertionSort(cloneArray);
        }

        private static void SelectionSortAlgorithmPerformance<T>(T[] array)
        where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Algorithms.SelectionSort(cloneArray);
        }

        private static void QuicksortAlgorithmPerformance<T>(T[] array)
        where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Algorithms.Quicksort(cloneArray, 0, cloneArray.Length - 1);
        }

        private static void LambdaAlgorithmPerformance<T>(T[] array)
        where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Algorithms.LambdaSort(cloneArray);
        }

        private static void LinqAlgorithmPerformance<T>(T[] array)
        where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Algorithms.LinqSort(cloneArray);
        }

        public static void ArraySorting<T>(T[] array)
            where T : IComparable<T>
        {
            DisplayPerformance(() => InsertionSortAlgorithmPerformance(array), "InsertionSort Algorithm Performance");
            DisplayPerformance(() => SelectionSortAlgorithmPerformance(array), "SelectionSort Algorithm Performance");
            DisplayPerformance(() => QuicksortAlgorithmPerformance<T>(array), "Quicksort Algorithm Performance");
            DisplayPerformance(() => LambdaAlgorithmPerformance<T>(array), "Lambda Algorithm Performance");
            DisplayPerformance(() => LinqAlgorithmPerformance<T>(array), "Linq Algorithm Performance");
        }


        static void Main()
        {
            int arrayLength = 10000;
            int[] intsArray = GenerateRandomArray.GetRandomIntArray(arrayLength);
            double[] doublesArray = GenerateRandomArray.GetRandomDoubleArray(arrayLength);
            string[] stringsArray = GenerateRandomArray.GetRandomStringArray(arrayLength, 100);

            Console.WriteLine("Unsorted arrays:");
            Console.WriteLine("Int Array:");
            ArraySorting<int>(intsArray);
            Console.WriteLine("Double Array:");
            ArraySorting<double>(doublesArray);
            Console.WriteLine("String Array:");
            ArraySorting<string>(stringsArray);

            Array.Sort(intsArray);
            Array.Sort(doublesArray);
            Array.Sort(stringsArray);

            Console.WriteLine();
            Console.WriteLine("Sorted arrays:");
            Console.WriteLine("Int Array:");
            ArraySorting<int>(intsArray);
            Console.WriteLine("Double Array:");
            ArraySorting<double>(doublesArray);
            Console.WriteLine("String Array:");
            ArraySorting<string>(stringsArray);

            intsArray = intsArray.OrderByDescending(x => x).ToArray();
            doublesArray = doublesArray.OrderByDescending(x => x).ToArray();
            stringsArray = stringsArray.OrderByDescending(x => x).ToArray();

            Console.WriteLine();
            Console.WriteLine("Reversed sorted arrays:");
            Console.WriteLine("Int Array:");
            ArraySorting<int>(intsArray);
            Console.WriteLine("Double Array:");
            ArraySorting<double>(doublesArray);
            Console.WriteLine("String Array:");
            ArraySorting<string>(stringsArray);
        }
    }
}
