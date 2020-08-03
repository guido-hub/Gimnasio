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
    public partial class FrmActividad : Form
    {
        private bool socioElegido;
        private bool deporteElegido;
        
        private int filasGridSocio;
        private int filasGridActividad;

        private int seleccionGridSocio;
        private int seleccionGridActividad;
        
        private int socioActivo;
        private string nombreDeporteActivo;        
        private Dia day;

        public FrmActividad()
        {
            InitializeComponent();
            socioElegido = false;
            deporteElegido = false;
            filasGridSocio = 0;
            filasGridActividad = 0;
            CargarGridActividades();
            CargarGridSocios();
        }
        public void RefrescarGridSocios()
        {
            BorrarGridSocios();
            CargarGridSocios();
            socioElegido = false;            
            btnAceptar.Visible = false;
        }
        public void RefrescarGridActividades()
        {
            BorrarGridActividades();
            CargarGridActividades();
            deporteElegido = false;
            btnAceptar.Visible = false;
        }
        public void BorrarGridSocios()
        {
            while (filasGridSocio > 0)
            {
                dgvListaSocios.Rows.RemoveAt(dgvListaSocios.Rows[0].Index);
                filasGridSocio--;
            }
        }
        public void CargarGridSocios()
        {
            foreach (Socio S in Program.a.baseSocios.Socios)
            {
                dgvListaSocios.Rows.Add(S.DNI, S.Nombre, S.Apellido);
                filasGridSocio++;
            }
        }
        public void BorrarGridActividades()
        {
            while (filasGridActividad > 0)
            {
                dgvListaActividades.Rows.RemoveAt(dgvListaActividades.Rows[0].Index);
                filasGridActividad--;
            }
        }
        public void CargarGridActividades()
        {
            foreach (Actividad A in Program.a.baseActividades.Actividades)
            {
                dgvListaActividades.Rows.Add(A.Nombre, A.Dia.NombreDia, A.Dia.Hora);
                filasGridActividad++;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.s.frmVisitas.Show();
            this.Hide();
        }

        private void dgvListaSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGridSocio = dgvListaSocios.CurrentRow.Index;
            if (seleccionGridSocio < filasGridSocio)
            {
                socioActivo = Convert.ToInt32( dgvListaSocios[0, seleccionGridSocio].Value.ToString() );
                if ( Program.a.baseSocios.ExisteDni(socioActivo) )
                {                    
                    socioElegido = true;
                    if (socioElegido && deporteElegido)
                    {
                        btnAceptar.Visible = true;
                        return;
                    }                                                            
                }                
            }            
            btnAceptar.Visible = false;
        }

        private void dgvListaActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGridActividad = dgvListaActividades.CurrentRow.Index;
            if (seleccionGridActividad < filasGridActividad)
            {
                nombreDeporteActivo = dgvListaActividades[0, seleccionGridActividad].Value.ToString();
                string diaDeporteActivo = dgvListaActividades[1, seleccionGridActividad].Value.ToString();
                int horaDeporteActivo = Convert.ToInt32( dgvListaActividades[2, seleccionGridActividad].Value.ToString().Substring(0, 2) );
                int minDeporteActivo = Convert.ToInt32( dgvListaActividades[2, seleccionGridActividad].Value.ToString().Substring(3, 2) );

                Horario hour = new Horario(horaDeporteActivo, minDeporteActivo);
                day = new Dia(diaDeporteActivo, hour);

                if ( Program.a.baseActividades.ExisteActividad(nombreDeporteActivo, day) )
                {                    
                    deporteElegido = true;
                    if (socioElegido && deporteElegido)
                    {
                        btnAceptar.Visible = true;
                        return;
                    }
                }
            }            
            btnAceptar.Visible = false;
        }
        private void CargarVisita()
        {
            Socio socio = Program.a.baseSocios.BuscarDni(socioActivo);
            Actividad deporte = Program.a.baseActividades.BuscarActividad(nombreDeporteActivo, day);
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;
            Fecha fecha = new Fecha(dia, mes, anio);
            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            Horario horario = new Horario(hora, min);
            Program.a.baseVisitas.AgregarVisita(socio, deporte, fecha, horario);
            Program.s.frmVisitas.RefrescarGrid();
            Program.GuardarBaseDatos();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show( "Confirmar visita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                CargarVisita();
                if ( MessageBox.Show("Desea continuar con la carga de visitas?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Program.s.frmVisitas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Seleccione nuevamente socio y actividad");
                }
                socioElegido = false;
                deporteElegido = false;
                btnAceptar.Visible = false;
            }
        }
    }
}
