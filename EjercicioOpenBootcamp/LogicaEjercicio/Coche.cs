using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEjercicio
{
    public class Coche
    {
        public int numPuertas { get; set; }

        public void incrementoPuertas(int puertas)
        {
            if (puertas > 0 & puertas <= 5)
            {
                numPuertas = numPuertas + puertas;
            }
           else
            {
                Console.WriteLine("ingrese un valor valido");
            }
        
        }


    }
}
