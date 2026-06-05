using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class producto
    {
        /*2. Plantear una clase Producto y otra clase Inventario.
            La clase Producto debe tener como atributos privados el nombre, precio y
            stock. Definir propiedades para acceder a estos atributos, asegurando que el
            stock no pueda ser negativo y el precio sea mayor a cero.
            La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
            método para mostrar todos los productos ordenados de menor a mayor en
            base al precio, además, mostrar el producto más caro y más barato del
            inventario.*/
        private string nombre;
        private float precio;
        private int stock;

        public string Nombre
        {
            set
            {
                nombre = value; 
            }

            get
            {
                return nombre;
            }
        }

        public float Precio
        {
            set {
                if (precio > 0)
                {
                    precio = value;
                } 
            }

            get { 
                return precio; 
            }
        }

        public int Stock
        {
            set
            {
                if (stock >= 0)
                {
                    stock = value;
                }
            }

            get
            {
                return stock;
            }
        }
    } 
    class inventario
    {
        private producto cliente1, cliente2, cliente3;
        
        public inventario()
        {
        cliente1 = new producto();    
        cliente2 = new producto();
        cliente3 = new producto();








        }
        static void Main(string[] args)
        {



        }
    }
}
