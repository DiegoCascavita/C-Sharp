using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a dictionary with string keys and int values
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Adding key-value pairs
        myDictionary.Add("One", 1);
        myDictionary.Add("Two", 2);
        myDictionary.Add("Three", 3);

        // Accessing values by keys
        Console.WriteLine("The value of key 'Two' is: " + myDictionary["Two"]);

        // Modifying values
        myDictionary["Three"] = 30;

        // Iterating over key-value pairs
        foreach (var pair in myDictionary)
        {
            Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
        }

        // Checking if a key exists
        if (myDictionary.ContainsKey("Four"))
        {
            Console.WriteLine("Key 'Four' exists.");
        }
        else
        {
            Console.WriteLine("Key 'Four' does not exist.");
        }

        // Removing a key-value pair
        myDictionary.Remove("Two");

        Console.ReadLine();
    }
}
