﻿namespace Task10ShortestSequenceForPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}