using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

            if (num1 < 10)
            {
                Console.Write("alguno es1 menor a 10");
            }
            else
            {
                if (num2 < 10)
                {
                    Console.Write("alguno es2 menor a 10");
                }
                else
                {
                    if (num3 < 10)
                    {
                        Console.Write("alguno es3 menor a 10");
                    }
                }
            }


            Console.ReadKey();





        }
    }
}
