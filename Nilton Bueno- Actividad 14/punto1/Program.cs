using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Vehiculos
    {
        /*1. El Sistema de Peaje.
            Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
            La clase Vehiculo debe tener los siguientes atributos privados:
            Patente (de tipo string).
            Tipo (puede ser "Auto", "Camion" o "Moto").
            Tarifa (un valor decimal que representa el costo de su pase).
            El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
            La clase CabinaPeaje debe tener como atributos privados:
            El número o identificador de la cabina.
            Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
            Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
            Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
            Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
            Un método que muestre la patente del vehículo que pagó la tarifa más cara.
            */
        private string patente;
        private string tipo;
        private double tarifa;

        public Vehiculos ()
        {
            Console.Write("ingrese la patente: ");
            string van = Console.ReadLine();
            patente = van;

            Console.Write("ingrese la patente: ");
            van = Console.ReadLine();
            tipo = van;

            Console.Write("ingrese la patente: ");
            van = Console.ReadLine();
            tarifa = double.Parse(van);
        }


        class CabinaPaja
        {
            private int ident;
            private Vehiculos[] val1;
            private CabinaPaja ()
            {
                val1 = new Vehiculos [3];

                for (int i = 0; i < 3; i++)
                {
                    val1[i] = new Vehiculos();
                }

            }
            

            public void aparte ()
            {

            }

        }



        static void Main(string[] args)
        {





            
        }
    }
}
