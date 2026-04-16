using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    internal class Program
    {
        /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
            habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
            ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
            nuevamente.*/


        public class nombre
        {
            string[] paises;
            int[] abitantes;

            public void cargar()
            {

                paises = new string[5];
                abitantes = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("agrege un pais: ");
                    string nombre = Console.ReadLine();
                    paises[i] = nombre;

                    Console.Write("agrege la cantidad de habitantes: ");
                     nombre = Console.ReadLine();
                    abitantes[i] = int.Parse(nombre);

                }
            }
            public void orden ()
            {
                Array.Sort(paises);
                Array.Sort(abitantes);
            }

            public void imprimir() 
            {
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine(paises[f]);
                    Console.WriteLine(abitantes[f]);  
                }
               
            
            
            }

        }

        static void Main(string[] args)
        {
            nombre nom = new nombre();
            nom.cargar();
            nom.orden();
            nom.imprimir();




        }
    }
}
