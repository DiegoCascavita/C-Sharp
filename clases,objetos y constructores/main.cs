using System;
using clases_objetos_constructores;//import

namespace Program
{
    static void Main(string[] args)
    {
        Bebida bebida = new Bebida("Coca Cola", 1000);
        bebida.Beberse(500);
        Console.WriteLine(bebida.Cantidad);
    }
}