using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sorting
{
    public class MergeSort : BaseSort
    {
        public MergeSort(int[] array) : base(array) { }
        public MergeSort(int n) : base(n) { }

        public override void Sort() => Array = Sort(Array).ToArray();
        private List<int> Sort(IEnumerable<int> arr)
        {
            if (arr.Count() == 1)
                return arr.ToList();

            int half = arr.Count() / 2;
            List<int> left = Sort(arr.Take(half));
            List<int> rigth = Sort(arr.Skip(half));

            List<int> res = new List<int>();

            while (left.Count > 0 && rigth.Count > 0)
            {
                if (left[0] < rigth[0])
                {
                    res.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    res.Add(rigth[0]);
                    rigth.RemoveAt(0);
                }
            }

            res.AddRange(left);
            res.AddRange(rigth);

            return res;
        }

    }
}
