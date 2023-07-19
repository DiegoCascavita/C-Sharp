/*Contrato que las clases deben respetar, permite heredar de multiples clases
cosa que las clases solo pueden de 1*/

//empiezan con I mayuscula


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso.models
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("maximo permitido son 10")
        }
        public Cerveza(int Cantidad,string Nombre = "Cerveza") 
            : base(Nombre, Cantidad)
        {
        
        }
    }
}
