using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    [Serializable]
    public class LibreriaUsuarios
    {
        private LinkedList<Empleado> usuarios;  
        public LinkedList<Empleado> Usuarios
        {
            get
            {
                return usuarios;
            }
            set
            {
                usuarios = value;
            }
        }    
        public LibreriaUsuarios()
        {
            Usuarios = new LinkedList<Empleado>();
        }
        public void AgregarUsuarioMasClave(string nom, string ape, Fecha nac, string usuario, string clave)
        {
            Empleado emp = new Empleado(nom, ape, nac, usuario, clave);
            Usuarios.AddLast(emp);            
        }        
        public bool ExisteUsuario(string nombre)
        {            
            foreach(Empleado E in Usuarios)
            {
                if ( E.Usuario == nombre )
                {
                    return true;
                }
            }            
            return false;
        }
        public bool ExisteClave(string dato)
        {
            foreach(Empleado E in Usuarios)
            {
                if ( E.Clave == dato )
                {
                    return true;
                }
            }
            return false;
        }
        public Empleado BuscarUsuario(string nombre)
        {
            foreach( Empleado E in Usuarios)
            {
                if ( E.Usuario == nombre )
                {
                    return E;
                }
            }
            return null;
        }
    }
}
