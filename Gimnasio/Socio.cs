using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class Socio : Persona
    {
        private string direccion;
        private int numero;        
        private int dni;
        private string partido;
        private string localidad;
        private Image foto;
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = (value < 0) ? 0 : value ;
            }
        }        
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = (value < 0) ? 0 : value;
            }
        }
        public string Partido
        {
            get
            {
                return partido;
            }
            set
            {
                partido = value;
            }
        }
        public string Localidad
        {
            get
            {
                return localidad;
            }
            set
            {
                localidad = value;
            }
        }
        public Image Foto { get => foto; set => foto = value; }
        public Socio( string nombre, string apellido, Fecha nac, string dir, int n, int doc, string par, string loc, Image retrato):base(nombre, apellido, nac)
        {
            Direccion = dir;
            Numero = n;            
            DNI = doc;
            Partido = par;
            Localidad = loc;
            foto = retrato;
        }
    }
}
