using Algorithms.Challenges;
using Algorithms.Data_Structure;
using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Algorithms!\n\n");

            InterviewQuestions d = new InterviewQuestions();

            int res = d.FindSubarraySum(new int[] { 1, 2, 3, 4 }, 6);
            Console.WriteLine(res);




        }

    }
}
