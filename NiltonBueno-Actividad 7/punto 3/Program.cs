using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class jugador
    {
        
            private int[] puntuacion;

            public void carga ()
            {
                puntuacion = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    Console.Write($"ingre el puntaje de partida {i}: ");
                    string numero = Console.ReadLine();
                    puntuacion[i] = int.Parse(numero);
                }
            }
            public void diferencia() 
            {
                int max, min;
                max = 0;
                min = 0;
                for (int f = 0; f < 6; f++)
                {

                    if (puntuacion[f] > max)
                    {
                        max = puntuacion[f];
                    }
                    else
                    {
                        if (puntuacion[f] < max)
                        {
                            min = puntuacion[f];
                        }
                    }

                }
                Console.Write("la cantidad de min es: ");
                Console.WriteLine(min);

                Console.Write("la cantidad de max es: ");
                Console.WriteLine(max);
            }
            public void promediar() 
            {
                int 
                for (int i = 0; i < length; i++)
                {
                    



                }
            }

        

        static void Main(string[] args)
        {
            jugador points = new jugador();
            points.carga();
            points.diferencia();





        Console.ReadKey();
        }
    }
}
