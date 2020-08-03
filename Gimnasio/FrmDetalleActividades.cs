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
    public partial class FrmDetalleActividades : Form
    {        
        private int filasGrid;
        private int seleccionGrid;

        private string nomDepoActivo;                
        private Dia day;
        public FrmDetalleActividades()
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
                dgvListaActividades.Rows.RemoveAt(dgvListaActividades.Rows[0].Index);
                filasGrid--;
            }
        }
        public void CargarGrid()
        {
            foreach (Actividad A in Program.a.baseActividades.Actividades)
            {
                dgvListaActividades.Rows.Add(A.Nombre, A.Dia.NombreDia, A.Dia.Hora);
                filasGrid++;
            }
        }
        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            Program.s.frmRegistroActividad.Show();            
        }
        private void dgvListaActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrid = dgvListaActividades.CurrentRow.Index;
            if (seleccionGrid < filasGrid)
            {
                nomDepoActivo = dgvListaActividades[0, seleccionGrid].Value.ToString();
                string diaDepoActivo = dgvListaActividades[1, seleccionGrid].Value.ToString();
                int horaDepoActivo = Convert.ToInt32( dgvListaActividades[2, seleccionGrid].Value.ToString().Substring(0,2) );
                int minDepoActivo = Convert.ToInt32( dgvListaActividades[2, seleccionGrid].Value.ToString().Substring(3, 2) );

                Horario hour = new Horario( horaDepoActivo, minDepoActivo );
                day = new Dia(diaDepoActivo, hour);
                if ( Program.a.baseActividades.ExisteActividad(nomDepoActivo, day) )
                {                    
                    btnEliminarFila.Visible = true;
                }
            }
            else
            {
                btnEliminarFila.Visible = false;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.s.frmVisitas.Show();
            this.Hide();
        }

        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar todas las actividades?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Program.a.baseActividades.Actividades.Clear();
                BorrarGrid();
                Program.GuardarBaseDatos();
            }
        }
        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar la actividad seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.a.baseActividades.Actividades.Remove(Program.a.baseActividades.BuscarActividad(nomDepoActivo, day));
                dgvListaActividades.Rows.RemoveAt(seleccionGrid);
                filasGrid--;
                seleccionGrid = dgvListaActividades.CurrentRow.Index;
                btnEliminarFila.Visible = false;
                Program.GuardarBaseDatos();                                
            }
        }
    }
}
