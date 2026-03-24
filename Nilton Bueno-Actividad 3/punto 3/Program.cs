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
            //3. Se ingresan por teclado tres números, si todos los valores ingresados
            //son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez"




            int num1, num2, num3;
            string numero;

            Console.Write("ingrese un numero 1 :");
            numero = Console.ReadLine();
            num1 = int.Parse(numero);

            Console.Write("ingrese un numero 2: ");
            numero = Console.ReadLine();
            num2 = int.Parse(numero);

            Console.Write("ingrese un numero 3: ");
            numero = Console.ReadLine();
            num3 = int.Parse(numero);

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {


                Console.Write("todos los valores son menores a 10");
                

               
            }



             Console.ReadKey();


        }
    }
}
