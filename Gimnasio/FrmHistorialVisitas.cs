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
    public partial class FrmHistorialVisitas : Form
    {
        private int filasGrid;
        private int seleccionGrid;

        private int numRegistroActivo;        
        private Fecha fec;
        public FrmHistorialVisitas()
        {
            InitializeComponent();            
            filasGrid = 0;                        
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
                dgvHistorial.Rows.RemoveAt(dgvHistorial.Rows[0].Index);
                filasGrid--;
            }
        }
        public void CargarGrid()
        {
            foreach (Visita V in Program.a.baseHistorial.HistorialVisitas)
            {
                dgvHistorial.Rows.Add(V.Numero, V.Socio.Nombre, V.Socio.Apellido, V.Socio.DNI, V.Actividad.Nombre, V.Horario, V.Fecha);
                filasGrid++;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.s.frmVisitas.Show();
            this.Hide();
        }
        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrid = dgvHistorial.CurrentRow.Index;
            if (seleccionGrid < filasGrid)
            {
                numRegistroActivo = Convert.ToInt32( dgvHistorial[0, seleccionGrid].Value.ToString() );
                int diaRegistroActivo = Convert.ToInt32(dgvHistorial[6, seleccionGrid].Value.ToString().Substring(0,2));
                int mesRegistroActivo = Convert.ToInt32(dgvHistorial[6, seleccionGrid].Value.ToString().Substring(3, 2));
                int anioRegistroActivo = Convert.ToInt32(dgvHistorial[6, seleccionGrid].Value.ToString().Substring(6, 4));
                fec = new Fecha(diaRegistroActivo, mesRegistroActivo, anioRegistroActivo);

                if ( Program.a.baseHistorial.ExisteRegistro(numRegistroActivo,fec) )
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
            if (MessageBox.Show("Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                Program.a.baseHistorial.HistorialVisitas.Remove( Program.a.baseHistorial.BuscarRegistro(numRegistroActivo, fec) );
                Program.a.baseHistorial.RestablecerId(fec);
                RefrescarGrid();
                btnEliminarFila.Visible = false;
                Program.GuardarBaseDatos();
            }
        }
        public void PasajeAlHistorialMasBorradoDeVisitasAntiguas()
        {
            BorrarGrid();
            PasarVisitasAntiguas();
            BorrarVisitasAntiguas();
            CargarGrid();
        }
        public void PasarVisitasAntiguas()
        {
            Program.a.baseVisitas.TraspasoDeVisitas();
        }
        public void BorrarVisitasAntiguas()
        {
            Program.a.baseHistorial.BorradoHistorico();
        }
        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar todos los registros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Program.a.baseHistorial.HistorialVisitas.Clear();
                BorrarGrid();
                Program.GuardarBaseDatos();
            }
        }
    }
}