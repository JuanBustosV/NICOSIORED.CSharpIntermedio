using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04DelegadoSencillo
{
    class CRadio
    {
        // Este método actuará como delegado, es static para poder invocar el método aunque no exista instancia de la clase Radio.
        public static void MetodoRadio(String pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase Radio");
            Console.WriteLine("Este es tú mensaje {0}", pMensaje);
        }
    }
}
