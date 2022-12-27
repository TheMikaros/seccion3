using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Pedir por consola un nombre de persona y el nombre de una ciudad
            //(no hace falta que sean reales o comprobarlos) y mostrar por pantalla,
            //el siguiente mensaje “Hola ” < nombre > ” bienvenido a ” < ciudad >

            Console.WriteLine("Input name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Input city:");
            string city = Console.ReadLine();

            Console.WriteLine("Hola " + name + " bienbenido a " + city);

        }
    }
}
