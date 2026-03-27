using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*4.Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno(tres promedios)
            b) Imprimir dichos promedios(promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor.*/

            int n, x,y, valor_mañana, valor_Tarde, valor_noche, pro_mañana, pro_tarde, pro_noche;
            valor_mañana = 0;
            valor_noche = 0;
            valor_Tarde = 0;
            pro_mañana= 0;
            pro_noche = 0;
            pro_tarde = 0;
            string numero;

            for (int i = 0; i < 20; i++)
            {

                Console.Write("ingrese la edad del estudiante del turno mañana: ");
                numero = Console.ReadLine();
                n = int.Parse(numero);

                valor_mañana = valor_mañana + n;
                pro_mañana = valor_mañana / 20;
                
            }

            for (int i = 0; i < 30; i++)
            {

                Console.Write("ingrese la edad del estudiante del turno tarde: ");
                numero = Console.ReadLine();
                y = int.Parse(numero);

               valor_Tarde = valor_Tarde + y;
                pro_tarde = valor_Tarde / 30; 
            }

            for (int i = 0; i < 15; i++)
            {

                Console.Write("ingrese la edad del estudiante del turno noche: ");
                numero = Console.ReadLine();
                x = int.Parse(numero);

                valor_noche = valor_noche + x;
                pro_noche = valor_noche / 15;
            }

          




            Console.Write("el promedio del turno mañana es: ");
            Console.WriteLine(pro_mañana);

            Console.Write("el promedio del turno tarde es: ");
            Console.WriteLine(pro_tarde);

            Console.Write("el promedio del turno noche es: ");
            Console.WriteLine(pro_noche);

            if (pro_mañana < pro_tarde && pro_mañana < pro_noche)
            {
                Console.Write("el turno mañana tiene menor promedio");
            }
            else
            {
                if (pro_tarde < pro_mañana && pro_tarde < pro_noche)
                {
                    Console.Write("el turno tarde tiene menor promedio");
                }
                else
                {
                    Console.Write("el turno noche tiene menor promedio");
                }
            }
        
            Console.ReadKey();


        }
    }
}
