using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programandoencsharp
{
    public class E1secuencial
    {
        public void areatriangulo() {
            //Definir variable
            //1ra forma
            double s; //semiperimetro

            //2da forma
            //int area = 0;

            Console.WriteLine("--- Algoritmo Area Triangulo");
            Console.WriteLine("Ingrese el lado a: ");
            var a=int. Parse(Console.ReadLine());

            Console.WriteLine("Ingrase el lado b: ");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el lado c");
            var test = int. TryParse(Console.ReadLine(), out int c);

            //Proceso
            s = (a + b + c) / 2;
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //salida datos
            Console.WriteLine($"El area del triangulo segun lados {a}, {b}, {c}");



        }
    }
}
