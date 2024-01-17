using System;

class Program
{
    // Función para calcular la longitud de la secuencia creciente más larga
    static int LongestIncreasingSubsequence(int[] arr)
    {
        int n = arr.Length;
        int[] lis = new int[n];

        // Inicializa todas las posiciones de lis en 1
        for (int i = 0; i < n; i++)
        {
            lis[i] = 1;
        }

        // Calcula las longitudes de las subsecuencias crecientes
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
        }

        // Encuentra la longitud máxima de la subsecuencia creciente
        int maxLength = 0;
        for (int i = 0; i < n; i++)
        {
            if (lis[i] > maxLength)
            {
                maxLength = lis[i];
            }
        }

        return maxLength;
    }

    static void Main()
    {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
        int result = LongestIncreasingSubsequence(arr);

        Console.WriteLine("Longitud de la subsecuencia creciente más larga: " + result);
    }
}
