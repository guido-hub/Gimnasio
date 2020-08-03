using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{    
    public partial class FrmDetalleUsuarios : Form
    {                           
        private int filasGrid;
        private int seleccionGrid;
        private string usuarioActivo;
        public FrmDetalleUsuarios()
        {
            InitializeComponent();                                
            filasGrid = 0;
            CargarGrid();
        }        
        public void RefrescarGrid()
        {
            BorrarGrid();
            CargarGrid();
        }
        public void BorrarGrid()
        {            
            while (filasGrid > 0)
            {
                dgvUsuarios.Rows.RemoveAt(dgvUsuarios.Rows[0].Index);
                filasGrid--;
            }                        
        }
        public void CargarGrid()
        {            
            foreach (Empleado E in Program.a.baseUsuarios.Usuarios)
            {
                dgvUsuarios.Rows.Add(E.Nombre,E.Apellido,E.Nacimiento,E.Usuario,E.Clave);                
                filasGrid++;
            }                                               
        }        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.s.frmRegistro.Show();
            this.Hide();
        }        
        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que desea eliminar todos los usuarios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {                
                Program.a.baseUsuarios.Usuarios.Clear();
                BorrarGrid();                                
                Program.GuardarBaseDatos();
            }            
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrid = dgvUsuarios.CurrentRow.Index;
            if(seleccionGrid < filasGrid)
            {
                usuarioActivo = dgvUsuarios[3, seleccionGrid].Value.ToString();                
                if (Program.a.baseUsuarios.ExisteUsuario(usuarioActivo))
                {
                    btnEliminarFila.Visible = true;
                }                                                
            }
            else
            {
                btnEliminarFila.Visible = false;
            }
        }
        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el usuario selecionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.a.baseUsuarios.Usuarios.Remove(Program.a.baseUsuarios.BuscarUsuario(usuarioActivo));
                dgvUsuarios.Rows.RemoveAt(seleccionGrid);
                filasGrid--;
                seleccionGrid = dgvUsuarios.CurrentRow.Index;
                btnEliminarFila.Visible = false;
                Program.GuardarBaseDatos();                                
            }            
        }        
    }
}
