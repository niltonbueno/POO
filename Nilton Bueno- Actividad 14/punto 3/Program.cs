using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace punto_3
{
    class Atleta
    {
        /*3. Competencia de Atletismo
            Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
            Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
            Definir los siguientes métodos en la clase Carrera:
                Un constructor que cargue los datos de los 3 atletas de la carrera.
                Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
                Un método que calcule e imprima el tiempo promedio de la carrera.
                Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
                Un método que muestre a los atletas que superaron el promedio.
                */
        private string nombre;
        private double Timesegundo;

        public Atleta()
        {
            Console.Write("ingrese un nombre: ");
            string val = Console.ReadLine();
            nombre = val;

            Console.Write("ingrese la duracion de la carrera: ");
            val = Console.ReadLine();
            Timesegundo = double.Parse(val);
        }
        
        public string NOMBRE()
        {
            return nombre;
        }
    
        public double TIEMPO()
        {
            return Timesegundo;

        }
        
    }
    class carrera
    {
        private double total;
    
        private Atleta[] val;

        public carrera() 
        { 
            val = new Atleta[3];
            for (int i = 0; i < val.Length; i++)
            {
                val[i] = new Atleta();
            } 
        }
      
        public void imp ()
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine("nombre: " + val[i].NOMBRE() + " duracion: " + val[i].TIEMPO());
            }
        }        
        
        public void pro ()
        {
            double promedio = 0;
            total = 0;
            for (int i = 0; i < val.Length; i++)
            {
                promedio = promedio + val[i].TIEMPO();
            }

            total = promedio / 3;

            Console.WriteLine("el promedio es: " + total );
        }

        public void winner() { 
        double ganador = val[0].TIEMPO();
        string name = val[0].NOMBRE();

            for (int i = 0; i < val.Length; i++)
            {
                if (ganador > val[i].TIEMPO())
                {
                    ganador = val[i].TIEMPO();
                    name = val[i].NOMBRE();
                }
            }

            Console.WriteLine("el ganador es: " + name);
        }

        public void superior ()
        {

            string na = val[0].NOMBRE();

            for (int i = 0; i < val.Length; i++)
            {
                if (total > val[i].TIEMPO())
                {
                    total = val[i].TIEMPO();
                    na = val[i].NOMBRE();

                    Console.WriteLine("quienes superaron el promedio fueron: " + na);
                }
            }


        }


        static void Main(string[] args)
        {
            carrera carrera = new carrera();
            carrera.imp();
            carrera.pro();
            carrera.winner();
            carrera.superior();

                
            Console.ReadKey();
        }
    }
}
