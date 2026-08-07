using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Documento
    {
        /*1-
                En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
                llegada.
                 Crear la clase Documento que contenga como atributos privados:
                nombreArchivo (string) y cantidadPaginas (int). Definir sus
                propiedades de solo lectura y un constructor que reciba los parámetros nom
                y pag.
                 Crear la clase ServidorImpresion que administre una lista dinámica de
                documentos (List&lt;Documento&gt;).
                 Métodos en ServidorImpresion:
                    1. AgregarDocumento(): Solicitar por teclado los datos de un
                    documento y agregarlo al final de la lista utilizando .Add().
                    2. ImprimirSiguiente(): Si la lista no está vacía, simular la
                    impresión del primer documento de la lista (mostrar sus datos en
                    consola) y removerlo de la colección mediante .RemoveAt(0). Si está
                    vacía, advertir que no hay trabajos pendientes.
                    3. MostrarColaPendiente(): Listar todos los documentos que
                    están esperando ser impresos y la cantidad total de páginas
                    acumuladas en la cola de espera utilizando .Count.*/

        private string nombreArchivo;
        private int cantidadPaginas;

        public Documento(string nom, int pag) 
        { 
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }

        public string NombreArchivo()
        {
            return nombreArchivo;
        }

        public int CantidadPaginas() 
        { 
        return cantidadPaginas;
        }

    }
    class ServidorImpresion
    {
        public ServidorImpresion(string nom, int pag) 
        { 
            
        }
        public ServidorImpresion() { }
        List<Documento> documentos = new List<Documento>();

        public void AgregarDocumento() {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ingrese el nombre del archivo: ");
                string val = Console.ReadLine();
                string nom = val;


                Console.Write("ingrese la cantidad de paginas del archivo: ");
                val = Console.ReadLine();
                int pag = int.Parse(val);

                Documento nuevoDocumento = new Documento(nom, pag);
                documentos.Add(nuevoDocumento);
            }
        string NM = documentos[0].NombreArchivo();
        int nu = documentos[0].CantidadPaginas();

        }
    public void ImprimirSiguiente()
        {
            if (documentos.Count < 0)
            {
                Console.Write("no hay trabajos pendientes");
            }
            else
            {
                /*foreach (Documento n in documentos)
                {
                    Console.WriteLine("el nombre del documento: " + n.NombreArchivo());
                    Console.WriteLine("el numero de paginas del documento: " + n.CantidadPaginas());
                   
                }
                documentos.RemoveAt(0);*/

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("el nombre del documento: " + documentos[i].NombreArchivo());
                    Console.WriteLine("el numero de paginas del documento: " + documentos[i].CantidadPaginas());

                    documentos.RemoveAt(0);
                }
            }
        }

        public void MostrarColaPendiente()
        {
            Console.WriteLine("------------------------------------------------------------");
            for (int i = 0; i < documentos.Count; i++)
            {
                Console.WriteLine("el nombre del documento: " + documentos[i].NombreArchivo());
                int max = 0;
                max = max + documentos[i].CantidadPaginas();
                Console.WriteLine("el numero de paginas del documento: " + documentos[i].CantidadPaginas());
            }


        }


        /*foreach (Documento n in documentos)
         {
             Console.WriteLine("el nombre del documento: " + n.NombreArchivo());
         }*/


        static void Main(string[] args)
        {
            ServidorImpresion newserver = new ServidorImpresion();
            newserver.AgregarDocumento();
            newserver.ImprimirSiguiente();
            newserver.MostrarColaPendiente();
            Console.ReadKey();
        }
    }
}
