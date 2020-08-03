using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{    
    public partial class FrmIntro : Form
    {
        private int conteoErrores;
        public FrmIntro(ref Control sis)
        {            
            sis = new Control(this);
            InitializeComponent();
            conteoErrores = 0;
        }
        public void BlanqueoForm()
        {
            inpUsuario.Text = "";
            inpContrasenia.Text = "";
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Program.s.frmRegistro.Show();
            BlanqueoForm();
            inpUsuario.Focus();
            this.Hide();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!Program.a.baseUsuarios.ExisteUsuario(inpUsuario.Text))
            {
                MessageBox.Show("Usuario inexistente!","Error");
                inpUsuario.Focus();
                return;
            }
            else
            {                
                if (!Program.a.baseUsuarios.ExisteClave(inpContrasenia.Text))
                {
                    if(conteoErrores == 3)
                    {
                        MessageBox.Show("Se ha denegado el acceso a su cuenta", "Advertencia");
                        conteoErrores = 0;
                        BlanqueoForm();
                        inpUsuario.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente! Intente otra vez", "Error");
                        conteoErrores++;
                        return;
                    }                    
                }
                else
                {
                    conteoErrores = 0;
                    BlanqueoForm();
                    Program.s.frmVisitas.Show();
                    this.Hide();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
