using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PROG_3
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Sistema datosDelSistema = new Sistema();

            if (File.Exists("BaseDeDatos.bin"))
            {
                Stream lectura = File.OpenRead("BaseDeDatos.bin");
                BinaryFormatter deserializador = new BinaryFormatter();
                datosDelSistema = (Sistema)deserializador.Deserialize(lectura);
                lectura.Close();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ingreso(datosDelSistema));

            Stream escritura = File.Create("BaseDeDatos.bin");
            BinaryFormatter serializador = new BinaryFormatter();
            serializador.Serialize(escritura, datosDelSistema);
            escritura.Close();

        }
    }
}
