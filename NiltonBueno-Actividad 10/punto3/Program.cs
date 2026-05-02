using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class punto3
    {
        private int[,] valores;
        private int fila1;
        private int fila2;
        public void valore()
        {
            Console.Write("ingrese la cantidad de filas: ");
            string numero = Console.ReadLine();
            fila1 = int.Parse(numero);

            Console.Write("ingrese la cantidad de columnas: ");
            numero = Console.ReadLine();
            fila2 = int.Parse(numero);
        }
        public void carga()
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

        public void lados()
        {
            Console.WriteLine(valores[0,0]);

            Console.WriteLine(valores[0 ,fila2 - 1]);

            Console.WriteLine(valores[fila1 - 1, 0]);

            Console.WriteLine(valores[fila1 - 1, fila2 - 1]);
        }













        static void Main(string[] args)
        {
            punto3 punto3 = new punto3();
            punto3.valore();
            punto3.carga();
            punto3.lados();


        }
    }
}
