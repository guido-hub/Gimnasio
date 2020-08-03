using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class LibreriaVisitas
    {        
        private LinkedList<Visita> detalleVisitas;
        private int id;
        private Fecha ultimaFechaDeUso;
        public LinkedList<Visita> DetalleVisitas { get => detalleVisitas; set => detalleVisitas = value; }
        public int Id { get => id; set => id = value; }
        public Fecha UltimaFechaDeUso { get => ultimaFechaDeUso; set => ultimaFechaDeUso = value; }

        public LibreriaVisitas()
        {
            DetalleVisitas = new LinkedList<Visita>();
            Id = 1;
            UltimaFechaDeUso = new Fecha(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
        }        
        public void TraspasoDeVisitas()
        {
            LinkedList<Visita> AUX = new LinkedList<Visita>();
            Fecha fechaActual = new Fecha(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);            
            foreach (Visita V in DetalleVisitas)
            {
                if (fechaActual.Anio != V.Fecha.Anio || fechaActual.Mes != V.Fecha.Mes || fechaActual.Dia != V.Fecha.Dia)
                {                    
                    AUX.AddFirst(V);
                }
            }
            foreach (Visita V in AUX)
            {
                Program.a.baseHistorial.AgregarRegistro(V);
                if (ExisteVisita(V.Numero, V.Fecha))
                {
                    DetalleVisitas.Remove(V);
                }
            }
        }
        public void AgregarVisita(Socio associate, Actividad deporte, Fecha fecha, Horario hour)
        {
            if ( UltimaFechaDeUso.Dia != fecha.Dia || UltimaFechaDeUso.Mes != fecha.Mes || UltimaFechaDeUso.Anio != fecha.Anio)
            {
                Id = 1;
                UltimaFechaDeUso = fecha;
            }            
            Visita nueva = new Visita(Id, associate, deporte, fecha, hour);
            DetalleVisitas.AddLast(nueva);
            Id++;
        }
        public bool ExisteVisita(int num, Fecha date)
        {
            foreach (Visita V in DetalleVisitas)
            {
                if (V.Numero == num && V.Fecha.Dia == date.Dia && V.Fecha.Mes == date.Mes && V.Fecha.Anio == date.Anio)
                {
                    return true;
                }
            }
            return false;
        }
        public Visita BuscarVisita(int num, Fecha date)
        {
            foreach(Visita V in DetalleVisitas)
            {
                if ( V.Numero == num && V.Fecha.Dia == date.Dia && V.Fecha.Mes == date.Mes && V.Fecha.Anio == date.Anio)
                {
                    return V;
                }
            }
            return null;
        }
        public void RestablecerId()
        {
            Id = 1;
            foreach(Visita V in DetalleVisitas)
            {
                V.Numero = Id;
                Id++;
            }
        }
    }
}
