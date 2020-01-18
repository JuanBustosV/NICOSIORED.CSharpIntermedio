using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04DelegadoSencillo
{
    class CPastel
    {
        // Este método actuará como delegado, es static para poder invocar el método aunque no exista instancia de la clase Pastel.
        public static void MostrarPastel(String pAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;            
            Console.WriteLine("El pastel llevará el mensaje de {0}", pAnuncio);
        }
    }
}
