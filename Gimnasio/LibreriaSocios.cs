using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gimnasio
{
    [Serializable]
    public class LibreriaSocios
    {
        private LinkedList<Socio> socios;        
        public LinkedList<Socio> Socios
        {
            get
            {
                return socios;
            }
            set
            {
                socios = value;
            }
        }        
        public LibreriaSocios()
        {
            Socios = new LinkedList<Socio>();            
        }
        public void AgregarSocioMasDni(string nom, string ape, Fecha nac, string dir, int num, int doc, string par, string loc, Image img)
        {
            Socio socio = new Socio(nom, ape, nac, dir, num, doc, par, loc, img);
            Socios.AddLast(socio);                       
        }
        public bool ExisteDni(int doc)
        {
            foreach(Socio S in Socios)
            {
                if(S.DNI == doc)
                {
                    return true;
                }
            }
            return false;
        }
        public Socio BuscarDni(int doc)
        {
            foreach(Socio S in Socios)
            {
                if(S.DNI == doc)
                {
                    return S;
                }
            }
            return null;
        }
    }
}
