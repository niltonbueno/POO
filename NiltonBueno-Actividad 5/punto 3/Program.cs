using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*3.Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.*/








            int  n, positivo, negativo, multiplo, pares;
            pares = 0;
            multiplo = 0;
            positivo = 0;
            negativo = 0;
            string numero;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("ingrese un numero");
                numero = Console.ReadLine();
                n = int.Parse(numero);
                if (n > 0)
                {
                    positivo = positivo + 1;
                    
                }
                else
                {
                    
                    negativo += 1;
                }

                if (n % 15 == 0)
                {
                    multiplo = multiplo + 1;
                }
                if (n % 2 == 0)
                {
                    pares = pares + n;
                }
            }
            Console.Write("positivos: ");
            Console.WriteLine (positivo);

            Console.Write("negativos: ");
            Console.WriteLine(negativo);

            Console.Write ("este es divisible por 15: ");
            Console.WriteLine(multiplo);

            Console.Write("los pares son: ");
            Console.WriteLine(pares);

            Console.ReadKey();
        }
    }
}
