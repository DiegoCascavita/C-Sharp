
/*Array:

Un array es una colección de elementos del mismo tipo con un tamaño fijo.*/
int[] numeros = new int[] { 1, 2, 3, 4, 5 };
/*Lista:

Una lista es una estructura de datos dinámica que puede cambiar de tamaño.*/
List<string> nombres = new List<string>();
nombres.Add("Alice");
nombres.Add("Bob");
nombres.Add("Charlie");
/*Diccionario:

Un diccionario almacena pares clave-valor.*/
Dictionary<string, int> edades = new Dictionary<string, int>();
edades["Alice"] = 30;
edades["Bob"] = 25;
edades["Charlie"] = 35;
/*Clase personalizada:

Puedes definir tus propias clases personalizadas para modelar datos más complejos*/
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

// Crear instancias de la clase Persona
Persona persona1 = new Persona { Nombre = "Alice", Edad = 30 };
Persona persona2 = new Persona { Nombre = "Bob", Edad = 25 };

/*Pila -Stack-:

Una pila es una estructura de datos LIFO (Last-In-First-Out) y se puede implementar utilizando la clase Stack.*/
Stack<string> pila = new Stack<string>();
pila.Push("Elemento 1");
pila.Push("Elemento 2");
string elemento = pila.Pop(); // elemento contiene "Elemento 2"

/*Cola:

Una cola es una estructura de datos FIFO (First-In-First-Out) y se puede implementar utilizando la clase Queue*/
Queue<string> cola = new Queue<string>();
cola.Enqueue("Elemento 1");
cola.Enqueue("Elemento 2");
string elemento = cola.Dequeue(); // elemento contiene "Elemento 1"
   

int 

// -------------------HASHMAP -------------------
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
