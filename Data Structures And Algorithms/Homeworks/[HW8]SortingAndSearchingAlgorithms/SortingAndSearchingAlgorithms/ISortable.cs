namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;
    
    public interface ISortable<T> where T : IComparable<T>
    {
        void Sort(IList<T> collection);
    }
}