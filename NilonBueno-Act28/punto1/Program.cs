using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        /*Consigna: Crear un formulario con tres TextBox para ingresar notas y un Button
                    &quot;Calcular&quot;. Convertir los valores con int.Parse() o double.Parse() y mostrar en una
                    Label el promedio. Si la nota es mayor o igual a 6, cambiar el color del texto de la
                    etiqueta a verde; de lo contrario, a rojo.*/
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
