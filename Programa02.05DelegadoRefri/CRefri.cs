using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02._05DelegadoRefri
{
    class CRefri
    {
        // Delegados (public por ser primer ejmemplo, no tendría que ser public)
        public delegate void DReservasBajas(int pKilos);
        public delegate void DDescongelado(int pGrados);

        private int kilos = 0;
        private int grados = 0;

        // Variables que usaremos para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;

        // Propiedades
        public int Kilos { get { return kilos; } }
        public int Grados { get { return grados; } }

        // Constructor
        public CRefri(int pKilos, int pGrados)
        {
            // Inicializa los valores del refri
            kilos = pKilos;
            grados = pGrados;
        }

        // Estos métodos permiten referenciar las variables
        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas = pMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado = pMetodo;
        }        

        public void Trabajar(int pConsumo)
        {
            // Actualizamos los kilos del refri
            kilos -= pConsumo;

            // Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilos, grados);

            // Hay que verificar si se cumple la condicion para
            // invocar los handlers del evento

            // Concición del evento para los kilos
            if (kilos < 10)
            {
                // Invocamos el método
                delReservas(kilos); // delReservas?.Invoke(kilos);
            }

            // Condición del evento para la temperatura
            if(grados > 0)
            {
                // Invocamos el metodo
                delDescongelado?.Invoke(grados);
            }
        }
    }
}
