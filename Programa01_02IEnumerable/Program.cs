using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    class Program
    {        
        /*
         public interface IEnumerable
         {
            IEnumerator GetEnumerator();
         }

        public interface IEnumerator
        {
            bool MoveNext();
            object Current { get; }
            void Reset;
        }
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Creamos la tienda
            CTiendaAutos tienda = new CTiendaAutos();

            // Recorremos cada uno de los elementos de la
            // estructura que expone
            foreach (CAuto miAuto in tienda)
            {
                miAuto.CalculaTenencia(0.05);
                miAuto.MuestraInformacion();
            }
        }
    }
}
