using System;

namespace Task11LinkedListImplementation
{
    public class LinkedList<T>
    {
        public ListItem<T> Head { get; set; }

        public ListItem<T> Tail { get; set; }

        public void Add(T value)
        {
            var newNode = new ListItem<T>()
            {
                Value = value
            };

            if (this.Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                this.Tail.NextItem = newNode;
                this.Tail = newNode;
            }
        }
    }
}