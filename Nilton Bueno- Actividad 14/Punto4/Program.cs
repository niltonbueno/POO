using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto4
{

    class Articulo
    {
        /*4. Inventario de Sucursales 
            Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
            Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
            Implementar en la clase Sucursal los siguientes métodos:
                Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
                Un método que busque y muestre el nombre del artículo más caro del local.
                Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
                */
        private string nombreArticulo;
        private double precio;
        private int stockActual;

        public Articulo()
        {
            Console.Write("ingrese un nombre: ");
            string val = Console.ReadLine();
            nombreArticulo = val;

            Console.Write("el precio del articulo: ");
            val = Console.ReadLine();
            precio = double.Parse(val);

            Console.Write("el precio el stock del articulo: ");
            val = Console.ReadLine();
            stockActual = int.Parse(val);
        }

        public string NombreArticulo()
        {
            return nombreArticulo;
        }
    
        public double Precio()
        {
            return precio;
        }

        public int StockActual()
        {
            return stockActual;
        }
    
    
    }
    class Sucursal  
    {
        private Articulo[] val;

        public Sucursal ()
        {
            val = new Articulo[3];
            for (int i = 0; i < val.Length; i++)
            {
                val[i] = new Articulo();
            }


        }


        public void todo ()
        {
            double valor = 0;
            string name = val[0].NombreArticulo();
            for (int i = 0; i < val.Length; i++)
            {
                valor = val[i].Precio() * val[i].StockActual();
                Console.WriteLine("el total del producto: " + val[i].NombreArticulo() + "es " + valor );
            }
        }

        public void busqueda()
        {
            double precio = val[0].Precio();
            string name = val[0].NombreArticulo();
            for (int i = 0; i < val.Length; i++)
            {

                if (val[i].Precio() > precio )
                {
                    precio = val[i].Precio();
                    name = val[i].NombreArticulo();
                }
            }
            Console.WriteLine("el que mayor tiene: " + name);
        }


        static void Main(string[] args)
        {
            Sucursal suc = new Sucursal();
            suc.todo();
            suc.busqueda();
        }
    }
}
