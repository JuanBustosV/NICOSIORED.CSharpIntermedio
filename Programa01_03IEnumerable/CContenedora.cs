using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_03IEnumerable
{
    class CContenedora:IEnumerable
    {
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }

        // Implementamos el GetEnumerator necesario por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Instanciamos el enumerador y lo devolvemos
            return (new ContenedorEnum(valores));
        }

        class ContenedorEnum : IEnumerator
        {
            public int[] array;
            private int posicion = -1;
            
            public ContenedorEnum(int [] pArray)
            {
                array = pArray;
                posicion = array.Length;
            }

            public bool MoveNext() 
            {
                //posicion++;   quiero recorrerlo de forma inversa, de atrás a delante
                posicion--;
                if (posicion > -1/*< array.Length*/)
                    return true;
                else
                    return false;
            }

            public void Reset()
            {
                posicion = array.Length; //-1;
            }

            public object Current
            {
                get
                {
                    try
                    {
                        return array[posicion];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }
                }
            }
        }
    }
}
