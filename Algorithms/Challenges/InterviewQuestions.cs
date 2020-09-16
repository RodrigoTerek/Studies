using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Algorithms.Challenges
{
    public class InterviewQuestions
    {

        // { 1, 2, 3, 4 }  6

        /// <summary>
        /// Given an array of positive integers and a integer k,
        /// find the smallest length of subarray that, adding its members, is at least K 
        /// </summary>
        public int FindSubarraySum(int[] arr, int k)
        {
            int res = -1,
                sum = arr[0],
                i = 0,
                j = 0;

            while (i < arr.Length)
            {
                if (sum >= k)
                {
                    if ((j - i + 1) < res || res == -1)
                        res = j - i + 1;
                    sum -= arr[i];
                    i++;
                    continue;
                }

                if (j < arr.Length - 1)
                    j++;

                sum += arr[j];
            }

            return res;
        }


    }
}
