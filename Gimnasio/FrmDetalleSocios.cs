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
    public partial class FrmDetalleSocios : Form
    {
        private int filasGrid;
        private int seleccionGrid;
        private int dniActivo;
        public FrmDetalleSocios()
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
                dgvSocios1.Rows.RemoveAt(dgvSocios1.Rows[0].Index);
                filasGrid--;
            }
        }
        public void CargarGrid()
        {
            foreach (Socio S in Program.a.baseSocios.Socios)
            {
                dgvSocios1.Rows.Add(S.Nombre, S.Apellido, S.Direccion, S.Numero, S.DNI, S.Localidad, S.Partido, S.Foto);
                filasGrid++;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.s.frmVisitas.Show();
            this.Hide();
        }
        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            Program.s.frmRegistroSocio.Show();            
        }        
        private void btnVaciarSocios_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar todos los socios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Program.a.baseSocios.Socios.Clear();
                BorrarGrid();
                Program.GuardarBaseDatos();
            }
        }        

        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el socio selecionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.a.baseSocios.Socios.Remove(Program.a.baseSocios.BuscarDni(dniActivo));
                dgvSocios1.Rows.RemoveAt(seleccionGrid);
                filasGrid--;
                seleccionGrid = dgvSocios1.CurrentRow.Index;
                btnEliminarSocio.Visible = false;
                Program.GuardarBaseDatos();
            }
        }

        private void dgvSocios1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrid = dgvSocios1.CurrentRow.Index;
            if (seleccionGrid < filasGrid)
            {
                dniActivo = Convert.ToInt32(dgvSocios1[4, seleccionGrid].Value.ToString());
                if (Program.a.baseSocios.ExisteDni(dniActivo))
                {
                    btnEliminarSocio.Visible = true;
                }
            }
            else
            {
                btnEliminarSocio.Visible = false;
            }
        }
    }
}
