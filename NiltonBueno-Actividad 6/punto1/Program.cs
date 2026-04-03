using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        public class plano
        {
            private int y, x;
            private string number;

            /*1.    Desarrollar una clase que represente un punto en el plano y tenga los
                    siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
                    encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
                    positivas, si x< 0 e y >0 segundo cuadrante, etc.)*/


            public void valores()
            {
                Console.Write("ingrese x: ");
                number = Console.ReadLine();
                x = int.Parse(number);
                Console.Write("ingrese y: ");
                number = Console.ReadLine();
                y = int.Parse(number);
            }
            public void punto()
            {
                if (x > 0 && y > 0)
                {
                    Console.Write("estas en el primer cuadrante");
                }
                else
                {
                    if (x < 0 && y > 0)
                    {
                        Console.Write("estas en el segundo cuadrante");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            plano volor1 = new plano();
            volor1.valores();
            volor1.punto();

            Console.ReadKey();


        }
    }
}
