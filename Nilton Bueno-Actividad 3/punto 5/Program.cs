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
                    if (X < 0 && Y < 0)
                    {
                        Console.Write("estas en el cuadrante 1");
                    }
                }
            }




            Console.ReadKey();




        }
    }
}
