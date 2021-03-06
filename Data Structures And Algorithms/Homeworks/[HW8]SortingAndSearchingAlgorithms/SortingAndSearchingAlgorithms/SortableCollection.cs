﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchingAlgorithms
{
    public class SortableCollection<T> where T : IComparable<T>
    {
        private
        readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISortable<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            return this.BinarySearch(0, this.items.Count - 1, item);
        }

        public void Shuffle()
        {
            var ran = new Random();
            for (var i = 0; i < this.items.Count; i++)
            {
                int r = i + ran.Next(0, this.items.Count - i);
                var forSwap = this.items[i];
                this.items[i] = this.items[r];
                this.items[r] = forSwap;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }
            Console.WriteLine();
        }

        private bool BinarySearch(int l, int r, T v)
        {
            bool result = false;
            int m = (l + r) / 2;
            if (l >= r)
            {
                return result;
            }
            if (this.items[m].CompareTo(v) < 0)
            {
                result = this.BinarySearch(m + 1, r, v);
            }
            else if (this.items[m].CompareTo(v) > 0)
            {
                result = this.BinarySearch(l, m - 1, v);
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}