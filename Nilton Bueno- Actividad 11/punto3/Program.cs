using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class admin
    {

        /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
            empresa.
            Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
            irregular para cargar los días que han faltado cada empleado (cargar el número de día que
            faltó)
            Cada fila de la matriz representa los días de cada empleado.
            a. Mostrar los empleados con la cantidad de inasistencias.
            b. Cuál empleado faltó menos días.*/
        private string[] trabajadores;
        private int[][] faltas;
        private int[] vol;

        public void cargar ()
        {
            trabajadores = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ingrese nombre: ");
                string val = Console.ReadLine();
                trabajadores[i] = val;
            }
            vol = new int[3];
            faltas = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ingrese sus falta " + trabajadores[i]  + ": ");
                string val = Console.ReadLine();
               vol[i] = int.Parse(val);
                faltas[i] = new int[vol[i]];
                for (int j = 0; j < faltas[i].Length; j++)
                {
                    Console.Write("ingrese dias: ");
                     val = Console.ReadLine();
                    faltas[i][j] = int.Parse(val);
                }
            }
        }
        
        public void imp ()
        {
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("el empleado " + trabajadores[i] + " falto: " + vol[i] + " dias");    
            }
        }
        public void mas ()
        {

            int menor = vol[0];
            string nam = trabajadores[0];
            for (int i = 0; i < 3; i++)
            {
                if (vol[i] < menor)
                {
                    menor = vol[i];
                    nam = trabajadores[i];   
                }
            }

            Console.WriteLine("el empleado con menos faltas es: " + nam + " con " + menor );
        }
        static void Main(string[] args)
        {
            admin admin = new admin();
            admin.cargar();
            admin.imp();
            admin.mas();

            Console.ReadKey();
        }
    }
}
