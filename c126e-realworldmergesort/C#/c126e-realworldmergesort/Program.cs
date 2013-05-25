using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c126e_realworldmergesort
{
    class Program
    {
        // http://www.reddit.com/r/dailyprogrammer/comments/1epasu/052013_challenge_126_easy_realworld_merge_sort/
        static void MergeSort(List<int> a, List<int> b)
        {
            for (int i = a.Count() - 1; i >= 0; i--)
            {
                b[i] = a[i];
                for (int k = i; k < b.Count() - 1; k++)
                {
                    if (b[k] > b[k + 1])
                    {
                        int temp = b[k];
                        b[k] = b[k + 1];
                        b[k + 1] = temp;
                    }
                    else
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> listA = new List<int>() { 692, 1, 32 };
            List<int> listB = new List<int>() { 0, 0, 0, 14, 15, 123, 692, 2431 };

            MergeSort(listA, listB);

            Console.Write("List A: ");
            foreach (int integer in listA)
                Console.Write(integer.ToString() + " ");
            Console.WriteLine();
            Console.Write("List B: ");
            foreach (int integer in listB)
                Console.Write(integer.ToString() + " ");
            Console.ReadKey();
        }
    }
}
