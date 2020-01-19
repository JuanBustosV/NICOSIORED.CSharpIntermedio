using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01._05IComparable
{
    class CRectangulo : IComparable
    {
        // Propiedades
        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double Area { get; set; }

        // Constructor

        public CRectangulo(double pAncho, double pAlto)
        {
            Ancho = pAncho;
            Alto = pAlto;
            CalculaArea();
        }

        private void CalculaArea()
        {
            Area = Ancho * Alto;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]={2}", Ancho, Alto, Area);
        }

        // Implementación de IComparable

        int IComparable.CompareTo(object obj)
        {
            // Hacemos type cast con el objeto con el cual nos vamos a comparar
            CRectangulo temp = (CRectangulo)obj;

            // Si somos más grandes que el objeto devolvemos 1
            if (Area > temp.Area)
                return 1;

            // Si somos más pequeños que el objeto devolvemos -1
            if (Area < temp.Area)
                return -1;

            // Si somos iguales al objeto devuelve 0
            return 0;
        }
    }
}
