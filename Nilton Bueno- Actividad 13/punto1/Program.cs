using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class empleado
    {
        /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
            nombre y su sueldo. En el constructor cargar los atributos y luego en otro
            método imprimir sus datos y por último uno que imprima un mensaje si debe
            pagar impuestos (si el sueldo supera a 3000)*/
        private int sueldo;
        private string nombre;

        public empleado()
        {
            Console.Write("ingrese el nombre: ");
            string van = Console.ReadLine();
            nombre = van;

            Console.Write("ingrese el sueldo: ");
            van = Console.ReadLine();
            sueldo = int.Parse(van);
        }

        public void imprimir ()
        {
            Console.WriteLine("el nombre es: " + nombre);
            Console.WriteLine("su sueldo es de: " + sueldo);

        }


        public void comparacion() 
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("debe pagar impuestos a la ganancia");    
            }

        }

        static void Main(string[] args)
        { 
            empleado empleado = new empleado();
            empleado.imprimir();
            empleado.comparacion();

            Console.ReadKey();

        }
    }
}
