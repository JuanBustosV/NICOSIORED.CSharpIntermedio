using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02._06Delegados
{
    class CTienda
    {
        public static void MandaViveres(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Vamos a mandar sus víveres, estoy en la tienda");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }
    }
}
