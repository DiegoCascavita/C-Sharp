using System;
using clases_objetos_constructores;//import
//si es private no se puede acceder a esos metodos o atributos
namespace herencia
{
    class Cerveza : Bebida //herenica del padre bebida
    {
        public Cerveza() : base("Cerveza", 1000) //llama al constructor de la clase padre
        {

        }
    }
}