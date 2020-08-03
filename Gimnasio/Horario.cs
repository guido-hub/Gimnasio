using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Horario
    {
        private int horas;
        private int minutos;
        public int Horas
        {
            get
            {
                return horas;
            }
            set
            {
                horas = value;
            }
        }
        public int Minutos
        {
            get
            {
                return minutos;
            }
            set
            {
                minutos = value;
            }
        }
        public Horario(int h, int m)
        {
            Horas = h;
            Minutos = m;
        }
        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}", Horas, Minutos);
        }
    }
}
