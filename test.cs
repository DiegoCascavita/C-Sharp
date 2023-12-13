using System;

class Program
{
    static int BusquedaBinaria(int[] array, int elemento)
    {
        int inicio = 0;
        int fin = array.Length - 1;

        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;

            // Si el elemento está en el medio
            if (array[medio] == elemento)
            {
                return medio;
            }
            // Si el elemento es menor, buscar en la mitad izquierda
            else if (array[medio] > elemento)
            {
                fin = medio - 1;
            }
            // Si el elemento es mayor, buscar en la mitad derecha
            else
            {
                inicio = medio + 1;
            }
        }

        // El elemento no está presente en el array
        return -1;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int elementoBuscado = 7;

        int resultado = BusquedaBinaria(array, elementoBuscado);

        if (resultado != -1)
        {
            Console.WriteLine($"Elemento {elementoBuscado} encontrado en la posición {resultado}.");
        }
        else
        {
            Console.WriteLine($"Elemento {elementoBuscado} no encontrado en el array.");
        }
    }
}
