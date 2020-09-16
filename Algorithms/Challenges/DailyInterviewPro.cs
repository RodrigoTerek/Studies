using Algorithms.Data_Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms.Challenges
{
    public class DailyInterviewPro
    {

        /// <summary>
        /// You are given two linked-lists representing two non-negative integers.
        /// The digits are stored in reverse order and each of their nodes contain a single digit.
        /// Add the two numbers and return it as a linked list.
        /// </summary>
        public void AddNumbersInLists(List<int> a, List<int> b)
        {
            string aux = "", res;
            int i, vrA, vrB;

            for (i = a.Count - 1; i >= 0; i--)
                aux += a[i];
            vrA = int.Parse(aux);

            aux = "";
            for (i = b.Count - 1; i >= 0; i--)
                aux += b[i];
            vrB = int.Parse(aux);

            res = (vrA + vrB).ToString();
            for (i = res.Length - 1; i >= 0; i--)
                Console.WriteLine("{0} ", res[i]);
        }

        /// <summary> Given a string, find the length of the longest substring without repeating characters. </summary>
        public string LongestSubstring(string str)
        {
            int i, j = 0;
            string aux = "", res = "";

            for (i = 0; i < str.Length; i++)
            {
                if (!aux.Contains(str[i]))
                {
                    aux += str[i];
                    if (aux.Length > res.Length)
                        res = aux;
                }
                else
                {
                    i = ++j;
                    aux = str[i].ToString();
                }
            }

            return res;
        }

        /// <summary> Given a string, s, find the longest palindromic substring in s. </summary>
        public string FindPalindrome(string str)
        {
            int i, j;
            string res = "", aux;

            for (i = 0; i < str.Length; i++)
            {
                j = i;
                aux = "";

                do
                {
                    aux += str[j];
                    j++;

                    if (IsPalindrome(aux) && aux.Length > res.Length)
                        res = aux;

                } while (j < str.Length);

            }

            return res;
        }
        private bool IsPalindrome(string str) => str == new String(str.Reverse().ToArray());

        /// <summary> Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid. </summary>
        public bool ValidateCompilerString(string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(str[i]);
                        break;

                    case '}':
                        if (stack.Peek() != '{')
                            return false;
                        stack.Pop();
                        break;

                    case ']':
                        if (stack.Peek() != '[')
                            return false;
                        stack.Pop();
                        break;

                    case ')':
                        if (stack.Peek() != '(')
                            return false;
                        stack.Pop();
                        break;

                    default: throw new ArgumentOutOfRangeException("String com caracteres inválidos");
                }
            }

            return stack.Count == 0;
        }

        /// <summary>
        /// Given a sorted array, A, with possibly duplicated elements, 
        /// find the indices of the first and last occurrences of a target element, x. 
        /// Return -1 if the target is not found.
        /// </summary>
        public void FindFirstAndLast(int[] arr, int target)
        {
            int first = -1,
                last = -1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (first == -1)
                {
                    if (arr[i] == target && arr[i - 1] == target)
                    {
                        first = i - 1;
                        last = i;
                    }
                }
                else
                {
                    if (arr[i] == target)
                        last = i;
                }
            }

            Console.WriteLine("[{0}, {1}]", first, last);
        }

        /// <summary> Given a list of numbers with only 3 unique numbers (1, 2, 3), sort the list in O(n) time. </summary>
        public int[] SortUniqueNumbers(int[] arr)
        {
            List<int> arr1 = new List<int>();
            List<int> arr2 = new List<int>();
            List<int> arr3 = new List<int>();

            foreach (int item in arr)
            {
                switch (item)
                {
                    case 1: arr1.Add(item); break;
                    case 2: arr2.Add(item); break;
                    case 3: arr3.Add(item); break;
                }
            }

            return arr1.Concat(arr2).Concat(arr3).ToArray();
        }

        /// <summary>
        /// You are given a list of numbers, and a target number k. 
        /// Return whether or not there are two numbers in the list that add up to k.
        /// </summary>
        public bool HasSumOfK(int[] arr, int k)
        {
            // O(n)
            HashSet<int> hashSet = new HashSet<int>(arr.Length);
            foreach (var item in arr)
            {
                if (hashSet.Contains(k - item))
                    return true;
                hashSet.Add(item);
            }
            return false;

            // BRUTE FORCE
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i == j) continue;

            //        if (arr[i] + arr[j] == k)
            //            return $"{arr[i]} + {arr[j]} == {k}";
            //    }
            //}
        }

        /// <summary> Given a list of numbers, where every number shows up twice except for one number, find that one number. </summary>
        public int FindLonelyNumber(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>(arr.Length / 2);

            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict[item] = 1;
            }

            foreach (var item in dict)
                if (item.Value == 1)
                    return item.Key;

            return -1;
        }

        /// <summary>
        /// You are given an array of integers in an arbitrary order.
        /// Return whether or not it is possible to make the array non-decreasing by modifying at most 1 element to any value.
        /// </summary>
        public bool CanWeFixIt(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] > arr[i + 1])
                    count++;

            return count <= 1;
        }


    }
}
