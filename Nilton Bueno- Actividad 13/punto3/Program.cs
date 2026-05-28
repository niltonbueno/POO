using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class socio
    {
        /*3. Plantear una clase Club y otra clase Socio.
            La clase Socio debe tener los siguientes atributos privados: nombre y la
            antigüedad en el club (en años). En el constructor pedir la carga del nombre y
            su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
            Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
            antigüedad en el club.*/
        private string nombre;
        private int años;

        public socio ()
        {
          
                Console.Write("ingrese el nombre: ");
                string van = Console.ReadLine();
                nombre = van;

                Console.Write("ingrese los años: ");
                van = Console.ReadLine();
                años = int.Parse(van);
            
        }

        class club
        {
            private socio socio1, socio2, socio3 ; 
            
            public club ()
            {
                socio1 = new socio ();
                socio2 = new socio ();
                socio3 = new socio ();
            }

            public void mayor ()
            {
                
                if (socio1.años > socio2.años && socio1.años > socio3.años )
                {

                    Console.Write("el socio 1 tiene mayor antiguedad");    

                } else if (socio2.años > socio1.años && socio2.años > socio3.años)
                {
                    Console.Write("el socio 2 tiene mayor antiguedad");
                }
                else
                {
                    Console.Write("el socio 3 tiene mayor antiguedad");
                }



            }

        }

        static void Main(string[] args)
        {
            club club = new club ();
            club.mayor ();

            Console.ReadKey();

        }
    }
}
