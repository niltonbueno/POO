using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    class operaciones
    {
        /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
            constructor, calcular su suma, resta, multiplicación y división, cada una en un
            método, imprimir dichos resultados.*/
        private int num1;
        private int num2;

        public operaciones () 
        {
            Console.Write("ingrese el num 1: ");
            string van = Console.ReadLine();
            num1 = int.Parse(van);

            Console.Write("ingrese el num 2: ");
            van = Console.ReadLine();
            num2 = int.Parse(van);
        }

        public void suma ()
        {
            int sum = 0;

            sum = num1 + num2;

            Console.WriteLine("el resultado es: " +  sum);
        }

        public void resta()
        {
            int res = 0;

            res = num1 - num2;
            Console.WriteLine("el resultado es: " + res);
        }

        public void multiplicacion()
        {
            int mul = 0;
            
            mul = num1 * num2;

            Console.WriteLine ("el resultado es: " + mul);
        }

        public void divicion()
        {
            int div = 0;
            div = num1 / num2;

            Console.WriteLine ("el resultado es: " + div);
        }

        static void Main(string[] args)
        {
            operaciones operaciones = new operaciones();
            operaciones.suma();
            operaciones.resta();
            operaciones.multiplicacion();
            operaciones.divicion();

            Console.ReadKey();

        }
    }
}
