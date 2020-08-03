using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Fecha
    {
        private int dia;
        private int mes;
        private int anio;
        public int Dia
        {
            get
            {
                return dia;
            }
            set
            {
                dia = (value <= 31 && value >= 1)? value : 0 ;
            }
        }
        public int Mes
        {
            get
            {
                return mes;
            }
            set
            {
                mes = (value <=12 && value >= 1) ? value : 0 ;
            }
        }
        public int Anio
        {
            get
            {
                return anio;
            }
            set
            {
                anio = (value >= 1900 && value <= DateTime.Today.Year ) ? value : 0 ;
            }
        }
        public Fecha(int d, int m, int a)
        {
            Dia = d;
            Mes = m;
            Anio = a;
        }
        public override string ToString()
        {
            return string.Format("{0:D2}/{1:D2}/{2:D2}", Dia, Mes, Anio);
        }
    }
}
