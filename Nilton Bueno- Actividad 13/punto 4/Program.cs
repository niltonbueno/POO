using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
     class alumnos
    {
        /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
            vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
            alumno y sus 4 calificaciones.
            Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
            Alumno.
            Agregar los siguientes métodos:
            a) Un método que imprima el nombre de cada alumno y su promedio.
            b) Un método que muestre el nombre del alumno con el promedio más
            alto.
            c) Un método que indique qué alumnos tienen al menos una nota
            desaprobada (nota menor a 6)*/
        private string nombre;
        private int[] notas;
        private float medio = 0;
        public alumnos ()
        {
            Console.Write("ingrese el nombre: ");
            string van = Console.ReadLine();
            nombre = van;

            notas = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("ingrese la calificacion calificacion " + (i + 1) + " : ");
                 van = Console.ReadLine();
                notas[i] = int.Parse(van);

            }


        }


        public void promedio ()
        {
           
            int sum = 0;
            sum = notas[0] + notas[1] + notas[2] + notas[3];

            medio = sum / 4;
        }

        public void imprimir ()
        {
            Console.WriteLine("el nombre del alumno: " + nombre);
            Console.WriteLine("el promedio es: " + medio);


        }

        class Curso
        {
            private alumnos[] val1;
           
            public Curso() 
            {
                val1 = new alumnos[3];
                
            }


        }

        static void Main(string[] args)
        {
            alumnos al = new alumnos();
            al.promedio();
            al.imprimir();

            Console.ReadKey();
        }
    }
}
