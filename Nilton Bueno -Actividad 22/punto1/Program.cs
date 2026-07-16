using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class gimnasio
    {
        /*Actividad 1: Control de horarios en un gimnasio
            Problema:
            Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
            DateTime).
            ● Implementar un constructor que permita cargar los datos desde consola y otro
            que cargue valores por defecto (sobrecarga de constructores).
            ● Incluir un método para calcular la duración de la clase usando TimeSpan.
            ● Crear un vector de 3 clases de gimnasio y mostrar:
            1. La clase que tenga la mayor duración.
            2. El nombre y el horario de inicio de la clase más temprana.*/
        private string NombreClase;
        private DateTime HoraInicio;
        private DateTime HoraFin;
        private gimnasio[] val;  
        public gimnasio()
        {
            Console.Write("ingrese un nombre de la clase: ");
            string val = Console.ReadLine();
            this.NombreClase = val;

            Console.Write("ingrese su hora de inicio (hora:minuto): ");
            val = Console.ReadLine();
            this.HoraInicio = DateTime.Parse(DateTime.Today.ToShortDateString() +" "+ val);

            Console.Write("ingrese su hora de fin (hora:minuto): ");
            val = Console.ReadLine();
            this.HoraFin = DateTime.Parse(DateTime.Today.ToShortDateString() + " " + val);

            
        }

        public gimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {
            this.NombreClase = nombreClase;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
        }

        public TimeSpan duracion()
        {
            return this.HoraFin - this.HoraInicio;
        }

        public override string ToString()
        {
            return $"nombre de la clase: {NombreClase} |hora de inicio: {HoraInicio:HH:mm} |hora de fin: {HoraFin:HH:mm} |duracion: {duracion()}";
        }
        
        

        static void Main(string[] args)
        {
            gimnasio[] clases = new gimnasio[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"||Ingrese la clase n° {i + 1} ||");
                clases[i] = new gimnasio();
            }

            foreach (gimnasio n in clases)
            {
                Console.WriteLine(n);
            }

            TimeSpan duracion = clases[0].duracion();


            for (int i = 0; i < 3; i++)
            {
                TimeSpan mayorduracion = clases[i].duracion();

                if (duracion < mayorduracion)
                {
                    duracion = mayorduracion;
                }

            }
            Console.WriteLine($"la mayor duracion es: {duracion}");

            DateTime inicio = clases[0].HoraInicio;
            string name = clases[0].NombreClase;

            for (int i = 0; i < 3; i++)
            {
              
                if (inicio > clases[i].HoraInicio)
                {
                    inicio = clases[i].HoraInicio;
                    name = clases[i].NombreClase;
                    
                }

            }
            Console.WriteLine($"el que inicia mas temprano es: {name} | inicia a las: {inicio:hh:mm}");

        }
    }
}
