using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            //muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            //39.







            int x, resultado;
            resultado = 1;
            string numero;
            
            Console.Write("ingre un numero: ");
            numero = Console.ReadLine();
            x = int.Parse(numero);

            if (x > 10)
            {
                Console.Write("ingrese otro numero");
            }
            else
            {
                for (int i = 1; i < 13; i++)
                {

                    resultado = i * x;
                    Console.WriteLine(resultado + "-");
                }
            }

            Console.ReadKey();


        }
    }
}
