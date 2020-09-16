using System;

namespace Algorithms.Sorting
{
    public abstract class BaseSort
    {
        public int[] Array { get; set; }
        private int Temp;

        public BaseSort(int[] array) => Array = array;

        public BaseSort(int n = 10)
        {
            Random rng = new Random();
            Array = new int[n];

            for (int i = 0; i < n; i++)
                Array[i] = rng.Next(n * 2);
        }

        public void Swap(int i, int j)
        {
            Temp = Array[i];
            Array[i] = Array[j];
            Array[j] = Temp;
        }

        public abstract void Sort();
        public override string ToString() => string.Join(',', Array);
    }
}
