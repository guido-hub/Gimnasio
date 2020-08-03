using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{    
    public partial class FrmRegistro : Form
    {                
        private bool usoCalendario;
        private bool usuarioApropiado;
        private bool claveApropiada;
        private bool edadApropiada;              
        public FrmRegistro()
        {                   
            InitializeComponent();                                  
            usoCalendario = false;
            usuarioApropiado = false;
            claveApropiada = false;
            edadApropiada = false;            
        }        
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (!EstanCompletosLosCamposDelForm())
            {
                MessageBox.Show("Todos los campos tienen que ser completados", "Faltante");
                return;
            }
            if (!usoCalendario)
            {
                MessageBox.Show("Aún no ingresó su fecha de nacimiento en el calendario", "Faltante");
                return;
            }
            if (!edadApropiada)
            {
                MessageBox.Show("Debe elegir una fecha de nacimiento válida", "Dato erróneo");
                return;
            }
            if (!usuarioApropiado)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario válido", "Dato erróneo");
                return;
            }
            if (!claveApropiada)
            {
                MessageBox.Show("Debe ingresar una contraseña válida", "Dato erróneo");
                return;
            }
            if ( MessageBox.Show("Está seguro que los datos ingresados son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes)
            {
                CrearUsuario();
                BlanquearForm();
                inpNombre.Focus();
                if (MessageBox.Show("Desea continuar con la carga de usuarios?", "Carga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {                    
                    this.Hide();                    
                    Program.s.frmIntro.Show();
                }                
            }
            else
            {
                MessageBox.Show("Puede modificar los datos", "Corrección");
                inpNombre.Focus();
                return;
            }                              
        }
        private void BlanquearForm()
        {
            inpNombre.Text = "";
            inpApellido.Text = "";
            inpUsuario.Text = "";
            inpContrasenia1.Text = "";
            inpContrasenia2.Text = "";
            usoCalendario = false;
        }
        private void CrearUsuario()
        {
            string a = inpNombre.Text;
            string b = inpApellido.Text;
            string c = inpUsuario.Text;
            string d = inpContrasenia1.Text;
            int dia = dateTimePicker1.Value.Day;
            int mes = dateTimePicker1.Value.Month;
            int anio = dateTimePicker1.Value.Year;
            Fecha fec = new Fecha(dia, mes, anio);
            Program.a.baseUsuarios.AgregarUsuarioMasClave(a, b, fec, c, d);            
            Program.s.frmDetalleUsers.RefrescarGrid();
            Program.GuardarBaseDatos();
            MessageBox.Show("La creación del usuario se ha realizado con éxito!", "Nuevo usuario");
        }
        private bool EstanCompletosLosCamposDelForm()
        {
            string a = inpNombre.Text;
            string b = inpApellido.Text;
            string c = inpUsuario.Text;            
            return (a == "" || b == "" || c == "" ) ? false : true ;            
        }
        private void HayEdadValida()
        {
            int anioActual = Convert.ToInt32(DateTime.Today.Year);
            int anioElegido = dateTimePicker1.Value.Year;
            if (anioActual - anioElegido < 21) 
            {
                MessageBox.Show("Debe elegir una fecha de nacimiento válida", "Dato erróneo");
                edadApropiada = false;
            } 
            else 
            {
                edadApropiada = true;
                if (anioActual - anioElegido > 99)
                {
                    if (MessageBox.Show("Está seguro que esa es su edad?", "Longevo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        MessageBox.Show("Ok, será tenido en cuenta", "Persona de riesgo");
                        edadApropiada = true;
                    }
                    else
                    {
                        MessageBox.Show("Ok, puede modificarlo", "Error");
                        edadApropiada = false;
                    }
                }                
            }            
        }        
        private void HayUsuarioValido()
        {
            string a = inpUsuario.Text;
            if (a == "")
            {
                EtqUsuario.Visible = false;
                usuarioApropiado = false;
            }
            else
            {
                EtqUsuario.Visible = true;
                if (!Program.a.baseUsuarios.ExisteUsuario(a))
                {
                    EtqUsuario.Text = "Usuario apropiado!";
                    usuarioApropiado = true;
                }
                else
                {
                    EtqUsuario.Text = "Usuario ya existe!";
                    usuarioApropiado = false;
                }
            }
        }
        private void HayClaveValida()
        {
            string a = inpContrasenia1.Text;
            string b = inpContrasenia2.Text;
            if ( a == "" || b == "")
            {                
                claveApropiada = false;
                EtqClave.Visible = false;
            }
            else
            {
                EtqClave.Visible = true;
                if (a == b)
                {
                    if (a.Length > 7)
                    {
                        if (!Program.a.baseUsuarios.ExisteClave(a))
                        {
                            EtqClave.Text = "Clave apropiada!";
                            claveApropiada = true;
                        }
                        else
                        {
                            EtqClave.Text = "Clave ya utilizada!";
                            claveApropiada = false;
                        }
                    }
                    else
                    {
                        EtqClave.Text = "Mas de 7 caracteres!";
                        claveApropiada = false;
                    }
                }
                else
                {
                    EtqClave.Text = "Claves tienen que ser iguales!";
                    claveApropiada = false;
                }
            }                     
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.s.frmIntro.Show();
            BlanquearForm();
            inpNombre.Focus();
            this.Hide();
        }
        private void inpContrasenia2_TextChanged(object sender, EventArgs e)
        {
            HayClaveValida();
        }        
        private void btnBaseUsuarios_Click(object sender, EventArgs e)
        {
            BlanquearForm();
            inpNombre.Focus();
            Program.s.frmDetalleUsers.Show();            
        }
        private void inpContrasenia1_TextChanged(object sender, EventArgs e)
        {
            HayClaveValida();
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            usoCalendario = true;
        }
        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            HayEdadValida();
        }
        private void inpUsuario_TextChanged(object sender, EventArgs e)
        {
            HayUsuarioValido();
        }
    }
}
