using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class ElementoPantalla
    {
        /*Actividad 2: Posicionamiento de elementos en consola
            Problema:
            Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
            ● Implementar propiedades y un constructor que cargue valores.
            ● Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
            nombre en pantalla y Console.CursorVisible para ocultar el cursor.
            ● Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
            consola.*/
        private string nombre;
        private int posX;
        private int posY;

        public ElementoPantalla()
        {
            
                Console.Write("ingrese un nombre de la clase: ");
                string val = Console.ReadLine();
                this.nombre = val;

                Console.Write("ingrese la posicion X: ");
                val = Console.ReadLine();
                this.posX = int.Parse(val);

                Console.Write("ingrese la posicion Y: ");
                val = Console.ReadLine();
                this.posY = int.Parse(val);   
        }
        
        public ElementoPantalla(string Nombre, int PosX, int PosY)
        {
            this.nombre = Nombre;
            this.posX = PosX;
            this.posY = PosY;
        }

        public string Nombre
        {
            get {return nombre;}
        }

        public void mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(this.posX , this.posY);
            Console.WriteLine(nombre);
        }
        static void Main(string[] args)
        {   
            ElementoPantalla[] elemento = new ElementoPantalla[4];
            
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"||Ingrese el elemento n° {i + 1} ||");
                elemento[i] = new ElementoPantalla();
            }

            foreach (ElementoPantalla E in elemento)
            {
                E.mostrar();
            }

            Console.ReadKey();
        }
    }
}


