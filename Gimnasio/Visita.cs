using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Visita
    {
        private int numero;
        private Socio socio;
        private Actividad actividad;
        private Fecha fecha;
        private Horario horario;
        public int Numero { get => numero; set => numero = value; }
        public Socio Socio { get => socio; set => socio = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
        public Fecha Fecha { get => fecha; set => fecha = value; }
        public Horario Horario { get => horario; set => horario = value; }
        public Visita(int num, Socio soc, Actividad act, Fecha fec, Horario hor)
        {
            Numero = num;
            Socio = soc;
            Actividad = act;
            Fecha = fec;
            Horario = hor;
        }
    }
}
