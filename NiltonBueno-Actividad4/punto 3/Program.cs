using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            // ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            // valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int  x, n;
            n =     0;
            string numero;

            do
            {
                Console.Write("ingrese un numero: ");
                numero = Console.ReadLine();
                x = int.Parse(numero);

                if (x != 9999)
                {
                    n = n + x;
                }



            }
            while (x != 9999);

            Console.Write("el total es: ");
            Console.WriteLine(n);

            if (n > 0)
            {
                Console.Write("es mayor a 0");

            }
            else
            {
                if (n < 0)
                {
                    Console.Write("es menor a 0");

                }
                else
                {
                                Console.Write("el igual que cero ");

                }
            }






        }
    }
}
