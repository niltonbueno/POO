using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class punto1
    {
        /* 
         1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
            dato las temperaturas medias mensuales de dichos paises.
            Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
            mensuales.
            Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
            memoria.
            a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
            b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
                mismas.
            c. Calcular la temperatura media trimestral de cada país.
            d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
            e. Imprimir el nombre del país con la temperatura media trimestral mayor.
            */
        private string[] paises;
        private int[,] temperatura;
        private int[] tri;
        public void cargar()
        {
            paises = new string[4];
            temperatura = new int[4,3];
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("ingrese nombre del pais: ");
                string valor = Console.ReadLine();
                paises[i] = valor;
                for (int j = 0; j < temperatura.GetLength(1); j++)
                {
                    Console.Write(" ingrese temperatura: ");
                    valor = Console.ReadLine();
                    temperatura[i,j] = int.Parse(valor);
                }

            }
        }
        public void imprimir() 
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(paises[i]);
                for (int f = 0; f < 3; f++)
                {
                    Console.WriteLine(" - " + temperatura[i,f]);
                }
            }
        }
        public void mitad ()
        {
            tri = new int[4];

            for (int i = 0; i < temperatura.GetLength(0); i++)
            {
               int sum = 0;
               int div = 0;
                for (int j = 0; j < temperatura.GetLength(1); j++)
                {
                    sum = sum + temperatura[i, j];
                    div = sum / 3;
                }
                tri[i] = div;
                Console.WriteLine(paises[i] + ": " + tri[i]);
            }
        }
        
        public void trymayor ()
        {
            int mayor = tri[0];
            string pa = paises[0];

            for (int p = 0; p < paises.Length; p++)
            {
                if (tri[p] > mayor)
                {
                    mayor = tri[p];
                    pa = paises[p];
                }
            }
            Console.WriteLine("el mayor es: " + pa + ": " + mayor);





        }

        static void Main(string[] args)
        {

            punto1 put = new punto1();
            put.cargar();
            put.imprimir();
            put.mitad();
            put.trymayor();


            Console.ReadKey();
        }
    }
}
