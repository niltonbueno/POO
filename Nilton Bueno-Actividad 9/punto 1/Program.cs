using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class school
    {
        private string[] alumnoos;
        private int[] notas;    
        public void cargar () 
        {

            notas = new int[6];
            alumnoos = new string[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("ingrese el nombre del alumno");
                string valor = Console.ReadLine();
                alumnoos[i] = valor;

                Console.Write("ingrese el nombre del alumno");
                valor = Console.ReadLine();
                notas[i] = int.Parse(valor);

            }


        }





        static void Main(string[] args) 
        {
        }
    }
}
