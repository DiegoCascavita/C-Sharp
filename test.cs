using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a stack of integers
        Stack<int> miStack = new Stack<int>();

        // Push elements onto the stack
        miStack.Push(3);
        miStack.Push(7);
        miStack.Push(1);
        miStack.Push(4);

        // Display the elements in the stack
        Console.WriteLine("Elements in the stack:");
        foreach (int elemento in miStack)
        {
            Console.WriteLine(elemento);
        }

        // Pop elements from the stack
        Console.WriteLine("\nPopping elements from the stack:");
        while (miStack.Count > 0)
        {
            int elemento = miStack.Pop();
            Console.WriteLine(elemento);
        }
    }
}
