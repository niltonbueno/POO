using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class punto1
    {
        /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
            columna, luego la segunda columna y así sucesivamente)
            Imprimir luego la matriz.*/



        private int[,] valores;

            public void cargar ()
            {

            valores = new int[2, 5];
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0;  i < 2 ;  i++)
                {
                    Console.Write ("ingrese componentes: ");
                    string valor = Console.ReadLine ();
                    valores[i , j] = int.Parse (valor);

                }

            }

        }

        public void imprimir() 
        {
            for (int i = 0; i < 2; i++)
            {
                for ( int j = 0; j < 5; j++)
                {
                    
                    Console.Write(valores[i , j] + " ");

                }
                Console.WriteLine();
            }
        }






        static void Main(string[] args)
        {


            punto1 punto1 = new punto1();   
            punto1.cargar ();
            punto1 .imprimir();

            Console.ReadKey();
        }
    }
}
