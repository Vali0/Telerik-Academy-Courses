using System;

// 5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
// Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
// Implement methods for adding element, accessing element by index, removing element by index, inserting element at 
// given position, clearing the list, finding element by its value and ToString(). Check all input parameters to 
// avoid accessing elements at invalid positions.
// 6. Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
// 7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
// You may need to add a generic constraints for the type T.

class GenericExercise
{
    static void Main(string[] args)
    {
        GenericList<int> list = new GenericList<int>(3);

        list.AddElement(1);
        list.AddElement(2);
        list.AddElement(3);
        list.AddElement(4);
        list.InsertAt(3, 7);
        list.RemoveAt(2);
        list.InsertAt(0, 22);

        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine("Min element: " + list.Min<int>());
        Console.WriteLine("Max element: " + list.Max<int>());
        Console.WriteLine("Index of element 2 is (counting from zero): " + list.FindElement(2));

        list.InsertAt(7, 123);
        //list.InsertAt(999, 321); // this works with autogrow function too!!!
        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }
        Console.WriteLine("Min element: " + list.Min<int>());

        list.ClearList();
        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}