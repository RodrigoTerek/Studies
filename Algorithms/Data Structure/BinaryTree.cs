using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Data_Structure
{
    public class BinaryTree<T> where T : IComparable
    {
        public BinaryTreeNode<T> Root { get; set; }

        //public void Add(T value)
        //{
        //    BinaryTreeNode<T> aux = this.Root;

        //    while (true)
        //    {
        //        if (aux.Value.CompareTo(value) == 0) // value <= aux
        //        {
        //            throw new Exception("Value already exist in tree");
        //        }
        //        else if (aux.Value.CompareTo(value) > 0) // value < aux
        //        {
        //            if (aux.Left != null)
        //            {
        //                aux = aux.Left;
        //            }
        //            else
        //            {
        //                aux.Left = new BinaryTreeNode<T>(value);
        //                break;
        //            }
        //        }
        //        else // value > aux
        //        {


        //        }
        //    }

        //}

        //public void Remove(T value)
        //{

        //}

        public void PrePrint()
        {

        }

        public void PosPrint()
        {

        }

        /// <summary>
        /// Given an integer k and a binary search tree, find the floor (less than or equal to) of k, 
        /// and the ceiling (larger than or equal to) of k. If either does not exist, then print them as None.
        /// </summary>
        public void FindFloorCeiling(T k)
        {
            if (this.Root == null) throw new ArgumentNullException("Root node must exist");

            T floor = default, ceiling = default;
            BinaryTreeNode<T> aux = this.Root;

            while (true)
            {
                if (aux.Value.CompareTo(k) == 0) // k <= aux
                {
                    floor = ceiling = aux.Value;
                    break;
                }
                else if (aux.Value.CompareTo(k) > 0) // k < aux
                {
                    ceiling = aux.Value;

                    if (aux.Left != null)
                        aux = aux.Left;
                    else
                        break;
                }
                else // k > aux
                {
                    floor = aux.Value;
                    if (aux.Right != null)
                        aux = aux.Right;
                    else
                        break;
                }
            }

            Console.WriteLine("F: {0} | C: {1}", floor, ceiling);
        }

        /// <summary>
        /// Invert the binary tree in place. That is, all left children should 
        /// become right children, and all right children should become left children.
        /// </summary>
        public void Invert()
        {

        }

    }
}
