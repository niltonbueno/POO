using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Program
    {
        public class empleado
        {
            private int sueldo;
            private string valor, name;

            /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
                 nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
                 sus datos y por último uno que imprima un mensaje si debe pagar impuestos
                 (si el sueldo supera a 3000).*/

            public void datos()
            {
                Console.Write("ingrese su nomber: ");
                name = Console.ReadLine();
                

                Console.Write("ingrese su sueldo: ");
                valor = Console.ReadLine();
                sueldo = int.Parse(valor);
            }

            public void imprimir() 
            {
                Console.Write(" su nombre es: ");
                Console.WriteLine(name);

                Console.Write(" su sueldo es: ");
                Console.WriteLine(sueldo);
            }
            public void impuestos ()
            {
                if (sueldo > 3000)
                {
                    Console.Write(" debe pagar impuestos");
                }




            }

        }
        static void Main(string[] args)
        {
            empleado datos1 = new empleado();
            datos1.datos();
            datos1.imprimir();
            datos1.impuestos();


            Console.ReadKey();




        }
    }
}
