using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Program
    {
        public class jugador
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
                }



            }







        }











        static void Main(string[] args)
        {
            jugador points = new jugador();
            points.carga();






        Console.ReadKey();
        }
    }
}
