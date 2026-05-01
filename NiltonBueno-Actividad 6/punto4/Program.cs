using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class operaciones
    {
       
            private int num1, num2, suma, resta, multiplicacion, division;
            private string valores;

            /*4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
                 calcular su suma, resta, multiplicación y división, cada una en un método,
                 imprimir dichos resultados.*/


            public void cargar()
            {
                Console.Write("ingrese el numero1: ");
                valores = Console.ReadLine();
                num1 = int.Parse(valores);

                Console.Write("ingrese el numero2: ");
                valores = Console.ReadLine();
                num2 = int.Parse(valores);
            }
            public void suma1()
            {
                suma = num1 + num2;
                Console.Write("la suma es: ");
                Console.WriteLine(suma);
            }
            public void resta1()
            {
                resta = num1 - num2;
                Console.Write("la resta es: ");
                Console.WriteLine(resta);
            }
            public void multiplicacion1() 
            { 
                multiplicacion = num1 * num2;
                Console.Write("la multiplicacion es: ");
                Console.WriteLine(multiplicacion);
            }
            public void division1() 
            { 
                division = num1 / num2;
                Console.Write("la divicion es: ");
                Console.WriteLine(division);
            }
            public void imprimir() 
            {
                Console.Write("la suma es: ");
                Console.WriteLine(suma);

                Console.Write("la resta es: ");
                Console.WriteLine(resta);

                Console.Write("la multiplicacion es: ");
                Console.WriteLine(multiplicacion);

                Console.Write("la divicion es: ");
                Console.WriteLine(division);
            }
        
        

        static void Main(string[] args)
        {
            operaciones operaciones1 = new operaciones();
            operaciones1.cargar();
            operaciones1.suma1();
            operaciones1.resta1();
            operaciones1.division1();
            operaciones1.multiplicacion1();

            Console.ReadKey();



        }
    }
}
