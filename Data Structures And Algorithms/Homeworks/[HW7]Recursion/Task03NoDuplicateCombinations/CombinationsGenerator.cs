using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03NoDuplicateCombinations
{
    public class CombinationsGenerator
    {
        private readonly int combinationType;
        private List<int[]> tempList;

        public CombinationsGenerator(int vectorType)
        {
            this.combinationType = vectorType;
        }

        public List<int[]> GetAllCombinations(int size)
        {
            tempList = new List<int[]>();
            GenerateCombinationsRecursively(new int[size], 0, 1);

            return tempList;
        }

        private void GenerateCombinationsRecursively(int[] vector, int currentIndex, int currentValueFrom)
        {
            if (currentIndex == vector.Length)
            {
                var newIntArray = new int[vector.Length];
                vector.CopyTo(newIntArray, 0);
                tempList.Add(newIntArray);

                return;
            }

            for (int i = currentValueFrom; i <= combinationType; i++)
            {
                vector[currentIndex] = i;
                GenerateCombinationsRecursively(vector, currentIndex + 1, i + 1);
            }
        }
    }
}