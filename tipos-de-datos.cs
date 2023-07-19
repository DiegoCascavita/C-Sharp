byte numero = 255; //hasta el 255 numeros positivos
sbyte numero1 = -128; //hasta el 128 numeros negativos, y hasta el 127
int numero2 = 321;//32 bits millones de numeros positivos y negativos
uint numero3 = 123; //32 bits millones de numeros positivos
ulong numero4 = 1237656; //64 bits millones de numeros positivos
long numero5 = -1237656; //64 bits millones de numeros negativos y positivos
float numero6 = 1.1f; // con un flotante4 bytes
double numero7 = 1.1111d;//mas decimales 
decimal numero8 = 1.1111;// MAS decimales !!!
char caracter = 'a'; //caracteres
string cadena = "hola"; //cadena de caracteres
DateTime fecha = new DateTime(2020, 10, 10); //fecha
bool booleano = true; //booleano
var nombre = "Diego";//se le asigna el tipo de dato pero no se puede despues cambiar despues el tipo de dato a int etc...,solo para metodos locales
object persona = new {nombre = "Diego", apellido ="Cascavita"};

//ojo solo pasar que muestre una cosa la consola o cambiar sintaxis
Console.WriteLine("{0}, {1}, {2}", numero6, numero7, numero8);

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}