int[] numeros = new int[10] {0,1, 2, 3, 4, 5, 6, 7,8,9};/*el 10 especifica cuantos,
si no se pone se puede cualquier cantidad*/

for(int i = 0; i < numeros.Length; i ++)
{
Console.WriteLine(numeros[i]);
}

foreach(var numero in numeros)
{
Console.WriteLine(numero);
}
//PILAS STACK // LINKED LIST
List<int> lista = new List<int>() { 0,1,2,3,4,5,6,7,8};
lista.Add(9);
lista.Remove(2);

foreach(var numero in lista)
{
    Console.WriteLine("Elemento"+ numero);
}