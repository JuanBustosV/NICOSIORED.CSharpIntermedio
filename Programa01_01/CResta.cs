using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    class CResta:IOperacion
    {
        private double r = 0;

        // Metodos a implementar
        public void calcular(double a, double b)
        {
            r = a - b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la resta es {0}", r);
        }

    }
}
