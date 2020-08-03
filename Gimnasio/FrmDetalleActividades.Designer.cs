namespace Gimnasio
{
    partial class FrmDetalleActividades
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
            this.btnAgregarActividad = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.dgvListaActividades = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVaciarLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarActividad
            // 
            this.btnAgregarActividad.Location = new System.Drawing.Point(278, 213);
            this.btnAgregarActividad.Name = "btnAgregarActividad";
            this.btnAgregarActividad.Size = new System.Drawing.Size(102, 23);
            this.btnAgregarActividad.TabIndex = 4;
            this.btnAgregarActividad.Text = "Agregar actividad";
            this.btnAgregarActividad.UseVisualStyleBackColor = true;
            this.btnAgregarActividad.Click += new System.EventHandler(this.btnAgregarActividad_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 213);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Location = new System.Drawing.Point(197, 213);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFila.TabIndex = 3;
            this.btnEliminarFila.Text = "Eliminar fila";
            this.btnEliminarFila.UseVisualStyleBackColor = true;
            this.btnEliminarFila.Visible = false;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click);
            // 
            // dgvListaActividades
            // 
            this.dgvListaActividades.AllowUserToAddRows = false;
            this.dgvListaActividades.AllowUserToDeleteRows = false;
            this.dgvListaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Dia,
            this.Hora});
            this.dgvListaActividades.Location = new System.Drawing.Point(12, 46);
            this.dgvListaActividades.Name = "dgvListaActividades";
            this.dgvListaActividades.ReadOnly = true;
            this.dgvListaActividades.Size = new System.Drawing.Size(368, 150);
            this.dgvListaActividades.TabIndex = 0;
            this.dgvListaActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaActividades_CellClick);
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // btnVaciarLista
            // 
            this.btnVaciarLista.Location = new System.Drawing.Point(93, 213);
            this.btnVaciarLista.Name = "btnVaciarLista";
            this.btnVaciarLista.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarLista.TabIndex = 2;
            this.btnVaciarLista.Text = "Vaciar lista";
            this.btnVaciarLista.UseVisualStyleBackColor = true;
            this.btnVaciarLista.Click += new System.EventHandler(this.btnVaciarLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Actividades";
            // 
            // FrmDetalleActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gimnasio.Properties.Resources.fondo_del_agua_46698722;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVaciarLista);
            this.Controls.Add(this.dgvListaActividades);
            this.Controls.Add(this.btnEliminarFila);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarActividad);
            this.MaximumSize = new System.Drawing.Size(410, 289);
            this.MinimumSize = new System.Drawing.Size(410, 289);
            this.Name = "FrmDetalleActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de actividades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarActividad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminarFila;
        private System.Windows.Forms.DataGridView dgvListaActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button btnVaciarLista;
        private System.Windows.Forms.Label label1;
    }
}