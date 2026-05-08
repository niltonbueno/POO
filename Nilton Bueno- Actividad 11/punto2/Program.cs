using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class irrege
    {
        /* 2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
            primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
            (crearla sin la intervención del operador)
            Realizar la carga por teclado e imprimir posteriormente.*/

        private int[][] valor;

        public void cargar ()
        {

            valor = new int[6][];

            for (int i = 0; i < 6 ; i++)
            {
                valor[i] = new int[i];
                for (int j = 0; j < i; j++)
                {
                    Console.Write("ingrese valor: ");
                    string val = Console.ReadLine();
                    valor[i][j]= int.Parse(val);
                }
            } 
        }
        public void imprimir ()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < valor[i].Length ; j++)
                {
                    Console.Write(valor[i][j] + " ");
                }
                Console.WriteLine();    
            }

        }

        static void Main(string[] args)
        {
            irrege irg = new irrege();
            irg.cargar();
            irg.imprimir();

            Console.ReadKey();
        }
    }
}
