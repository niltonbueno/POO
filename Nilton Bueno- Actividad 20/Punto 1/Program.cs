using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Vuelo
    {
        /*Actividad 1: Sistema de control de vuelos
            Problema:
            Una aerolínea administra los vuelos programados mediante un sistema orientado a
            objetos.
            Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
            destino y duración en horas. Luego definir una clase derivada VueloInternacional que
            herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
            Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
            desde consola y luego:
                 Mostrar los vuelos registrados y el país de destino.
                 Informar cuál es el vuelo con mayor duración.
                 Mostrar el orden de ejecución de los constructores.*/

        private int numero;
        private string destino;
        private int duracion;
        
        public Vuelo(int nom, string des, int dur)
        {
            numero = nom;
            destino = des;
            duracion = dur;
            Console.WriteLine("se ejecuto construct Vuelo");
        }

        public int numer
        {
            get { return numero; }
        }

        public int Duracion
        {
            get { return duracion; }
        }

        public string Destino
        {
            get { return destino; }
        }

    }
    class VueloInternacional : Vuelo
    {
        string DestinoPais;
        public VueloInternacional(int nom, string des, int dur, string daP) : base(nom, des, dur)
        {
            Console.WriteLine("se ejecuto construct Vuelointernacional");
            DestinoPais = daP;
        }

        public string DuracionPais
        {
            get { return  DestinoPais;  }
        }

        static void Main(string[] args)
        {
            
            List<VueloInternacional> NuevoVuelo = new List<VueloInternacional>();
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"====pasaje n° {i + 1}=====");

                Console.Write("ingrese el destino: ");
                string des = Console.ReadLine();
                
                Console.Write("ingrese el numero de vuelo: ");
                int nom = Convert.ToInt32(Console.ReadLine());

                Console.Write("ingrese la duracion del vuelo: ");
                int dur = Convert.ToInt32(Console.ReadLine());

                Console.Write("ingrese el pais destino: ");
                string daP =  Console.ReadLine();

                VueloInternacional nuevoVuelo = new VueloInternacional(nom, des, dur, daP);
                NuevoVuelo.Add(nuevoVuelo);
            }
            int mayor = NuevoVuelo[0].Duracion;
            int nv = NuevoVuelo[0].numer;
          

            foreach (VueloInternacional n in NuevoVuelo)
            {

                Console.WriteLine($"nombre: {n.Destino} | numero de vuelo: {n.numer} | duracion del viaje: {n.Duracion} | Destino Pais: {n.DuracionPais}");
            }

            for (int i = 0; i < 5; i++)
            {
                if (mayor < NuevoVuelo[i].Duracion)
                {
                    mayor = NuevoVuelo[i].Duracion;
                    nv = NuevoVuelo[i].numer;
                }

            }

            


            Console.WriteLine($"el vuelo con mayor duracion es {nv} con {mayor} de duracion");

            Console.ReadKey();
        }
    }
}
