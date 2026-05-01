using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    internal class nombre
    {
        /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
            habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
            ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
            nuevamente.*/


        
            string[] paises;
            int[] abitantes;

            public void cargar()
            {

                paises = new string[5];
                abitantes = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("agrege un pais: ");
                    string nombre = Console.ReadLine();
                    paises[i] = nombre;

                    Console.Write("agrege la cantidad de habitantes: ");
                     nombre = Console.ReadLine();
                    abitantes[i] = int.Parse(nombre);

                }
            }
            public void alfavetico ()
            {
                //Array.Sort(paises);
                //Array.Sort(abitantes);
                for (int f = 0; f < 5; f++)
                {
                    for (int i = f + 1; i < 5; i++)
                    {
                        if (paises[f].CompareTo(paises[i]) < 0)
                        {
                            string aux;
                            aux = paises[i];
                            paises[i] = paises[f];
                            paises[f] = aux;
                            int auxAbit;
                            auxAbit = abitantes[i];
                            abitantes[i] = abitantes[f];
                            abitantes[f] = auxAbit;
                        }
                    }
                }
            }
            public void nomerico()
            {
                for (int f = 0; f < 5; f++)
                {
                    for (int i = f + 1; i < 5; i++)
                    {
                        if (abitantes[f] < abitantes[i])
                        {
                            int auxs;
                            auxs = abitantes[f];
                            abitantes[f] = abitantes[i];
                            abitantes[i] = auxs;
                            string auxPas;
                            auxPas = paises[f];
                            paises[f] = paises[i];
                            paises[i] = auxPas;
                        }
                    }
                }


            }


            public void imprimir() 
            {
                alfavetico();

                    alfavetico();

                    Console.WriteLine("Ordenado alfabetica");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(paises[i] + ": " + abitantes[i] + " Habitantes");


                    }
                    nomerico();

                    Console.WriteLine("Ordenado numericamente");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(paises[i] + ": " + abitantes[i] + " Habitantes");



                    }
               
            
            
            }

        

        static void Main(string[] args)
        {
            nombre nom = new nombre();
            nom.cargar();
            nom.alfavetico();
            nom.nomerico();
            nom.imprimir();




        }
    }
}
