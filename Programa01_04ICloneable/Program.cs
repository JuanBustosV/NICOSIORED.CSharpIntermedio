using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_04ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
                
            CAuto Auto1 = new CAuto("March", 170_000);

            // Aqui pensamos que hacemos clonado
            // Pero solo es otra variable referenciada a la misma instancia

            CAuto Auto2 = Auto1;
            Auto1.CalculaTenencia(0.10);
            Auto2.CalculaTenencia(0.10);

            // Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            Console.WriteLine("---------------------");

            // Hacemos un cambio, si fuera un con solo uno cambia
            Auto1.Precio = 60_000;

            // Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            Console.WriteLine("==========================");

            // Ahora si hacemos un clon
            CAuto Auto3 = (CAuto)Auto1.Clone();

            // Imprimimos
            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("---------------------");

            // Modificamos uno, el otro no debe alterarse
            Auto1.Precio = 250_000;

            // Imprimimos
            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("---------------------");
        }
    }
}
