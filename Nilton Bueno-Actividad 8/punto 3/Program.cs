using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class vectores
    {
        /*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
             (el orden lo pueden elegir ustedes).*/
        
            int[] valores;
            int numero;
            int menor;
            public void cargar () 
            {
                Console.Write("ingrese la cantidad de valores: ");
                string numeros = Console.ReadLine();
                numero = int.Parse(numeros);

                valores = new int[numero];

                for (int i = 0; i < valores.Length; i++)
                {
                    Console.Write("ingrese un valor entero: ");
                    numeros = Console.ReadLine();
                    valores[i] = int.Parse(numeros);
                }
            }
            public void diferencia() 
            {
                Array.Sort(valores);
            }
            public void imprimir ()
            {
                for (int g = 0; g < valores.Length; g++)
                {
                    Console.WriteLine(valores[g]);




                }



            }
        
        
        static void Main(string[] args)
        {
            vectores vectores = new vectores();
            vectores.cargar();
            vectores.diferencia();
            vectores.imprimir();



        }
    }
}
