using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaEjercicio;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

            //EJERCICIO OPEN BOOTCAMP 
            //Primera Parte
        {
            Console.WriteLine("Ingresa un numero");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero");
            int f = int.Parse(Console.ReadLine());

            void sumaNumeros(int num1, int num2, int num3)
            {
                int resultado;
                resultado = num1 + num2 + num3;
                Console.WriteLine("El resultado de la suma es {0}", resultado);
            }
            sumaNumeros(x, y, f);
            
            //Segunda Parte
            Coche coche = new Coche();
            Console.WriteLine("Ingresa un numero de puertas que quieras agregar");
            int g = int.Parse(Console.ReadLine());
            coche.incrementoPuertas(g);
            Console.WriteLine("El coche tiene {0} puertas", coche.numPuertas);

            Console.ReadKey();

        }
    }
}
