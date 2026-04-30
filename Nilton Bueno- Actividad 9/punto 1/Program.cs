using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class punto1
    {
        /*1. Se desea desarrollar un programa que permita registrar los nombres y las
            calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
            nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
            estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
            máxima o mínima.*/



        private string[] nombre;
        private int[] calificacion;

        public void cargar() 
        {
            calificacion = new int[3];
            nombre = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ingrese los nombres: ");
                string valor = Console.ReadLine();
                nombre[i] = valor;
                    
                Console.Write("ingrese una calificacion: ");
                valor = Console.ReadLine();
                calificacion[i] = int.Parse(valor);
            }
        }
        public void valores ()
        {
            int mayor = calificacion[0];
            string nom = nombre[0];
            for (int i = 0; i < nombre.Length; i++)
            {
                if (calificacion[i] > mayor)
                {
                    mayor = calificacion[i];
                    nom = nombre[i];
                } 

            }

            Console.WriteLine("el mayor es: " + mayor);
            Console.WriteLine("el nombre es: " + nom);
        }
        public void menor()
        {
            int men = calificacion[0];
            string nom = nombre[0];
            for (int i = 0; i < nombre.Length; i++)
            {
                if (calificacion[i] < men)
                {
                    men = calificacion[i];
                    nom = nombre[i];
                }

            }

            Console.WriteLine("el menor es: " + men);
            Console.WriteLine("el nombre es: " + nom);
        }

        public void repetidos ()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (calificacion[i] == calificacion[i])
                    {
                        int aux;
                        aux = calificacion[j];
                        calificacion[j] = calificacion[j + 1];
                        calificacion[j + 1] = aux;    
                    }
                }
            }


        }




        static void Main(string[] args)
        {
            punto1 punto1 = new punto1();
            punto1.cargar();
            punto1.valores(); 
            punto1.menor();
            punto1.repetidos();
        }
    }
}
