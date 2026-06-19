using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class pasajeros
    {
        /*2. Control de Vuelos
            Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
            Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
            Agregar los siguientes métodos en la clase Vuelo:
                3 Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
                2 Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
                1 Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.   */
        private string nombre;
        private int dni;
        private float EquipajeKilos;
    
        public pasajeros()
        {
            Console.Write("ingrese un nombre: ");
            string val = Console.ReadLine();
            nombre = val;

            Console.Write("ingrese su DNI: ");
            val = Console.ReadLine();
            dni = int.Parse(val);

            Console.Write("ingrese el peso de su equipaje: ");
            val = Console.ReadLine();
            EquipajeKilos= float.Parse(val);
        }
    
        public string Nombre()
        {
            return nombre;
        }

        public int DNI ()
        {
            return dni;
        }

        public float EQUIPAJE ()
        {
            return EquipajeKilos;
        }

    }
    
    public class Vuelo
    {
        private pasajeros[] val;
        
        private Vuelo()
        {
            val = new pasajeros[4];

            for (int i = 0; i < val.Length; i++)
            {
                Console.Write("pasajero "+ (i + 1) + ": ");
                val[i]= new pasajeros();
            }

        }

        private void imp()
        {

            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine("datos del pasajero " +(i + 1) + ": " + val[i].Nombre() + " Dni: " + val[i].DNI() + " Peso del equipaje: " + val[i].EQUIPAJE());
            }
        }

        private void total()
        {
            float all = 0;
            for (int i = 0; i < val.Length; i++)
            {
                all = all + val[i].EQUIPAJE();
            }

            Console.WriteLine("el total es: " + all);
            
        }

        private void com ()
        {
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i].EQUIPAJE() > 23 )
                {
                    Console.WriteLine("le peso es excedio los 23 kg: " + val[i].Nombre() + " Dni: " + val[i].DNI() + " peso actual: " + val[i].EQUIPAJE());
                }
            }


        }


        static void Main(string[] args)
        {
            Vuelo vuelo = new Vuelo();
            vuelo.imp();
            vuelo.total();
            vuelo.com();

            Console.ReadKey();
        }
    }
}
