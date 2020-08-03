using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    abstract public class Persona
    {
        private string nombre;
        private string apellido;
        private Fecha nacimiento;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public Fecha Nacimiento
        {
            get
            {
                return nacimiento;
            }
            set
            {
                nacimiento = value;
            }
        }
        public Persona(string nom, string ape, Fecha nacim)
        {
            Nombre = nom;
            Apellido = ape;
            Nacimiento = nacim;
        }
    }
}
