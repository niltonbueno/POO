using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class MonitoreoCostero
    {
        /*3-
            Un centro de conservación marina registra de forma dinámica las especies de
            mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
             Crear la clase MonitoreoCostero que contenga como atributo privado
            una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
             Métodos en MonitoreoCostero:
            1. CargarAvistamientos(): Solicitar por teclado nombres de
            especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
            &quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
            cuando el usuario ingresa la palabra &quot;FIN&quot;.
            2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
            organizada alfabéticamente de la A a la Z utilizando el método
            .Sort().
            3. MostrarReporteInvertido(): Imprimir la lista organizada de la
            Z a la A combinando .Sort() con el método .Reverse().
            4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
            animal y, utilizando los métodos de búsqueda de listas, informar si la
            especie fue divisada en la costa durante el día.*/

        List<string> especiesDetectadas = new List<string>();
        
        public void CargarAvistamiento()
        {
            while (true)
            {
                    string espes = " ";
                    Console.Write("ingrese el nombre de la especie: ");
                    espes = Console.ReadLine();
                    if (espes.Equals("fin"))
                {
                    break;                    
                }
                    else
                        {
                    especiesDetectadas.Add(espes);
                }
            }    
        }

        public void MostrarReporteOrdenado()
        {
            especiesDetectadas.Sort();

            for (int i = 0; i < especiesDetectadas.Count; i++)
            {
                Console.WriteLine($"las especies encontradas son: {especiesDetectadas[i]}");
            }
        }

        public void MostrarReporteInvertido()
        {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();
            Console.WriteLine("------orden inverso--------");
            for (int i = 0; i < especiesDetectadas.Count; i++)
            {
                
                Console.WriteLine($"las especies encontradas son: {especiesDetectadas[i]}");
            }
        }

        public void BuscarEspecie()
        {
            Console.Write("ingrese la especie que quiere buscar: ");
            string esp = Console.ReadLine();

            if (especiesDetectadas.Contains(esp))
                {
                    Console.Write("la especie a sido vista");
                } 
            else
                {
                    Console.Write("no se a visto la especie");
                }
                

        }

        static void Main(string[] args)
        {
            MonitoreoCostero mon = new MonitoreoCostero();
            mon.CargarAvistamiento();
            mon.MostrarReporteOrdenado();
            mon.MostrarReporteInvertido();
            mon.BuscarEspecie();

        }
    }
}
