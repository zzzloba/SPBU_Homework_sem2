﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class HashTable : IHashTable
    {
        private List<List> Buckets;

        public int Count { get; private set; } // total number of elements
        private int DifferentCount { get; set; } // number of elements excluding repeating

        public HashTable()
        {
            Buckets = new List<List>();

            const int DefaultSize = 10;

            for (var i = 0; i < DefaultSize; ++i)
            {
                Buckets.Add(new List());
            }
        }

        private long HashFunction(string word)
        {
            long sum = 0;

            foreach (var letter in word)
            {
                sum = sum * 19 + letter * 31;
            }

            return sum;
        }

        private void Expand()
        {
            var newBuckets = new List<List>();

            for (var i = 0; i < Buckets.Count * 2; ++i)
            {
                newBuckets.Add(new List());
            }

            foreach (var list in Buckets)
            {
                if (list.IsEmpty)
                {
                    continue;
                }

                var words = list.GetWords();

                foreach (var word in words)
                {
                    var hash = (int)(HashFunction(word) % newBuckets.Count);
                    newBuckets[hash].Add(word);
                }
            }

            Buckets = newBuckets;
        }

        public void Add(string word)
        {
            if (LoadCoefficient > 1)
            {
                Expand();
            }

            var hash = (int)(HashFunction(word) % Buckets.Count);

            if (Buckets[hash].IsEmpty)
            {
                Buckets[hash] = new List();
                ++DifferentCount;
            }
            else if (!Buckets[hash].Contains(word))
            {
                ++DifferentCount;
            }

            Buckets[hash].Add(word);
            ++Count;
        }

        public void Remove(string word)
        {
            if (!IsContained(word))
            {
                Console.WriteLine("Слово не найдено в наборе!");
                return;
            }

            var hash = (int)(HashFunction(word) % Buckets.Count);

            if (!Buckets[hash].Remove(word))
            {
                return;
            }

            --Count;

            if (!Buckets[hash].Contains(word))
            {
                --DifferentCount;
            }
        }

        public bool IsContained(string word)
        {
            var hash = (int)(HashFunction(word) % Buckets.Count);
            return Buckets[hash].Contains(word);
        }

        private double LoadCoefficient
        {
            get { return (double)DifferentCount / (double)Buckets.Count; }
        }

        public void Clear()
        {
            foreach (var list in Buckets)
            {
                list.Clear();
            }
        }
    }
}
