using System;

namespace Algorithms.Sorting
{
    public class BubbleSort : BaseSort
    {
        public BubbleSort(int[] array) : base(array) { }
        public BubbleSort(int n) : base(n) { }

        public override void Sort()
        {
            int i, j;
            for (i = 0; i < Array.Length; i++)
                for (j = i; j < Array.Length; j++)
                    if (Array[i] > Array[j])
                        Swap(i, j);
        }

    }
}
