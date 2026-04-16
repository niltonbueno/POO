using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class Program
    {
        /*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
             algoritmo de ordenamiento alfabético.*/
        class pais
        {
            string[] paises;

            public void cargar()
            {
                paises = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("agrege un pais: ");
                    string nombre = Console.ReadLine();
                    paises[i] = nombre;
                }
            }
            public void alfaveto()
            {
                Array.Sort(paises);
                Array.Reverse(paises);
            }
            public void escrito()
            {
                for (int g = 0; g < 5; g++)
                {
                    Console.WriteLine(paises[g]);

                }

            }

        }
        static void Main(string[] args)
        {
            pais paise = new pais();
            paise.cargar();
            paise.alfaveto();
            paise.escrito();


            Console.ReadKey();


        }
    }
}
