using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    internal class mayor
    {
        

        /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
            ordenado de menor a mayor y de mayor a menor.*/
        
       
            private int[] valores;

            public void cargar ()
            {
               valores = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"ingre un valor {i}: ");
                    string numero = Console.ReadLine();
                    valores[i] = int.Parse(numero);
                }
            }
            public void diferencia ()   
            {
                
                bool ascendente = true;
                bool descendente = true;
                for (int f = 0; f < valores.Length - 1; f++)
                {
                    if (valores[f] > valores[f + 1])
                    {
                        ascendente = false;
                    }

                    if (valores[f] < valores[f + 1])
                    {
                        descendente = false;
                    }
                }
                if (ascendente)
                {
                    Console.WriteLine("Es ascendente");
                }
                else if (descendente)
                {
                    Console.WriteLine("Es descendente");
                }
            }





        



        static void Main(string[] args)
        {

            mayor vl1 = new mayor();
            vl1.cargar();
            vl1.diferencia();

            Console.ReadKey();
        }
    }
}
