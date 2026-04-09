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
            // 4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            // cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            // finalizar al ingresar un valor negativo en el número de cuenta.
            // Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            // informe:
            // a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
            // que:
            // Estado de la cuenta:
            // ○ “Acreedor” si el saldo es &gt; 0.
            // ○ “Deudor” si el saldo es &lt; 0.
            // ○ “Nulo” si el saldo es = 0.
            // b) La suma total de los saldos acreedores.



            int x;
            string valor, estado;
            float saldo, sumaAcreedores;
            sumaAcreedores = 0; 
            do
            {
                Console.Write("ingrese su numero de cuenta: ");
                valor = Console.ReadLine(); 
                x = int.Parse(valor);

                if (x >= 0)
                {
                    Console.Write("ingrese su saldo: ");
                    valor = Console.ReadLine();
                    saldo = float.Parse(valor);
                    if (saldo > 0)
                    {
                        estado = "acreedor";
                        sumaAcreedores = sumaAcreedores + saldo;
                        Console.Write("el estado es: ");
                        Console.WriteLine(estado);
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            estado = "deudor";
                            Console.Write("el estado es: ");
                            Console.WriteLine(estado);
                        }
                        else
                        {
                            estado = "nulo";
                            Console.Write("el estado es: ");
                            Console.WriteLine(estado);
                        }
                    }





                }

            }
            while (x >= 0);
            Console.Write("la suma total de los acreedores es: ");
            Console.WriteLine(sumaAcreedores);

            Console.ReadKey();
        }
    }
}
