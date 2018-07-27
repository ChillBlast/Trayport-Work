using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    public interface ISayHi
    {
        void SayHi();
    }

    public class Person : IComparable, ISayHi
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            var otherPerson = obj as Person;

            return -this.Age.CompareTo(otherPerson.Age);
        }

        //public override string ToString()
        //{
        //    return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        //}
        public void SayHi()
        {
            Console.WriteLine(this.Name+" says hi");
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            // Create an unsorted array of string elements
            //string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };
            var unsorted = new []{ new Person("bob",32), new Person("fred", 17), new Person("john", 56) };

            foreach (var person in unsorted)
            {
                person.SayHi();
            }

            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

    }
}



//{
//    class QuickSort2
//    {
//        public static bool validSort(int[] sortedArray)
//        {
//            for (int i = 0; i < sortedArray.Length - 1; i++)
//            {
//                if (sortedArray[i] > sortedArray[i + 1])
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        public static int[] QuickSortFuncFront(int[] unsortedArray)
//        {
//            return QuickSortFuncBack(unsortedArray);

//        }
//        private static int[] QuickSortFuncBack(int[] unsortedArray)
//        {
//            if (unsortedArray.Length < 2) return unsortedArray;
//            List<int> sortedList = new List<int>();
//            List<int> sortedList1 = new List<int>();
//            List<int> sortedList2 = new List<int>();

//            int pivot = unsortedArray[unsortedArray.Length - 1];
//            for (int i = 0; i < unsortedArray.Length - 1; i++)
//            {
//                if (unsortedArray[unsortedArray.Length - 1] < unsortedArray[i])
//                {
//                    sortedList1.Add(unsortedArray[i]);
//                }
//                else
//                {
//                    sortedList2.Insert(0, unsortedArray[i]);
//                }
//            }
//            sortedList.AddRange(sortedList2);
//            sortedList1.Insert(0, pivot);
//            sortedList.AddRange(sortedList1);
//            int[] sortedArray = (sortedList).ToArray();
//            if (validSort(sortedArray))
//            {
//                return sortedArray;
//            }
//            else
//            {
//                List<int> sortedArray1 = QuickSortFuncBack(sortedList1.ToArray()).ToList();
//                List<int> sortedArray2 = QuickSortFuncBack(sortedList2.ToArray()).ToList();
//                sortedArray2.AddRange(sortedArray1);
//                return sortedArray2.ToArray();

//            }
//        }
//    }
//}
