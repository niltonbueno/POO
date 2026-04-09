using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del
            //primero con el segundo y a este resultado se lo multiplica por el tercero.

            int num1, num2, num3, resultado;
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


            if (num1 == num2 && num1 == num3)
            {
                resultado = (num1 + num2) * num3;


                Console.Write ("el resultado es: ");
                Console.WriteLine(resultado);

              
            }


            Console.ReadKey();


        }
    }
}
