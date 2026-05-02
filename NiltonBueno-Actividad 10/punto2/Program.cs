using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class punto2
    {
        /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
            primer fila con la segunda. Imprimir luego la matriz.*/


        private int[,] valores;
        private int fila1;
        private int fila2;  

        public void valore ()
        {
            Console.Write("ingrese la cantidad de filas: ");
            string numero = Console.ReadLine();
            fila1 = int.Parse(numero);

            Console.Write("ingrese la cantidad de columnas: ");
            numero = Console.ReadLine();
            fila2 = int.Parse(numero);
        }




        public void carga ()
        {

            valores = new int[fila1, fila2];

            for (int i = 0; i < fila1; i++)
            {
                for (int j = 0; j < fila2; j++)
                {
                    Console.Write("ingrese el valor:");
                    string num = Console.ReadLine();
                    valores[i, j] = int.Parse(num);
                }
            }

        }

        public void cambio ()
        {
            for (int j = 0; j < fila2; j++)
            {
                int cam = valores[0 , j];
                valores[0 , j] = valores[1 , j];
                valores[1 , j] = cam;


            }






        }



        public void imprimir() 
        {
            for (int i = 0; i < fila1; i++)
            {
                for (int j = 0; j < fila2;  j++)
                {
                    Console.Write(valores [i , j] + " ");
                }
                Console.WriteLine();

            }
        }



        static void Main(string[] args)
        {
            punto2 punto2 = new punto2();   
            punto2.valore();
            punto2.carga();
            punto2.cambio();
            punto2.imprimir();


            Console.ReadKey();
        }
    }
}
