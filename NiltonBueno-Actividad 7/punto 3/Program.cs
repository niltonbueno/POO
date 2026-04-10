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

            /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
                    un videojuego. El programa debe:
                     Mostrar la puntuación más alta y la más baja.
                     Calcular el promedio de puntuación.
                     Contar cuántas veces superó los 500 puntos.*/



            private int[] puntuacion;
            private float promedio;
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
                    max = puntuacion[0];
                    min = puntuacion[0];
                    for (int f = 0; f < 6; f++)
                    {

                        if (puntuacion[f] > max)
                        {
                            max = puntuacion[f];

                        } 
                        
                    
                        if (puntuacion[f] < min)
                        {
                            min = puntuacion[f];
                        }
                    
                    }

                Console.Write("el maximo es: ");
                Console.WriteLine(max);

                Console.Write("el minimo es: ");
                Console.WriteLine(min);
            }
            public void promedios() 
            {
                float suma = 0;
                for (int f = 0; f < 6; f++)
                {
                    suma = puntuacion[f] + suma;
                }
                promedio = suma / 6 ;

                Console.Write("el promedio es: ");
                Console.WriteLine(promedio);
            }
            public void mayores() 
            {
                int mayor = 0;
                for (int g = 0; g < 6; g++)
                {
                    if (puntuacion[g] > 500)
                    {
                    

                        mayor = mayor + 1;


                    }
                }
                Console.Write("mayores a 500 hay: ");
                Console.WriteLine(mayor);

            }




        }


        static void Main(string[] args)
        {
            jugador points = new jugador();
            points.carga();
            points.diferencia();
            points.promedios();
            points.mayores();


        Console.ReadKey();
        }
    }
}
