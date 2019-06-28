using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_04ICloneable
{
    interface IAutomovil
    {
        // Calcular el impuesto
        void CalculaTenencia(double imp);

        // Mostrar información
        void MuestraInformacion();
    }
}
