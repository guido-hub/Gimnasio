using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class LibreriaHistorial
    {
        private LinkedList<Visita> historialVisitas;
        public LinkedList<Visita> HistorialVisitas { get => historialVisitas; set => historialVisitas = value; }
        public LibreriaHistorial()
        {
            HistorialVisitas = new LinkedList<Visita>();            
        }        
        public void BorradoHistorico()
        {
            int mesFecha = DateTime.Today.Month;
            int anioFecha = DateTime.Today.Year;
            LinkedList<Visita> AUX = new LinkedList<Visita>();            
            foreach (Visita V in HistorialVisitas)
            {
                if (anioFecha != V.Fecha.Anio || mesFecha - V.Fecha.Mes > 0)
                {
                    AUX.AddLast(V);
                }
            }
            foreach (Visita V in AUX)
            {
                if (ExisteRegistro(V.Numero, V.Fecha))
                {
                    HistorialVisitas.Remove(BuscarRegistro(V.Numero, V.Fecha));
                }
            }
        }
        public void AgregarRegistro(Visita visit)
        {
            HistorialVisitas.AddFirst(visit);
        }
        public bool ExisteRegistro(int num, Fecha fec)
        {
            foreach (Visita V in HistorialVisitas)
            {
                if (V.Numero == num && V.Fecha.Dia == fec.Dia && V.Fecha.Mes == fec.Mes && V.Fecha.Anio == fec.Anio)
                {
                    return true;
                }
            }
            return false;
        }
        public Visita BuscarRegistro(int num, Fecha fec)
        {
            foreach( Visita V in HistorialVisitas)
            {
                if ( V.Numero == num && V.Fecha.Dia == fec.Dia && V.Fecha.Mes == fec.Mes && V.Fecha.Anio == fec.Anio)
                {
                    return V;
                }
            }
            return null;
        }
        public void RestablecerId(Fecha fecha)
        {
            int id = 1;
            foreach( Visita V in HistorialVisitas )
            {
                if ( V.Fecha.Dia == fecha.Dia && V.Fecha.Mes == fecha.Mes && V.Fecha.Anio == fecha.Anio)
                {
                    V.Numero = id;
                    id++;
                }
            }
        }
    }
}
