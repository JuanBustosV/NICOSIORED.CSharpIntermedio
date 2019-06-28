using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    interface IAutomovil
    {
        // Calcular el impuesto
        void CalculaTenencia(double imp);

        // Mostrar información
        void MuestraInformacion();
    }
}
