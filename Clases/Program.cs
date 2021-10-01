using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Prog_3
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //[STAThread]
        
        static private Sistema sistema = new Sistema();

        static void Main()
        {
            if (File.Exists("Sistema.bin"))
            {
                Stream flujoDeserealizar = File.OpenRead("Sistema.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                sistema = (Sistema) deserializer.Deserialize(flujoDeserealizar);
                flujoDeserealizar.Close();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ingresos());

            Stream flujoSerializar = File.Create("Sistema.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujoSerializar, sistema);
            flujoSerializar.Close();
        }

        static public Sistema getSistema ()
        {
            return sistema;
        }
    }
}
