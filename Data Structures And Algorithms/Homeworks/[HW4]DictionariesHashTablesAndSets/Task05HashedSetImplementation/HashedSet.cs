namespace Task05HashedSetImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task04HashTableImplementation;

    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<T, int> elements;

        public HashedSet()
        {
            this.elements = new HashTable<T, int>();
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public void Add(T item)
        {
            if (!this.elements.ContainsKey(item))
            {
                this.elements.Add(item, 1);
            }
        }

        public void Remove(T item)
        {
            this.elements.Remove(item);
        }

        public void Find(T item)
        {
            this.elements.Find(item);
        }

        public void Clear(T item)
        {
            this.elements.Clear();
        }

        public void UnionWith(HashedSet<T> otherSet)
        {
            foreach (var item in otherSet)
            {
                if (!this.elements.ContainsKey(item))
                {
                    this.Add(item);
                }
            }
        }

        public void IntersectWith(HashedSet<T> otherSet)
        {
            foreach (var item in this)
            {
                if (!otherSet.Contains(item))
                {
                    this.Remove(item);
                }
            }
        }

        public bool Contains(T item)
        {
            return this.elements.ContainsKey(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var key in this.elements.Keys)
            {
                yield return key;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}