using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Actividad
    {
        private string nombre;
        private Dia dia;
        public string Nombre { get => nombre; set => nombre = value; }
        internal Dia Dia { get => dia; set => dia = value; }
        public Actividad(string nom, Dia d )
        {
            Nombre = nom;
            Dia = d;
        }
    }
}
