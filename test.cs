using System;

class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void AgregarAlPrincipio(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        nuevoNodo.Siguiente = cabeza;
        cabeza = nuevoNodo;
    }

    public void MostrarLista()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar nodos al principio de la lista
        lista.AgregarAlPrincipio(3);
        lista.AgregarAlPrincipio(2);
        lista.AgregarAlPrincipio(1);

        // Mostrar la lista
        Console.WriteLine("Lista Enlazada:");
        lista.MostrarLista();
    }
}
