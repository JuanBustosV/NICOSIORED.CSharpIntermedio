using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02._06Delegados
{
    // Delegados
    delegate void DReservasBajas(int pKilos);
    delegate void DDescongelado(int pGrados);

    class CRefri
    {   
        // Atributos
        private int kilos = 0;
        private int grados = 0;

        // Variables que usaremos para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;

        // Propiedades
        public int Kilos { get { return kilos; } set { kilos = value; } }
        public int Grados { get { return grados; } set { grados = value; } }

        // Constructor
        public CRefri(int pKilos, int pGrados)
        {
            // Inicializa los valores del refri
            kilos = pKilos;
            grados = pGrados;
        }

        // Estos métodos permiten referenciar las variables
        // Hacemos multicasting
        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas += pMetodo;
        }

        public void EliminarMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas -= pMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado += pMetodo; // se agrega en el arrayList de métodos del delegado
        }

        public void EliminarMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado -= pMetodo;
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
                // Invocamos el método, que invoca todos los métodos que se hayen en su lista interna
                delReservas?.Invoke(kilos);  //delReservas(kilos); // 
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
