using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class RegistroDeEntrenamientos
    {
        /*Actividad 3: Registro de entrenamientos
            Problema:
            Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
            ● Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
            1. Uno que reciba horas y minutos y los convierta a minutos.
            2. Otro que reciba directamente los minutos.
            ● Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
            más corto.*/
        private String Deportista;
        private int duracion;

        public RegistroDeEntrenamientos(string deportista)
        {
            this.Deportista = deportista;
            this.duracion = 0;
        }

        public void RegistroDuracion(int horas, int minutos)
        {
            this.duracion = horas * 60 + minutos;

        }

        public void RegistroDuracion(int minutos)
        {
            this.duracion = minutos;
        }

        public override string ToString()
        {
            return $"nombre del deportista: {Deportista} |duracion: {duracion}";
        }



        static void Main(string[] args)
        {
            List<RegistroDeEntrenamientos> nuevo = new List<RegistroDeEntrenamientos>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Entrenamiento {i + 1}");

                Console.Write("Nombre del deportista: ");
                string nombre = Console.ReadLine();

                RegistroDeEntrenamientos entrenamiento = new RegistroDeEntrenamientos(nombre);

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Minutos: ");
                int minutos = int.Parse(Console.ReadLine());

                entrenamiento.RegistroDuracion(horas, minutos);

                nuevo.Add(entrenamiento);
            }

            int mayor = nuevo[0].duracion;
            for (int i = 0; i < 5; i++)
            {
                if (mayor < nuevo[i].duracion)
                {
                    mayor = nuevo[i].duracion;
                }
            }
            Console.WriteLine($"el mas largo es: {mayor}");

            int menor = nuevo[0].duracion;
            for (int i = 0; i < 5; i++)
            {
                if (menor > nuevo[i].duracion)
                {
                    menor = nuevo[i].duracion; 
                }
            }
            Console.WriteLine($"el mas corto es: {menor}");

            Console.ReadKey();
        }
    }
}
