using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class dron
    {
        private string codigo;
        private int nivelBateria;
    
        public dron(string cod, int Bat)
        {
            this.codigo = cod;
            this.nivelBateria = Bat;
        }

        public string Codigo()
        {
            return codigo;
        }

        public int NivelBateria()
        {
            
            if (nivelBateria < 0 || nivelBateria > 100)
            {
                nivelBateria = 1;
            }
            return nivelBateria;
        }
    }
    class centroControl
    {
        List<dron> drones = new List<dron>();
        public centroControl()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"----Dron n* {i+1} ----");
                Console.Write("ingrese el codigo: ");
                string val = Console.ReadLine();
                string  cod = val;
            
                Console.Write("ingrese su cantidad de bateria: ");
                val = Console.ReadLine();
                int bat = int.Parse(val);


                dron newdron = new dron(cod, bat);
                drones.Add(newdron);
                

            }

                      
        }

        public void listaFlotar()
        {
            for (int i = 0; i < drones.Count; i++)
            {
                Console.WriteLine($"dron n°{i+1}");
                Console.WriteLine($"codigo: {drones[i].Codigo()}");
                Console.WriteLine($"nivel de bateria: {drones[i].NivelBateria()}%");

            }
        }

        public void RemoverDronesBajos()
        {


            for (int i = 0; i < drones.Count; i++)
            {
                if (drones[i].NivelBateria() < 15)
                {
                    Console.WriteLine($"dron n°{i + 1}");
                    Console.WriteLine($"se elimino el dron codigo {drones[i].Codigo()}");
                    Console.WriteLine("se elimino por falta de bateria");
                    drones.RemoveAt(i);
                }
            }

        }

        public void MostrarDronesRestantes()
        {
            for (int i = 0; i < drones.Count; i++)
            {
                Console.WriteLine("-----lista actualizada-----");
                Console.WriteLine($"dron n°{i + 1}");
                Console.WriteLine($"codigo: {drones[i].Codigo()}");
                Console.WriteLine($"nivel de bateria: {drones[i].NivelBateria()}%");

            }
        }


        static void Main(string[] args)
        {
            centroControl centro = new centroControl();

            centro.listaFlotar();
            centro.RemoverDronesBajos();
            centro.MostrarDronesRestantes();
        }
    }
}
