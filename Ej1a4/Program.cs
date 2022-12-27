using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ej1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {


//            1 - Cree un proyecto de consola que imprima su nombre en la ventana de la consola.

//2 - Cree un proyecto de consola de.Net Framework en su versión 4.6 y otro de.Net Core 2.1

//3 - En el proyecto del punto 1, pon un punto de interrupción antes de mostrar tu nombre por consola.

//4 - En el proyecto del punto 1, pide por consola que el usuario introduzca su nombre y muestra "Hola, <nombre>"

            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola " + nombre);
        }
    }
}
