using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02._05DelegadoRefri
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# intermedio 10 --- Delegados II";

            // Creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            // Añadimos los handlers
            miRefri.AdicionaMetodoReservas(new CRefri.DReservasBajas(InformeKilos));
            miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeGrados));

            // El refri trabaja
            while(miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }            
        }

        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }

        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-->Se descongela el refri!, estoy a nivel de main");
            Console.WriteLine("-->Está a {0} grados", pGrados);
        }
    }
}
