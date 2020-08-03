using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Gimnasio
{    
    public class Control
    {
        public FrmIntro frmIntro;
        public FrmRegistro frmRegistro;
        public FrmDetalleUsuarios frmDetalleUsers;

        public FrmVisitas frmVisitas;
        public FrmDetalleSocios frmDetalleSocios;
        public FrmDetalleActividades frmDetalleActividades;
        public FrmRegistroSocio frmRegistroSocio;
        public FrmActividad frmActividad;

        public FrmRegistroActividad frmRegistroActividad;
        public FrmHistorialVisitas frmHistorialVisitas;
                
        public Control(FrmIntro intro)
        {
            frmIntro = intro;
            frmRegistro = new FrmRegistro();
            frmDetalleUsers = new FrmDetalleUsuarios();

            frmActividad = new FrmActividad();
            frmVisitas = new FrmVisitas();
            
            frmDetalleActividades = new FrmDetalleActividades();
            frmRegistroActividad = new FrmRegistroActividad();

            frmDetalleSocios = new FrmDetalleSocios();
            frmRegistroSocio = new FrmRegistroSocio();
                        
            frmHistorialVisitas = new FrmHistorialVisitas();       
        }
    }
}
