using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class cuenta
    {
        
            private int[] vecto1;
            private int[] vecto2;
            private int[] vecto3;

            public void carga ()
            {
                vecto1 = new int[4];
                vecto2 = new int[4];

                for (int i = 0; i < 4; i++)
                {

                    Console.Write("ingrese los primero numero: ");
                    string numero = Console.ReadLine();
                    vecto1[i] = int.Parse(numero);

                    Console.Write("ingrese los segundo numero: ");
                    numero = Console.ReadLine();
                    vecto2[i] = int.Parse(numero);
                }
            }
            public void sumas ()
            {
                vecto3 = new int[4];
                for (int f = 0; f < 4; f++)
                {
                    int suma = 0;
                    suma = vecto1[f] + vecto2[f]; 
                    vecto3 [f] = suma;

                    Console.WriteLine(vecto3[f]);
                }
            }

        
        static void Main(string[] args)
        {

            cuenta cuent1 = new cuenta();
            cuent1.carga();
            cuent1.sumas();

            Console.ReadKey();

        }
    }
}
