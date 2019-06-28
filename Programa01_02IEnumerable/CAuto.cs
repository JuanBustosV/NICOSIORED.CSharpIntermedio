using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    class CAuto:IAutomovil
    {
        double precio;
        double tenencia;
        string modelo;

        // Constructor
        public CAuto(string pModelo, double pPrecio)
        {
            // Inicializamos los datos
            precio = pPrecio;
            modelo = pModelo;
        }

        // Métodos interfaz
        public void CalculaTenencia(double pImpuesto)
        {
            // Calculamos el impuesto
            tenencia = 5000.0 + precio * pImpuesto;
        }

        public void MuestraInformacion()
        {
            // Mostramos la información necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Precio {0:C}, con una tenencia de {1:C}.", precio, tenencia);
            Console.WriteLine("Total {0:C}", precio + tenencia);
            Console.WriteLine("-------------");
        }
    }
}
