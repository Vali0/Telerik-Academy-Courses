using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13ADTQueue
{
    class LinkedQueue<T>
    {
        LinkedList<T> queue;

        public LinkedQueue()
        {
            queue = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            this.queue.AddLast(value);
        }

        public T Dequeue()
        {
            if (this.queue.First == null)
            {
                throw new ArgumentNullException("Queue is empty!");
            }
            var result = this.queue.First.Value;
            this.queue.RemoveFirst();

            return result;
        }

        public T Peek()
        {
            if (this.queue.First == null)
            {
                throw new ArgumentNullException("Queue is empty!");
            }

            var result = this.queue.First.Value;

            return result;
        }

        public bool Contains(T value)
        {
            bool isContaining = this.queue.Contains(value);

            return isContaining;
        }
    }
}