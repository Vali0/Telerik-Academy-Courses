using System;
using System.Text;

class GenericList<T>
{
    // Fields
    private T[] array;
    private int lastIndex = 0;

    // Constructor
    public GenericList(int size)
    {
        this.array = new T[size];
    }

    // Properties
    public int Length // Return number of elements which are saved
    {
        get
        {
            return lastIndex;
        }
    }

    public int Capacity // Return actual size of the array
    {
        get
        {
            return array.Length;
        }
    }

    public void AddElement(T element)
    {
        // If reach the Capacity - double it.
        if (array.Length <= lastIndex)
        {
            AutoGrow(lastIndex + 1);
        }
        
        array[lastIndex] = element; // Save the element into the array
        lastIndex++;
    }

    public void RemoveAt(int index)
    {
        if (index >= lastIndex || index < 0)
        {
            throw new IndexOutOfRangeException("Invalid index!");
        }
        T[] tempArr = new T[array.Length];
        int tempArrindex = 0;

        for (int fromBegToIndex = 0; fromBegToIndex < index; fromBegToIndex++, tempArrindex++)
        {
            tempArr[tempArrindex] = array[fromBegToIndex];
        }

        for (int toTheEnd = index + 1; toTheEnd < lastIndex; toTheEnd++, tempArrindex++)
        {
            tempArr[tempArrindex] = array[toTheEnd];
        }

        Array.Copy(tempArr, 0, array, 0, array.Length);
        array = tempArr;
        lastIndex--;        
    }

    public void InsertAt(int index, T element)
    {
        if (index < 0) // Only less because autogrow function
        {
            throw new IndexOutOfRangeException("Invalid index!");
        }

        if (array.Length <= index)
        {
            AutoGrow(index);
        }

        Array.Copy(array, index, array, index + 1, array.Length - index - 1);
        array[index] = element;
        
        if (lastIndex <= index)
        {
            lastIndex = index + 1;
        }
        else
        {
            lastIndex++;
        }
    }

    public void ClearList()
    {
        array = new T[array.Length]; // Creating new reference GC will do the rest ;)
        //array = null // If you want to destroy it (remove capacity)
    }

    public int FindElement(T element)
    {
        dynamic result = Array.IndexOf(array, element);
        if (result == -1)
        {
            throw new ArgumentException("No such element!");
        }
        return result;
    }
    
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            {
                result.Append(array[i] + " ");
            }
            else
            {
                result.Append(array[i]);
            }
        }
        return result.ToString();
    }

    private void AutoGrow(int index)
    {
        T[] tempArray = (T[])array.Clone();
        array = new T[BinaryPow(array.Length, index)];
        Array.Copy(tempArray, array, tempArray.Length);
    }

    // Method if the index is out of the array after multiplication of the length
    private int BinaryPow(int length, int index)
    {
        length = length * 2;
        if (length < index)
        {
            return BinaryPow(length, index);
        }
        return length;
    }

    public T Min<T>()
        where T : IComparable<T>
    {
        // Dynamic if we want to Comapare ;)
        dynamic min = array[0];
        dynamic tempArray = array.Clone();
        for (int index = 1; index < lastIndex; index++)
        {
            if (tempArray[index].CompareTo(min) < 0)
            {
                min = tempArray[index];
            }
        }
        return min;
    }
    
    public T Max<T>()
        where T : IComparable<T>
    {
        // Dynamic if we want to Comapare ;)
        dynamic max = array[0];
        dynamic tempArray = array.Clone();
        for (int index = 0; index < lastIndex; index++)
        {
            if (tempArray[index].CompareTo(max) > 0)
            {
                max = tempArray[index];
            }
        }
        return max;
    }

    public T this[int index]
    {
        get
        {
            // If we trying to get invalid index
            if (index >= lastIndex || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            T result = array[index];
            return result;
        }
    }
}