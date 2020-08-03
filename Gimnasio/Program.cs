using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace Gimnasio
{    
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>              
        public static Control s;        
        public static string NombreBase = "BaseGimnasio.bin";
        public static Archivo a;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);                        
            if (File.Exists(NombreBase))
            {
                a = LecturaBaseDatos();          
            }
            else 
            {
                a = CreacionBaseDatos();
            }
            Application.Run(new FrmIntro(ref s));
        }

        public static Archivo CreacionBaseDatos()
        {            
            return new Archivo();
        }
        public static Archivo LecturaBaseDatos()
        {
            Stream flujo1 = File.OpenRead(NombreBase);
            BinaryFormatter deserializador = new BinaryFormatter();
            Archivo sistem = (Archivo)deserializador.Deserialize(flujo1);
            flujo1.Close();
            return sistem;
        }
        public static void GuardarBaseDatos()
        {
            Stream flujo = File.Create(NombreBase);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo, a);
            flujo.Close();
        }
    }
}
