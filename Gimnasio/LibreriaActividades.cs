using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class LibreriaActividades
    {
        private LinkedList<Actividad> actividades;
        public LinkedList<Actividad> Actividades { get => actividades; set => actividades = value; }
        public LibreriaActividades()
        {
            Actividades = new LinkedList<Actividad>();
        }
        public void AgregarActividad(string nombre, Dia cuando)
        {
            Actividad deporte = new Actividad(nombre, cuando);
            Actividades.AddLast(deporte);
        }
        public bool ExisteActividad(string nom, Dia date)
        {
            foreach (Actividad A in actividades)
            {
                if (A.Nombre == nom && A.Dia.NombreDia == date.NombreDia && A.Dia.Hora.Horas == date.Hora.Horas && A.Dia.Hora.Minutos == date.Hora.Minutos)
                {
                    return true;
                }
            }
            return false;
        }
        public Actividad BuscarActividad(string nom, Dia date)
        {
            foreach (Actividad A in actividades)
            {
                if (A.Nombre == nom && A.Dia.NombreDia == date.NombreDia && A.Dia.Hora.Horas == date.Hora.Horas && A.Dia.Hora.Minutos == date.Hora.Minutos)
                {
                    return A;
                }
            }
            return null;
        }        
    }
}
