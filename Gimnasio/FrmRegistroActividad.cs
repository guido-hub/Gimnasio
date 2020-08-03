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
    public partial class FrmRegistroActividad : Form
    {        
        public FrmRegistroActividad()
        {
            InitializeComponent();           
        }
        public bool EstanLosCamposCompletos()
        {
            string a = inpNombre.Text;
            string b = cmbDia.Text;
            string c = cmbHora.Text;
            string d = cmbMinuto.Text;
            return ( a == "" || b == "" || c == "" || d == "" ) ? false : true;
        }
        private void BlanqueoCampos()
        {
            inpNombre.Text = null;
            cmbDia.Text = "";
            cmbHora.Text = "";
            cmbMinuto.Text = "";            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( !EstanLosCamposCompletos())
            {
                MessageBox.Show("Falta completar campos", "Faltante");
                return;
            }
            if ( ExisteLaActividad() )
            {
                MessageBox.Show("Actividad ya existente!", "Error");
                return;
            }            
            if ( MessageBox.Show("Esta seguro que los datos ingresados son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CrearActividad();
                BlanqueoCampos();
                inpNombre.Focus();
                if (MessageBox.Show("Desea continuar con la carga de actividades?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Program.s.frmDetalleActividades.Show();
                    this.Hide();
                    
                }               
            }
            else
            {
                MessageBox.Show("Puede corregir datos", "Corrección");
                inpNombre.Focus();
            }
        }
        private void CrearActividad()
        {
            string a = inpNombre.Text;
            string b = cmbDia.Text;
            int hora = Convert.ToInt32( cmbHora.Text );
            int min = Convert.ToInt32( cmbMinuto.Text );
            Horario hour = new Horario(hora, min);
            Dia day = new Dia(b, hour);            
            Program.a.baseActividades.AgregarActividad(a, day);
            Program.s.frmDetalleActividades.RefrescarGrid();
            Program.s.frmActividad.RefrescarGridActividades();
            Program.GuardarBaseDatos();
            MessageBox.Show("La actividad se ha creado con éxito!","Nueva actividad");
        }
        private bool ExisteLaActividad()
        {
            string a = inpNombre.Text;
            string b = cmbDia.Text;
            int c = Convert.ToInt32( cmbHora.Text );
            int d = Convert.ToInt32( cmbMinuto.Text );
            Horario horario = new Horario(c, d);
            Dia day = new Dia(b, horario);
            return Program.a.baseActividades.ExisteActividad( a , day );
        }
        private void ComprobacionDeDatos()
        {
            if (EstanLosCamposCompletos())
            {
                if (ExisteLaActividad())
                {
                    MessageBox.Show("Existe la actividad!");
                }
            }
        }
        private void inpNombre_TextChanged(object sender, EventArgs e)
        {
            ComprobacionDeDatos();
        }
        private void cmbDia_TextChanged(object sender, EventArgs e)
        {
            ComprobacionDeDatos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BlanqueoCampos();
            inpNombre.Focus();
            Program.s.frmDetalleActividades.Show();
            this.Hide();
        }
        private void cmbMinuto_TextChanged(object sender, EventArgs e)
        {
            ComprobacionDeDatos();
        }
        private void cmbHora_TextChanged(object sender, EventArgs e)
        {
            ComprobacionDeDatos();
        }
    }
}
