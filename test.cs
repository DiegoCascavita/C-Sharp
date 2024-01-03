*Pila -Stack-:

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