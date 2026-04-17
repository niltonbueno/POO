using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class Program
    {
        /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
        el vector.*/

        public class repeticion
        {
            int[] numeros;
            int menor;
            public void cargar() 
            {
                numeros = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("Agrege un numero: ");
                    string valor = Console.ReadLine();
                    numeros[i] = int.Parse(valor);
                }
            }
            public void numeroM()
            {
                menor = numeros[0];

                for (int f = 0; f < numeros.Length; f++)
                {
                    if (numeros[f] < menor)
                    {
                        menor = numeros[f];
                    }
                }
                Console.Write("el numero menor es: ");
                Console.WriteLine(menor);
            }
            public void repeticiones()
            {
                int repetido = 0;
                for (int g = 0; g < numeros.Length; g++)
                {
                    if (numeros[g] == menor)
                    {
                        repetido++;
                    }
                }
                Console.Write("la cantidad de veces que se repite el menor es: ");
                Console.WriteLine(repetido);
            }

        }

        static void Main(string[] args)
        {
            repeticion rep = new repeticion();
            rep.cargar();
            rep.numeroM();
            rep.repeticiones();


        }
    }
}
