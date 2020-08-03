using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Dia
    {
        private string nombreDia;
        private Horario hora;
        public string NombreDia { get => nombreDia; set => nombreDia = value; }
        public Horario Hora { get => hora; set => hora = value; }
        public Dia(string nom, Horario h)
        {            
            NombreDia = nom;
            Hora = h;
        }
    }
}
