namespace Task04MaxEqualSequence
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task04LongestSequenceOfEqualNumbers;

    [TestClass]
    public class LongestEqualSequenceTests
    {
        [TestMethod]
        public void UniqueLongestSequence()
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 1, 1, 1
            };

            List<int> expectedSequence = new List<int>()
            {
                1, 1, 1
            };

            var resultSequence = FindLongestEqualSequence.LongestEqualSequence(numbers);

            Assert.AreEqual(string.Join(", ", expectedSequence), string.Join(", ", resultSequence));
        }

        [TestMethod]
        public void OnlyOneSequence(){
            List<int> numbers = new List<int>()
            {
                1, 1, 1
            };

            List<int> expectedSequence = new List<int>()
            {
                1, 1, 1
            };

            var resultSequence = FindLongestEqualSequence.LongestEqualSequence(numbers);

            Assert.AreEqual(string.Join(", ", expectedSequence), string.Join(", ", resultSequence));
        }

        [TestMethod]
        public void FirstOneSmallSequenceThenBestSequenceShouldReturnBest()
        {
            List<int> numbers = new List<int>()
            {
                1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 1, 2
            };

            List<int> expectedSequence = new List<int>()
            {
                1, 1, 1, 1, 1
            };

            var resultSequence = FindLongestEqualSequence.LongestEqualSequence(numbers);

            Assert.AreEqual(string.Join(", ", expectedSequence), string.Join(", ", resultSequence));
        }
    }
}