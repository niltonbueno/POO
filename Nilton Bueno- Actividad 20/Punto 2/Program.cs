using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    public class Paquete
    {
        /*Actividad 2: Administración de entregas logísticas
            Problema:
            Una empresa de envíos desea registrar sus entregas mediante colaboración de
            clases.
            Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
            Despachador que contenga una lista de paquetes y un método para registrar nuevos
            paquetes.
            Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
             Todos los paquetes registrados.
             Cuántos superan los 10 kg de peso.
             Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/

        private int codigo;
        private string destino;
        private float peso;
        
        public int Codigo
        {
            get { return codigo; }
        }

        public string Destino
        {
            get { return destino; }
        }

        public float Peso
        {
            get {return peso; }
        }

        public Paquete(int cod, string dest, float pes)
        {
            codigo = cod;
            destino = dest;
            peso = pes;
        }

        class despachador : Paquete
        {

            public despachador(int cod, string dest, float pes) : base(cod, dest, pes)
            {

            }

            static void Main(string[] args)
            {
                for (int i = 0; i < 5; i++)
                {
                    List<despachador> listaPaquetes = new List<despachador>();

                    Console.WriteLine("");
                    string cod = Console.ReadLine();

                    Console.WriteLine("");
                    string destino = Console.ReadLine();

                    Console.WriteLine("");
                    float peso = Console.ReadLine();
                }
                
            }
        }
    }
}
