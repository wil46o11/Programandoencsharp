using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programandoencsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mostasr en mensaje
            Console.WriteLine("Bienvenido a C#");
            //definir variables
            int a, b, suma;

            //---Entrada de datos---
            //Solicitando datos
            Console.WriteLine("Ingrese el primer numero");
            //Guardar datos
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el seguindo numero");
            //Guardar datos
            b = Convert.ToInt32(Console.ReadLine());

            //---Proceso de datos---
            suma = a + b;

            //Salida de datos
            Console.WriteLine("La suma es: "+suma);
            Console.WriteLine($"La suma de {a} + {b} = {suma}");


            //Pausar par mostrar Resultados
            Console.ReadKey();

        }
    }
}
