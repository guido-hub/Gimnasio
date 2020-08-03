namespace Gimnasio
{
    partial class FrmVisitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvVisitas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistroSocios = new System.Windows.Forms.Button();
            this.btnEliminarVisita = new System.Windows.Forms.Button();
            this.btnNuevaVisita = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnRegistroActividades = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.btnVaciarVisitas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitas
            // 
            this.dgvVisitas.AllowUserToAddRows = false;
            this.dgvVisitas.AllowUserToDeleteRows = false;
            this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Actividad,
            this.Hora});
            this.dgvVisitas.Location = new System.Drawing.Point(144, 12);
            this.dgvVisitas.Name = "dgvVisitas";
            this.dgvVisitas.ReadOnly = true;
            this.dgvVisitas.Size = new System.Drawing.Size(668, 432);
            this.dgvVisitas.TabIndex = 0;
            this.dgvVisitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitas_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "N°";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // btnRegistroSocios
            // 
            this.btnRegistroSocios.Location = new System.Drawing.Point(12, 281);
            this.btnRegistroSocios.Name = "btnRegistroSocios";
            this.btnRegistroSocios.Size = new System.Drawing.Size(111, 23);
            this.btnRegistroSocios.TabIndex = 5;
            this.btnRegistroSocios.Text = "Registro Socios";
            this.btnRegistroSocios.UseVisualStyleBackColor = true;
            this.btnRegistroSocios.Click += new System.EventHandler(this.btnRegistroSocios_Click);
            // 
            // btnEliminarVisita
            // 
            this.btnEliminarVisita.Location = new System.Drawing.Point(12, 215);
            this.btnEliminarVisita.Name = "btnEliminarVisita";
            this.btnEliminarVisita.Size = new System.Drawing.Size(111, 23);
            this.btnEliminarVisita.TabIndex = 4;
            this.btnEliminarVisita.Text = "Eliminar fila";
            this.btnEliminarVisita.UseVisualStyleBackColor = true;
            this.btnEliminarVisita.Visible = false;
            this.btnEliminarVisita.Click += new System.EventHandler(this.btnEliminarVisita_Click);
            // 
            // btnNuevaVisita
            // 
            this.btnNuevaVisita.Location = new System.Drawing.Point(12, 12);
            this.btnNuevaVisita.Name = "btnNuevaVisita";
            this.btnNuevaVisita.Size = new System.Drawing.Size(111, 23);
            this.btnNuevaVisita.TabIndex = 1;
            this.btnNuevaVisita.Text = "Nueva Visita";
            this.btnNuevaVisita.UseVisualStyleBackColor = true;
            this.btnNuevaVisita.Click += new System.EventHandler(this.btnNuevaVisita_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(12, 421);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(12, 79);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(111, 23);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial de visitas";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnRegistroActividades
            // 
            this.btnRegistroActividades.Location = new System.Drawing.Point(12, 346);
            this.btnRegistroActividades.Name = "btnRegistroActividades";
            this.btnRegistroActividades.Size = new System.Drawing.Size(111, 23);
            this.btnRegistroActividades.TabIndex = 6;
            this.btnRegistroActividades.Text = "Registro actividades";
            this.btnRegistroActividades.UseVisualStyleBackColor = true;
            this.btnRegistroActividades.Click += new System.EventHandler(this.btnRegistroActividades_Click);
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // btnVaciarVisitas
            // 
            this.btnVaciarVisitas.Location = new System.Drawing.Point(12, 149);
            this.btnVaciarVisitas.Name = "btnVaciarVisitas";
            this.btnVaciarVisitas.Size = new System.Drawing.Size(111, 23);
            this.btnVaciarVisitas.TabIndex = 3;
            this.btnVaciarVisitas.Text = "Vaciar visitas";
            this.btnVaciarVisitas.UseVisualStyleBackColor = true;
            this.btnVaciarVisitas.Click += new System.EventHandler(this.btnVaciarVisitas_Click);
            // 
            // FrmVisitas
            // 
            this.AcceptButton = this.btnNuevaVisita;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gimnasio.Properties.Resources.colores_frescos_abstractos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(824, 457);
            this.Controls.Add(this.btnVaciarVisitas);
            this.Controls.Add(this.btnRegistroActividades);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevaVisita);
            this.Controls.Add(this.btnEliminarVisita);
            this.Controls.Add(this.btnRegistroSocios);
            this.Controls.Add(this.dgvVisitas);
            this.MaximumSize = new System.Drawing.Size(840, 495);
            this.MinimumSize = new System.Drawing.Size(840, 495);
            this.Name = "FrmVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisitas;
        private System.Windows.Forms.Button btnRegistroSocios;
        private System.Windows.Forms.Button btnEliminarVisita;
        private System.Windows.Forms.Button btnNuevaVisita;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnRegistroActividades;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Button btnVaciarVisitas;
    }
}