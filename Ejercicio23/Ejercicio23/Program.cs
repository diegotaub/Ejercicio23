using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una fecha: ");
            if(!DateTime.TryParse(Console.ReadLine(), out DateTime Fecha)){
                Console.Write("La fecha ingresada no es válida");
            }
            else
            {
                Console.Write("La fecha ingresada es válida.");
            }
            Console.ReadKey();
        }
    }
}
