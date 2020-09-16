using System;
using System.Collections.Generic;

namespace Algorithms.Data_Structure
{
    /// <summary> Entry for a singly-linked list </summary>
    public class SinglyLinkedListEntry<T>
    {
        public SinglyLinkedListEntry<T> Next { get; set; }
        public T Value { get; set; }

        public SinglyLinkedListEntry(T value) => Value = value;
        public SinglyLinkedListEntry(SinglyLinkedListEntry<T> a, T value)
        {
            Value = value;
            a.Next = this;
        }

        public static void PrintList(SinglyLinkedListEntry<T> head)
        {
            SinglyLinkedListEntry<T> aux = head;
            string res = "";

            while (aux != null)
            {
                res += aux.Value + " -> ";
                aux = aux.Next;
            }

            Console.WriteLine(res + "NULL");
        }

        /// <summary> Given a singly-linked list, reverse the list </summary>
        public static void ReverseList(SinglyLinkedListEntry<T> head)
        {
            List<SinglyLinkedListEntry<T>> entries = new List<SinglyLinkedListEntry<T>>();
            SinglyLinkedListEntry<T> aux = head;

            do
            {
                entries.Add(aux);
                aux = aux.Next;
            } while (aux.Next != null);

            SinglyLinkedListEntry<T> newHead = new SinglyLinkedListEntry<T>(aux.Value);
            aux = newHead;
            for (int i = entries.Count - 1; i >= 0; i--)
            {
                SinglyLinkedListEntry<T> entry = new SinglyLinkedListEntry<T>(aux, entries[i].Value);
                aux = entry;
            }

            PrintList(newHead);
        }

        /// <summary> Given a singly-linked list, reverse the list recursively </summary>
        public static SinglyLinkedListEntry<T> ReverseListRec(SinglyLinkedListEntry<T> entry)
        {
            if (entry.Next == null)
                return new SinglyLinkedListEntry<T>(entry.Value);

            SinglyLinkedListEntry<T> aux = ReverseListRec(entry.Next);

            SinglyLinkedListEntry<T> aux2 = aux;
            while (aux2.Next != null)
                aux2 = aux2.Next;
            aux2.Next = new SinglyLinkedListEntry<T>(entry.Value);

            return aux;
        }

    }
}
