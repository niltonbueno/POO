using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class Program
    {
        public class Valores
        {
            /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
            El valor acumulado de todos los elementos del vector.
            El valor acumulado de los elementos del vector que sean mayores a 36.
            Cantidad de valores mayores a 50.*/



            private int[] elementos;
            private int resultado;
           
            public void cargar()
            {
                elementos = new int[8];


                for (int i = 0; i < 8; i++)
                {
                    Console.Write("ingrese un valor: ");
                    string numero;
                    numero = Console.ReadLine();
                    elementos[i] = int.Parse(numero);
                }

            }
            public void acumulacion() 
            { int suma;
              suma = 0;
                for (int f = 0; f < 8; f++)
                {
                    suma = suma + elementos[f];     

                }
                resultado = suma;

                Console.Write("el resultado seria: ");
                Console.WriteLine(resultado);
            }
            public void diferencia()
            {
                int valor1;
                valor1 = 0;

                int valor2;
                valor2 = 0;

                for (int g = 0; g < 8; g++)
                {
                    if (elementos[g] > 36 && elementos[g] < 50)
                    {
                      
                        valor1 += 1;
                    }
                    else
                    {
                        if (elementos[g] >= 50)
                        {
                            
                            valor2 += 1;
                        }
                    }
                }

                Console.Write("hay mayores a 36: ");
                Console.WriteLine(valor1);
                
                
                Console.Write("hay mayores a 50: ");
                Console.WriteLine(valor2);
            }
        
        }
        static void Main(string[] args)
        {
            Valores vl1 = new Valores();
            vl1.cargar();
            vl1.acumulacion();
            vl1.diferencia();



            Console.ReadKey();


        }
    }
}
