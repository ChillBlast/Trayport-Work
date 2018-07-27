using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    class MergeSort
    {
        public static int[] MergeSortDivide(int[] unsortedArray)
        {
            int mid = (unsortedArray.Length / 2);
            int[] unsortedArray1 = Array.FindAll(unsortedArray, index => index <= mid);
            int[] unsortedArray2 = Array.FindAll(unsortedArray, index => index > mid);
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                do
                {
                
                } while (b);
            }
            //if (unsortedArray1.Length > 2 || unsortedArray2.Length > 2)
            //{
            //    unsortedArray1 = MergeSortDivide(unsortedArray1);
            //    unsortedArray2 = MergeSortDivide(unsortedArray2);
            //}


        }
    }
}
