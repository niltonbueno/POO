using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Persona
    {
        /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
            edad (definir las propiedades para poder acceder a dichos atributos). Definir
            un método para imprimirlos. Plantear una segunda clase Empleado que
            herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
            método para imprimir su sueldo. Definir un objeto de la clase Persona y
            llamar a sus métodos y propiedades. También crear un objeto de la clase
            Empleado y llamar a sus métodos y propiedades.*/
        private int edad;
        private string nombre;
        
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }


        public int Edad
        {
            set {
                edad = value;
            }
            get {  
                return edad;
            }
        }

        public void impr ()
        {
            Console.WriteLine("nombre: " + nombre + " edad: " + edad);

        }
    }

    class Empleado : Persona
    {
        private float sueldo;
        

        public void imp ()
        {
            Console.WriteLine("a: " + sueldo);

        }








        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Edad=20;
            persona.Nombre = "lom";
            persona.impr();
            
            Empleado emp = new Empleado();
            emp.Nombre = "la";
            emp.Edad = 52;
            emp.sueldo = 14000;
            emp.impr();

        }
    }
}
