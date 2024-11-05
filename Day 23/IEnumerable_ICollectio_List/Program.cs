using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Using List
        List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("List elements:");
        PrintList(numbersList);

        // Using ICollection
        ICollection<int> numbersCollection = numbersList;
        Console.WriteLine("\nICollection elements:");
        PrintCollection(numbersCollection);

        // Using IEnumerable
        IEnumerable<int> numbersEnumerable = numbersList;
        Console.WriteLine("\nIEnumerable elements:");
        PrintEnumerable(numbersEnumerable);
    }

    static void PrintList(List<int> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void PrintCollection(ICollection<int> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Count: {collection.Count}");
    }

    static void PrintEnumerable(IEnumerable<int> enumerable)
    {
        foreach (var item in enumerable)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine($"Count: {enumerable.Count()}");
    }
}