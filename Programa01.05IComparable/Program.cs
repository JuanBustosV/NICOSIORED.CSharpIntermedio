using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01._05IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel intermedio 6 --- IComparable";

            CRectangulo[] rects = new CRectangulo[5];

            rects[0] = new CRectangulo(7, 5);
            rects[1] = new CRectangulo(6, 4);
            rects[2] = new CRectangulo(4, 3);
            rects[3] = new CRectangulo(7, 6);
            rects[4] = new CRectangulo(5, 7);

            // Imprimimos array original
            foreach (CRectangulo r in rects)
                Console.WriteLine(r);

            Console.WriteLine("-------------------------");

            // Hacemos uso de sort, el cual necesita la implementación de IComparable
            Array.Sort(rects);

            // Imprimimos arreglo ordenado
            foreach (CRectangulo r in rects)
                Console.WriteLine(r);
        }
    }
}
