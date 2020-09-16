using System;

namespace Algorithms.Sorting
{
    public class InsertionSort : BaseSort
    {
        public InsertionSort(int[] array) : base(array) { }
        public InsertionSort(int n) : base(n) { }

        public override void Sort()
        {
            int i, j;

            for (j = i = 1; i < Array.Length; j = ++i)
            {
                while (j > 0 && Array[j] < Array[j - 1])
                {
                    Swap(j, j - 1);
                    j--;
                }
            }
        }

    }
}
