using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Empleado : Persona
    {
        private string usuario;
        private string clave;
        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }
        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }
        public Empleado(string nombre, string apellido, Fecha nacimiento, string user, string pass):base(nombre, apellido, nacimiento)
        {
            Usuario = user;
            Clave = pass;
        }
    }
}
