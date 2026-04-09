using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.*/

            DateTime fecha;
            string numero;

            Console.Write("ingrese su fecha actual usando '/' o '-' ej: dd/mm/aaaa: ");
            numero = Console.ReadLine();
            fecha = DateTime.Parse(numero);

            if (fecha.Day == 25 && fecha.Month == 12)
            {
                Console.Write("es navidad");
            }
            else
            {
                Console.Write("no es navidad");
            }


            Console.ReadKey();



        }
    }
}
