using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02._06Delegados
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# intermedio 11 --- Delegados III";

            // Creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            // Variables para el multicasting, necesitamos la isntancia para poder adicionar o eliminar
            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);

            DDescongelado desc1 = new DDescongelado(InformeGrados);

            // Añadimos los handlers
            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(desc1);

            // El refri trabaja
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }

            // Eliminamos un handler
            miRefri.EliminarMetodoReservas(kilos2); // mandaViveres

            ////////////////////////////////////////////

            // Relenamos el refri
            miRefri.Kilos = 50;
            miRefri.Grados = -15;

            // El refri trabaja
            while (miRefri.Kilos > 0)
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
