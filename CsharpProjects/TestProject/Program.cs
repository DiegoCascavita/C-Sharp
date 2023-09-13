using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear un HashMap (Dictionary) que mapea cadenas (string) a enteros (int).
        Dictionary<string, int> hashMap = new Dictionary<string, int>();

        // Agregar elementos al HashMap.
        hashMap["Manzana"] = 10;
        hashMap["Banana"] = 5;
        hashMap["Cereza"] = 15;

        // Acceder a elementos en el HashMap.
        Console.WriteLine("Cantidad de Manzanas: " + hashMap["Manzana"]);

        // Verificar si una clave existe en el HashMap.
        if (hashMap.ContainsKey("Banana"))
        {
            Console.WriteLine("Tenemos Bananas!");
        }

        // Iterar a través de los elementos del HashMap.
        foreach (var kvp in hashMap)
        {
            Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
        }

        // Eliminar un elemento del HashMap.
        hashMap.Remove("Cereza");

        // Verificar si el HashMap contiene una clave después de la eliminación.
        if (!hashMap.ContainsKey("Cereza"))
        {
            Console.WriteLine("No hay más Cerezas.");
        }
    }
}
