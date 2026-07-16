using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    class Vuelo
    {
        /*Actividad 4: Gestión de vuelos
            Problema:
            Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
            ● Usar la palabra clave this en el constructor para diferenciar los parámetros de
            los atributos.
            ● Crear un método para calcular la duración del vuelo (TimeSpan).
            ● Cargar un vector con 4 vuelos y mostrar:
            1. El código y duración del vuelo más largo.
            2. El código del vuelo que salga más temprano.*/
        public string Codigo;
        public DateTime HoraSalida;
        public DateTime HoraLlegada;

        public Vuelo()
        {
            Console.Write("ingrese el codigo: ");
            string val = Console.ReadLine();
            this.Codigo = val;

            Console.Write("ingrese su hora de llegada (hora:minuto): ");
            val = Console.ReadLine();
            this.HoraLlegada = DateTime.Parse(DateTime.Today.ToShortDateString() + " " + val);

            Console.Write("ingrese su hora de salida (hora:minuto): ");
            val = Console.ReadLine();
            this.HoraSalida = DateTime.Parse(DateTime.Today.ToShortDateString() + " " + val);

        }

        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
          
            this.Codigo = codigo;
            this.HoraSalida = horaSalida;
            this.HoraLlegada = horaLlegada;
        }

        public TimeSpan duracion()
        {
            return this.HoraSalida - this.HoraLlegada;
        }

        public override string ToString()
        {
            return $"el codigo: {Codigo} | la hora de salida: {HoraSalida:HH:mm} | la hora de llegada: {HoraLlegada:HH:mm} | duracion del vuelo: {duracion()}";
        }


      
            static void Main()
            {
              

                Vuelo[] vue = new Vuelo[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"||Ingrese el elemento n° {i + 1} ||");
                vue[i] = new Vuelo();
            }

            foreach (Vuelo v in vue)
            {
                Console.WriteLine(v);
            }

            
            TimeSpan masLargo = vue[0].duracion();
            string codigo = vue[0].Codigo;

            for (int i = 0; i < 4; i++)
            {
                if (masLargo < vue[i].duracion())
                    {
                    masLargo = vue[i].duracion();
                    codigo = vue[i].Codigo;
                    }
                }
                Console.WriteLine($"Vuelo más largo es: {codigo}| una duracion de {masLargo}");

            TimeSpan masCorto = vue[0].duracion();
            string codigo2 = vue[0].Codigo;
            for (int i = 0; i < 4; i++)
            {
                if (masCorto > vue[i].duracion())
                {
                    masCorto = vue[i].duracion();
                    codigo2 = vue[i].Codigo;
                }
            }
            Console.WriteLine($"Vuelo más corto es: {codigo2}");

            }
        
    }
}    
