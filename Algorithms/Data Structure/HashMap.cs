using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms.Data_Structure
{
    public class Entry<K, V>
    {
        public K Key { get; }
        public V Value { get; set; }
        public Entry<K, V> Next { get; set; }

        public Entry(K key, V value) : this(key, value, null) { }
        public Entry(K key, V value, Entry<K, V> next)
        {
            Key = key;
            Value = value;
            Next = next;
        }

        public override string ToString() => $"{Key} = {Value}";
    }

    public class MyMap<K, V>
    {
        private static readonly int InitialCapacity = 1 << 4;
        private Entry<K, V>[] Buckets { get; set; }
        public int Size { get; private set; }

        public MyMap() : this(InitialCapacity) { }
        public MyMap(int capacity) => Buckets = new Entry<K, V>[capacity];

        public void Put(K key, V value)
        {
            Entry<K, V> entry = new Entry<K, V>(key, value);

            int index = GetIndex(key);
            Entry<K, V> existing = Buckets[index];
            if (existing == null)
            {
                Buckets[index] = entry;
                Size++;
            }
            else
            {
                while (existing.Next != null)
                {
                    if (existing.Key.Equals(key))
                    {
                        existing.Value = value;
                        return;
                    }
                    existing = existing.Next;
                }

                if (existing.Key.Equals(key))
                {
                    existing.Value = value;
                }
                else
                {
                    existing.Next = entry;
                    Size++;
                }
            }
        }

        public V Get(K key)
        {
            int index = GetIndex(key);
            Entry<K, V> aux = Buckets[index];

            while (aux?.Next != null)
            {
                if (aux.Key.Equals(key))
                    return aux.Value;
                aux = aux.Next;
            }

            if (aux?.Key.Equals(key) ?? false)
                return aux.Value;

            return default;
        }

        public Entry<K, V> Find(V value)
        {
            foreach (Entry<K, V> entry in Buckets)
            {
                if (entry == null)
                    continue;

                Entry<K, V> aux = entry;
                while (aux?.Next != null)
                {
                    if (aux.Value.Equals(value))
                        return aux;
                    aux = aux.Next;
                }

                if (aux?.Value.Equals(value) ?? false)
                    return aux;
            }

            return default;
        }

        public void Remove(K key)
        {
            int index = GetIndex(key);
            Entry<K, V> aux = Buckets[index];

            if (aux.Key.Equals(key))
            {
                Buckets[index] = aux.Next ?? null;
                Size--;
            }
            else
            {
                while (aux.Next != null)
                {
                    if (aux.Next?.Key.Equals(key) ?? false)
                    {
                        aux.Next = aux.Next.Next ?? null;
                        Size--;
                        return;
                    }
                    aux = aux.Next;
                }
            }
        }

        // ----------------------

        int GetIndex(K key) => GetHash(key) % Buckets.Length;
        static int GetHash(K key) => Math.Abs(key.GetHashCode());




    }


}
