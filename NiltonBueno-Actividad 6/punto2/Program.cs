using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        public class cuadrado
        {
            private int lado, perimetro, superficie;
            private string valor;

            /*2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
                 métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/


            public void inicio()
            {
                Console.Write("agrega el valor de su lado: ");
                valor = Console.ReadLine();
                lado = int.Parse(valor);
            }
            public void perimetro1() 
            {
                perimetro = lado * 4;
                Console.Write("el perimetro es: ");
                Console.WriteLine(perimetro);
            }
            public void superficie1()
            {
                superficie = lado * lado;
                Console.Write("la superficie total es: ");
                Console.WriteLine(superficie);
            }
        }
        static void Main(string[] args)
        {
            cuadrado cuadra1 = new cuadrado();
            cuadra1.inicio();
            cuadra1.perimetro1();
            cuadra1.superficie1();
            
            Console.ReadKey();

        }
    }
}
