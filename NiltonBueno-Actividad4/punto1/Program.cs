using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            $500, realizar un programa que lea los sueldos que cobra cada empleado e
            informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            de $300.Además el programa deberá informar el importe que gasta la empresa
            en sueldos al personal.*/

            int X, N, sueldo, cant_men, cant_mas, total;
            X = 0;
            total = 0;
            sueldo = 0;
            cant_men = 0;
            cant_mas = 0;    
            string numero;

            Console.Write("cantidad de trabajadores: ");
            numero = Console.ReadLine();    
            N = int.Parse(numero);
            
            while (X < N )
            {
                Console.Write("sueldo de los trabajadores: ");
                numero = Console.ReadLine();
                sueldo = int.Parse(numero);
               
                if (sueldo >= 100 && sueldo <=300)
                {
                    cant_men++;
                   
                

                }
                else
                {
                    if (sueldo > 300)
                    {
                       
                        cant_mas++;
                        
                    }
                }
                X ++;
                total += sueldo;
            }

            Console.Write("la cantidad de trabajadores que cobran entre 100 y 300 es: ");
            Console.WriteLine(cant_men);

            Console.Write("la cantidad de trabajadores que cobran mas 300 es: ");
            Console.WriteLine(cant_mas);

            Console.Write("la cantidad total gastado es: ");
            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
