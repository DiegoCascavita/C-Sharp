
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
//-------------Dijkstra Algorithm----------------
//algoritmo para encontrar el camino más corto entre dos nodos en un grafo
using System;
using System.Collections.Generic;

public class DijkstraAlgorithm
{
    private int V; // Número de vértices

    public DijkstraAlgorithm(int v)
    {
        V = v;
    }

    // Encuentra el vértice con la distancia mínima del conjunto de vértices no incluidos en el árbol de caminos más cortos aún
    private int MinDistance(int[] dist, bool[] sptSet)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    // Imprime la solución
    private void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vértice \t Distancia desde el origen");
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine(i + " \t\t " + dist[i]);
        }
    }

    // Implementación del algoritmo de Dijkstra para encontrar el camino más corto desde el origen a todos los vértices
    public void Dijkstra(int[,] graph, int src)
    {
        int[] dist = new int[V];
        bool[] sptSet = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, sptSet);

            sptSet[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        PrintSolution(dist);
    }

    // Método de prueba
    public static void Main(string[] args)
    {
        int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                    { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                    { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                    { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                    { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                    { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                    { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                    { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                    { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

        DijkstraAlgorithm dijkstra = new DijkstraAlgorithm(9);
        dijkstra.Dijkstra(graph, 0);
    }
}
using System;

class Program
{
    // Function to perform binary search
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if target is present at mid
            if (arr[mid] == target)
                return mid;

            // If target is greater, ignore left half
            if (arr[mid] < target)
                left = mid + 1;

            // If target is smaller, ignore right half
            else
                right = mid - 1;
        }

        // If the target is not present in the array
        return -1;
    }

    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int target = 10;
        int result = BinarySearch(arr, target);
        if (result == -1)
            Console.WriteLine("Element not present in array");
        else
            Console.WriteLine("Element found at index " + result);
    }
}