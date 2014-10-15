using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01PriorityQueueWithBinaryHeap
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        private const int InitialCapacity = 4;
        private T[] elements;

        private int size;
        private int capacity;

        public PriorityQueue()
        {
            this.elements = new T[InitialCapacity];
            this.size = 0;
            this.capacity = InitialCapacity;
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }

        public void Enqueue(T element)
        {
            this.elements[this.size] = element;
            BubbleElement();
            this.size++;

            if (this.size == this.capacity)
            {
                Resize();
            }
        }

        public T Dequeue()
        {
            var dequedElement = this.elements[0];
            this.size--;
            DunkElement();
            return dequedElement;
        }

        public T Peek()
        {
            return this.elements[0];
        }

        private void BubbleElement()
        {
            int currentElementIndex = this.size;
            int parentIndex = 0;

            while (currentElementIndex > 0)
            {
                parentIndex = (currentElementIndex - 1) / 2;

                if (this.elements[currentElementIndex].CompareTo(this.elements[parentIndex]) < 0)
                {
                    Swap(parentIndex, currentElementIndex);
                    currentElementIndex = parentIndex;    
                }
                else
                {
                    return;
                }
            }
        }

        private void DunkElement()
        {
            int parentIndex = 0;
            int leftChildrenIndex = 2 * parentIndex + 1;
            int rightChildrenIndex = 2 * parentIndex + 2;

            this.elements[0] = this.elements[this.size];

            while (rightChildrenIndex < this.size || leftChildrenIndex < this.size)
            {

                if (this.elements[parentIndex].CompareTo(this.elements[leftChildrenIndex]) > 0)
                {
                    Swap(parentIndex, leftChildrenIndex);
                    parentIndex = leftChildrenIndex;
                }
                else if (this.elements[parentIndex].CompareTo(this.elements[rightChildrenIndex]) > 0)
                {
                    Swap(parentIndex, rightChildrenIndex);
                    parentIndex = rightChildrenIndex;
                }
                else
                {
                    return;
                }

                leftChildrenIndex = 2 * parentIndex + 1;
                rightChildrenIndex = 2 * parentIndex + 2;
            }
        }

        private void Swap(int fromIndex, int toIndex)
        {
            var tempElement = this.elements[fromIndex];
            this.elements[fromIndex] = this.elements[toIndex];
            this.elements[toIndex] = tempElement;
        }

        private void Resize()
        {
            this.capacity = this.capacity * 2;
            var resizedArray = new T[this.capacity];

            for (int i = 0; i < this.size; i++)
            {
                resizedArray[i] = this.elements[i];
            }

            this.elements = resizedArray;
        }
    }
}