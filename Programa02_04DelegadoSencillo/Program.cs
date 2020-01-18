using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CA1707 // Identifiers should not contain underscores
namespace Programa02_04DelegadoSencillo
#pragma warning restore CA1707 // Identifiers should not contain underscores
{
    // Definimos el delegado con las características que nos interesa
    public delegate void MiDelegado(string m);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# intermedio 9 --- Delegados I";

            // Creamos un objeto del delegado y lo referenciamos a un método
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);

            // Ahora por medio del delegado hacemos uso del método
            delegado("Hola a todos");

            Console.WriteLine();

            // Hacemos que apunte a otro método
            delegado = new MiDelegado(CPastel.MostrarPastel);

            // Ahora invocamos el otro método
            delegado("Feliz cumpleaños");

        }
    }
}
