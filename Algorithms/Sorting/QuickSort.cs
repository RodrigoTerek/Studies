using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sorting
{
    public class QuickSort : BaseSort
    {
        public QuickSort(int[] array) : base(array) { }
        public QuickSort(int n) : base(n) { }

        public override void Sort() => Sort(0, Array.Length - 1);
        private void Sort(int begin, int end)
        {
            if (begin >= end)
                return;

            int pivot = Array[(begin + end) / 2];
            int index = Partition(begin, end, pivot);

            Sort(begin, index-1);
            Sort(index , end);
        }

        private int Partition(int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (Array[left] < pivot)
                    left++;

                while (Array[right] > pivot)
                    right--;

                if (left <= right)
                {
                    Swap(left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

    }
}
