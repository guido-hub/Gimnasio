namespace Gimnasio
{
    partial class FrmDetalleSocios
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNuevoSocio = new System.Windows.Forms.Button();
            this.btnEliminarSocio = new System.Windows.Forms.Button();
            this.btnVaciarSocios = new System.Windows.Forms.Button();
            this.dgvSocios1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnNuevoSocio
            // 
            this.btnNuevoSocio.Location = new System.Drawing.Point(800, 12);
            this.btnNuevoSocio.Name = "btnNuevoSocio";
            this.btnNuevoSocio.Size = new System.Drawing.Size(83, 23);
            this.btnNuevoSocio.TabIndex = 4;
            this.btnNuevoSocio.Text = "Nuevo Socio";
            this.btnNuevoSocio.UseVisualStyleBackColor = true;
            this.btnNuevoSocio.Click += new System.EventHandler(this.btnNuevoSocio_Click);
            // 
            // btnEliminarSocio
            // 
            this.btnEliminarSocio.Location = new System.Drawing.Point(236, 12);
            this.btnEliminarSocio.Name = "btnEliminarSocio";
            this.btnEliminarSocio.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSocio.TabIndex = 2;
            this.btnEliminarSocio.Text = "Eliminar fila";
            this.btnEliminarSocio.UseVisualStyleBackColor = true;
            this.btnEliminarSocio.Visible = false;
            this.btnEliminarSocio.Click += new System.EventHandler(this.btnEliminarSocio_Click);
            // 
            // btnVaciarSocios
            // 
            this.btnVaciarSocios.Location = new System.Drawing.Point(475, 12);
            this.btnVaciarSocios.Name = "btnVaciarSocios";
            this.btnVaciarSocios.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarSocios.TabIndex = 3;
            this.btnVaciarSocios.Text = "Vaciar lista";
            this.btnVaciarSocios.UseVisualStyleBackColor = true;
            this.btnVaciarSocios.Click += new System.EventHandler(this.btnVaciarSocios_Click);
            // 
            // dgvSocios1
            // 
            this.dgvSocios1.AllowUserToAddRows = false;
            this.dgvSocios1.AllowUserToDeleteRows = false;
            this.dgvSocios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Apell,
            this.Call,
            this.Num,
            this.Documento,
            this.Loc,
            this.Partid,
            this.Foto});
            this.dgvSocios1.Location = new System.Drawing.Point(12, 140);
            this.dgvSocios1.Name = "dgvSocios1";
            this.dgvSocios1.ReadOnly = true;
            this.dgvSocios1.RowTemplate.Height = 50;
            this.dgvSocios1.ShowCellErrors = false;
            this.dgvSocios1.Size = new System.Drawing.Size(871, 303);
            this.dgvSocios1.TabIndex = 0;
            this.dgvSocios1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocios1_CellClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nombre";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Apell
            // 
            this.Apell.HeaderText = "Apellido";
            this.Apell.Name = "Apell";
            this.Apell.ReadOnly = true;
            // 
            // Call
            // 
            this.Call.HeaderText = "Calle";
            this.Call.Name = "Call";
            this.Call.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.HeaderText = "Número";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "D.N.I.";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Loc
            // 
            this.Loc.HeaderText = "Localidad";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            // 
            // Partid
            // 
            this.Partid.HeaderText = "Partido";
            this.Partid.Name = "Partid";
            this.Partid.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto.MinimumWidth = 100;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmDetalleSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gimnasio.Properties.Resources.Fondo_de_pantalla_Abstracto_134;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 455);
            this.Controls.Add(this.dgvSocios1);
            this.Controls.Add(this.btnVaciarSocios);
            this.Controls.Add(this.btnEliminarSocio);
            this.Controls.Add(this.btnNuevoSocio);
            this.Controls.Add(this.btnVolver);
            this.MaximumSize = new System.Drawing.Size(911, 493);
            this.MinimumSize = new System.Drawing.Size(911, 493);
            this.Name = "FrmDetalleSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Socios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNuevoSocio;
        private System.Windows.Forms.Button btnEliminarSocio;
        private System.Windows.Forms.Button btnVaciarSocios;
        private System.Windows.Forms.DataGridView dgvSocios1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partid;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
    }
}