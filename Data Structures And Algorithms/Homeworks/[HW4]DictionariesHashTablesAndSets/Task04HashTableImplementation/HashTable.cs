namespace Task04HashTableImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int InitialSize = 16;
        private const float MaxLoad = 0.75f;

        private LinkedList<KeyValuePair<K, T>>[] list;
        private int count;

        public HashTable()
        {
            this.list = new LinkedList<KeyValuePair<K, T>>[InitialSize];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                var keys = new List<K>();
                foreach (var entry in this.list)
                {
                    if (entry != null)
                    {
                        keys.AddRange(entry.Select(x => x.Key));
                    }
                }

                return keys;
            }
        }

        public T this[K key]
        {
            get
            {
                T value;
                if (TryGetValue(key, out value))
                {
                    return value;
                }
                throw new KeyNotFoundException("There is no element with the specified key");
            }
            set
            {
                int hashCode = GetTableHash(key);
                if (this.list[hashCode] != null)
                {
                    var pairToRemove = this.list[hashCode].Where(kvp => kvp.Key.Equals(key)).First();
                    if (!pairToRemove.Equals(null))
                    {
                        this.list[hashCode].Remove(pairToRemove);
                        this.list[hashCode].AddLast(new KeyValuePair<K, T>(key, value));
                        return;
                    }
                }

                throw new KeyNotFoundException("There is no element with the specified key");
            }
        }

        public void Add(K key, T value)
        {
            int hashCode = GetTableHash(key);

            if (this.list[hashCode] == null)
            {
                this.list[hashCode] = new LinkedList<KeyValuePair<K, T>>();
            }

            if (this.ContainsKey(key))
            {
                throw new ArgumentException("Hash Table can't contain duplicate keys.");
            }
            else
            {
                var pair = new KeyValuePair<K, T>(key, value);
                this.list[hashCode].AddLast(pair);
                this.count++;

                if (this.Count / this.list.Length >= MaxLoad)
                {
                    Resize();
                }
            }
        }

        public void Remove(K key)
        {
            int hashCode = GetTableHash(key);
            if (this.list[hashCode] != null)
            {
                var pairToRemove = this.list[hashCode].Where(kvp => kvp.Key.Equals(key)).First();
                if (!pairToRemove.Equals(null))
                {
                    this.list[hashCode].Remove(pairToRemove);
                    this.count--;
                }
            }
        }

        public void Clear()
        {
            this.list = new LinkedList<KeyValuePair<K, T>>[InitialSize];
            this.count = 0;
        }

        public T Find(K key)
        {
            return this[key];
        }

        public bool ContainsKey(K key)
        {
            int hashCode = GetTableHash(key);

            if (this.list[hashCode] != null)
            {
                foreach (var pair in this.list[hashCode])
                {
                    if (pair.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void Resize()
        {
            var newList = new LinkedList<KeyValuePair<K, T>>[this.list.Length * 2 - 1];
            foreach (var element in this.list)
            {
                if (element != null)
                {
                    foreach (var pair in element)
                    {
                        int newElementHash = GetTableHash(pair.Key);
                        if (newList[newElementHash] == null)
                        {
                            newList[newElementHash] = new LinkedList<KeyValuePair<K, T>>();
                        }

                        newList[newElementHash].AddLast(pair);
                    }
                }
            }

            this.list = newList;
        }

        public bool TryGetValue(K key, out T value)
        {
            value = default(T);
            int hashCode = GetTableHash(key);

            foreach (var pair in this.list[hashCode])
            {
                if (pair.Key.Equals(key))
                {
                    value = pair.Value;
                    return true;
                }
            }

            return false;
        }

        public int GetTableHash(K key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("Key can't be null.");
            }
            
            int hashCode = key.GetHashCode() % this.list.Length;

            if (hashCode < 0)
            {
                hashCode = -hashCode;
            }

            return hashCode;
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var element in this.list)
            {
                if (element != null)
                {
                    foreach (var pair in element)
                    {
                        yield return pair;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}