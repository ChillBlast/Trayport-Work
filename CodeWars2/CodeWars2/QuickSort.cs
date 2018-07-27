using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    class QuickSort
    {
        public static bool validSort(int[] sortedArray)
        {
            for (int i = 0; i < sortedArray.Length-1; i++)
            {
                if (sortedArray[i] > sortedArray[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] QuickSortFuncFront(int[] unsortedArray)
        {
            return QuickSortFuncBack(unsortedArray);

        }
        //static Random rnd = new Random();
        private static int[] QuickSortFuncBack(int[] unsortedArray)
        {
        if (unsortedArray.Length < 2) return unsortedArray;
        List<int> sortedList = new List<int>();
        List<int> sortedList1 = new List<int>();
        List<int> sortedList2 = new List<int>();

            int pivot = unsortedArray[unsortedArray.Length - 1];
            //int pivot = unsortedArray[rnd.Next(unsortedArray.Length)];
            //sortedList.Add(unsortedArray[unsortedArray.Length - 1]);
            for (int i = 0; i < unsortedArray.Length-1; i++)
            {
                if (unsortedArray[unsortedArray.Length - 1] < unsortedArray[i])
                {
                    sortedList1.Add(unsortedArray[i]);
                }
                else
                {
                    sortedList2.Insert(0, unsortedArray[i]);
                }
            }
            sortedList.AddRange(sortedList2);
            sortedList1.Insert(0, pivot);
            sortedList.AddRange(sortedList1);
            int[] sortedArray = (sortedList).ToArray();
            //sortedList1.Clear();
            //sortedList2.Clear();
            if (validSort(sortedArray))
            {
                return sortedArray;
            }
            else
            {
                //valid = -1;
                //unsortedArray = sortedArray;
                List<int> sortedArray1 = QuickSortFuncBack(sortedList1.ToArray()).ToList();
                List<int> sortedArray2 = QuickSortFuncBack(sortedList2.ToArray()).ToList();
                sortedArray2.AddRange(sortedArray1);
                return sortedArray2.ToArray();

            }

            //int[] test = new int[10];
            //return test;
        }
    }
}
