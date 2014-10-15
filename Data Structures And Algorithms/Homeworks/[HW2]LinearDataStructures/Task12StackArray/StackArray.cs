using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12StackArray
{
    class StackArray<T>
    {
        private T[] array;
        private int top;

        public StackArray() : this(4)
        {
            this.top = 0;
        }

        public StackArray(int capacity)
        {
            this.array = new T[capacity];
        }

        private void Extend()
        {
            var extendedarray = new T[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                extendedarray[i] = this.array[i];
            }

            this.array = extendedarray;
        }

        public void Push(T value)
        {
            this.array[this.top] = value;
            this.top++;

            if (this.top == this.array.Length)
            {
                Extend();
            }
        }

        public T Pop()
        {
            if (this.top <= 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            var poppedValue = this.array[this.top - 1];
            this.top--;

            return poppedValue;
        }

        public T Peek()
        {
            if (this.top <= 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }

            var peekedValue = this.array[this.top - 1];

            return peekedValue;
        }
    }
}