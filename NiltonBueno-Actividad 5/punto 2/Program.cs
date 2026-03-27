using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*2.Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
            iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/



            int  l1,l2,l3, equilatero, isoceles, escaleno;
            equilatero = 0;
            isoceles = 0;
            escaleno = 0;
            string lados;

         
            for (int i = 0; i < 2; i++)
            {

                Console.Write("--------");
                
                Console.WriteLine("ingre un lado: ");
                lados = Console.ReadLine();
                l1 = int.Parse(lados);


                Console.WriteLine("ingre un lado: ");
                lados = Console.ReadLine();
                l2 = int.Parse(lados);


                Console.WriteLine("ingre un lado: ");
                lados = Console.ReadLine();
                l3 = int.Parse(lados);

                if (l1 == l2 && l2 == l3)
                {
                    equilatero = equilatero + 1; 
                    Console.Write("es equilatero"); 
                }
                else
                {
                    if (l2 == l3 || l1 == l3 || l1 == l2)
                    {
                        isoceles = isoceles + 1;
                        Console.Write("es isoceles");

                    }
                    else
                    {
                      
                            escaleno = escaleno + 1;
                            Console.Write("ninguno es igual");
                        
                    }
                }






            }

            Console.Write("la cantidad de equilateros es: ");
            Console.WriteLine(equilatero);

            Console.Write("la cantidad de isoceles es: ");
            Console.WriteLine(isoceles);

            Console.Write("la cantidad de escaleno es: ");
            Console.WriteLine(escaleno);

            if (equilatero > escaleno && equilatero > isoceles)
            {
                Console.Write("el tringualo que posee menor cantidad es el equilatero ");

            }
            else
            {
                if (isoceles < equilatero && isoceles < escaleno)
                {
                    Console.Write("el tringualo que posee menor cantidad es el isoceles ");
                }
                else
                {
                    Console.Write("el tringualo que posee menor cantidad es el escaleno ");
                }
            } 



            Console.ReadKey();



        }
    }
}
