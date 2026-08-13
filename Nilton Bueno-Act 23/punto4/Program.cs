using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    class DispositivoInteligente
    { /*4-
            Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
            vinculados a una red hogareña.
             Crear la clase DispositivoInteligente que contenga como atributos
            privados: nombreDispositivo (string) y consumoWatts (double). Definir
            sus propiedades y un constructor que reciba nom y watts.
             Crear la clase colaboradora PanelDomotico que administre un objeto
            List&lt;DispositivoInteligente&gt;.
             Métodos en PanelDomotico:
                1. Un constructor que permita al usuario cargar dinámicamente
                dispositivos por teclado. El sistema preguntará después de cada
                carga si se desea agregar otro dispositivo.
                2. MostrarDispositivos(): Listar todos los dispositivos
                configurados junto a sus consumos.
                3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
                Watts totales que consume la casa sumando los valores de la lista.
                4. DesconectarDispositivo(): Solicitar al usuario el nombre de
                un dispositivo y, si existe en la lista, removerlo de forma dinámica
                para simular su apagado remoto.*/
        private string nombreDispositivo;
        private double consumoWatts;

        public DispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }

        public string NombreDispositivo()
        {
            return nombreDispositivo;
        }

        public double ConsumoWatts()
        {
            return consumoWatts;
        }

    }
    class PanelDomotico
    {
        List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>();

        public PanelDomotico()
        {
            string res = "";
            do
            {
                
                Console.Write("ingrese el nombre del dispositivo: ");
                string dis = Console.ReadLine();
                string nom = dis;


                Console.Write("ingrese su consumo de watts: ");
                dis = Console.ReadLine();
                double watts = double.Parse(dis);

                DispositivoInteligente newdispositivo = new DispositivoInteligente(nom,watts);
                dispositivos.Add(newdispositivo);

                Console.Write("quiere continuar (escribir si o no): ");
                res = Console.ReadLine();
            }
            while (res.Equals("si"));
        }

        public void MostrarDispositivos()
        {
            for (int i = 0; i < dispositivos.Count; i++)
            {
                Console.WriteLine($"dispotivo N° {i+1}");
                Console.WriteLine();
                Console.WriteLine($"nombre del dispositivo: {dispositivos[i].NombreDispositivo()} ");
                Console.WriteLine($"watts del dispositivo: {dispositivos[i].ConsumoWatts()} ");
                Console.WriteLine();
            }
        }

        public void CalcularConsumoTotal()
        {
            double total = 0;
            for (int i = 0; i < dispositivos.Count; i++)
            {
                
                total = total + dispositivos[i].ConsumoWatts();
            }
            Console.WriteLine($"{total} consumo total");
        }

        public void DesconectarDispositivo()
        {
            Console.WriteLine("ingrese el dispositivo que quiera apagar: ");
            string val = Console.ReadLine();

            string res = "si";
            for (int i = 0; i < dispositivos.Count; i++)
            {
                if (dispositivos[i].NombreDispositivo().Equals(val))
                {
                    dispositivos.RemoveAt(i);
                    res = "si";
                }
               
                else
            {
                res = "no";
            }

        }

            if (res.Equals("si"))
            {
                Console.Write("el dispositivo fue desconectado");
            }
            else
            {
                Console.Write("el no fue encontrado");

            }
        }

        static void Main(string[] args)
        { 
            PanelDomotico pal = new PanelDomotico();
            pal.MostrarDispositivos();
            pal.CalcularConsumoTotal();
            pal.DesconectarDispositivo();

            Console.ReadKey();
        }
    }
}
