using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Archivo
    {
        public LibreriaUsuarios baseUsuarios;
        public LibreriaSocios baseSocios;
        public LibreriaActividades baseActividades;
        public LibreriaVisitas baseVisitas;
        public LibreriaHistorial baseHistorial;
        public Archivo()
        {
            baseUsuarios = new LibreriaUsuarios();
            baseSocios = new LibreriaSocios();
            baseActividades = new LibreriaActividades();
            baseVisitas = new LibreriaVisitas();
            baseHistorial = new LibreriaHistorial();
        }
    }
}
