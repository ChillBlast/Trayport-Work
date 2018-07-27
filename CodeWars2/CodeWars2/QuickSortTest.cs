using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars2;

namespace CodeWars2
{
    using NUnit.Framework;

    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void Test()
        {
            int[] unsortedArray1 = new int[] { 1, 2, 4, 6, 8, 0, 9, 7, 5, 3 };
            int[] sortedArray1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(sortedArray1, QuickSort.QuickSortFuncFront(unsortedArray1));
            int[] unsortedArray2 = new int[] { 1, 1, 1, 36, 4, 60, 49, 57, 0 };
            int[] sortedArray2 = new int[] { 0, 1, 1, 1, 4, 36, 49, 57, 60 };
            Assert.AreEqual(sortedArray2, QuickSort.QuickSortFuncFront(unsortedArray2));
            int[] unsortedArray3 = new int[] { 0, 3, 1, 7 };
            int[] sortedArray3 = new int[] { 0, 1, 3, 7 };
            Assert.AreEqual(sortedArray3, QuickSort.QuickSortFuncFront(unsortedArray3));


        }
    }
}

