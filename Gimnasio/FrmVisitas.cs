using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{    
    public partial class FrmVisitas : Form
    {
        private int filasGrid;
        private int seleccionGrid;

        private int numVisitaActiva;
        private Fecha fecVisitaActiva;        
        public FrmVisitas()
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
                dgvVisitas.Rows.RemoveAt(dgvVisitas.Rows[0].Index);
                filasGrid--;
            }
        }
        public void CargarGrid()
        {
            foreach (Visita V in Program.a.baseVisitas.DetalleVisitas)
            {
                dgvVisitas.Rows.Add(V.Numero, V.Socio.DNI, V.Socio.Nombre, V.Socio.Apellido, V.Actividad.Nombre, V.Horario);
                filasGrid++;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.s.frmIntro.Show();
            temporizador.Enabled = false;
            this.Hide();
        }
        private void btnRegistroSocios_Click(object sender, EventArgs e)
        {
            Program.s.frmDetalleSocios.Show();
            this.Hide();
        }
        private void btnNuevaVisita_Click(object sender, EventArgs e)
        {
            Program.s.frmActividad.Show();            
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Program.s.frmHistorialVisitas.Show();
            
        }
        private void btnRegistroActividades_Click(object sender, EventArgs e)
        {
            Program.s.frmDetalleActividades.Show();
            this.Hide();
        }
        private void btnEliminarVisita_Click(object sender, EventArgs e)
        {
            if (Program.a.baseVisitas.ExisteVisita(numVisitaActiva, fecVisitaActiva))
            {
                if (MessageBox.Show("Está seguro que desea eliminar el usuario selecionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.a.baseVisitas.DetalleVisitas.Remove(Program.a.baseVisitas.BuscarVisita(numVisitaActiva, fecVisitaActiva));
                    Program.a.baseVisitas.RestablecerId();
                    RefrescarGrid();
                    btnEliminarVisita.Visible = false;
                    Program.GuardarBaseDatos();
                }
            }
            else
            {
                MessageBox.Show("Visita no encontrada. Cierre la aplicación y vuelva a abrirla. Es posible se haya movido al historial");
            }
        }
        private void dgvVisitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrid = dgvVisitas.CurrentRow.Index;
            if (seleccionGrid < filasGrid)
            {
                numVisitaActiva = Convert.ToInt32( dgvVisitas[0, seleccionGrid].Value.ToString() );
                int dia = DateTime.Today.Day;
                int mes = DateTime.Today.Month;
                int anio = DateTime.Today.Year;
                fecVisitaActiva = new Fecha(dia, mes, anio);
                if ( Program.a.baseVisitas.ExisteVisita(numVisitaActiva, fecVisitaActiva) )
                {
                    btnEliminarVisita.Visible = true;
                }
                else
                {
                    MessageBox.Show("Visita no encontrada. Cierre la aplicación y vuelva a abrirla. Es posible se haya movido al historial");
                }
            }
            else
            {
                btnEliminarVisita.Visible = false;
            }
        }
        private void ReestablecerTemporizador()
        {
            int horasRestantes = 23 - DateTime.Now.Hour;
            int minRestantes = 59 - DateTime.Now.Minute;
            int segResgantes = 59 - DateTime.Now.Second;
            int milRestantes = 999 - DateTime.Now.Millisecond;
            temporizador.Interval = milRestantes + segResgantes * 1000 + minRestantes * 60 * 1000 + horasRestantes * 60 * 60 * 1000;            
        }
        private void temporizador_Tick(object sender, EventArgs e)
        {
            BorrarGrid();
            Program.s.frmHistorialVisitas.PasajeAlHistorialMasBorradoDeVisitasAntiguas();
            CargarGrid();
            ReestablecerTemporizador();            
        }
        private void btnVaciarVisitas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar todas las visitas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Program.a.baseVisitas.DetalleVisitas.Clear();
                Program.a.baseVisitas.RestablecerId();
                BorrarGrid();
                Program.GuardarBaseDatos();
            }
        }
    }
}
