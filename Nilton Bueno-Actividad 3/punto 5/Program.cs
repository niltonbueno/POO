using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5. Escribir un programa que pida ingresar la coordenada de un punto en el plano, 
             * es decir dos valores enteros x e y (distintos a cero).
             * Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. 
             * (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0)*/
            
            
            
            int X, Y;
            string coordenada;

            Console.Write("ingrese Coordenada X :");
            coordenada = Console.ReadLine();
            X = int.Parse(coordenada);

            Console.Write("ingrese coordenada Y :");
            coordenada = Console.ReadLine();
            Y = int.Parse(coordenada);

            if (X == 0 && Y == 0)
            {
                Console.Write("no pongas 0");   
            }
            else
            {
                if (X > 0 && Y > 0)
                {
                    Console.Write("estas en el cuadrante 2");
                }
                else
                {
                    if (X < 0 && Y > 0)
                    {
                        Console.Write("estas en el cuadrante 1");
                    }
                }
            }




            Console.ReadKey();




        }
    }
}
