namespace Gimnasio
{
    partial class FrmRegistroSocio
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.inpNombre = new System.Windows.Forms.TextBox();
            this.inpApellido = new System.Windows.Forms.TextBox();
            this.inpDireccion = new System.Windows.Forms.TextBox();
            this.inpNumero = new System.Windows.Forms.NumericUpDown();
            this.cmbPartido = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.btnCrearSocio = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpDni = new System.Windows.Forms.NumericUpDown();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnCargaImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inpNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpDni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(115, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Calle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(299, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "N°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(14, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "D.N.I.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(12, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Localidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(12, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Partido:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumento.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDocumento.Location = new System.Drawing.Point(232, 216);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(94, 18);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Documento";
            // 
            // inpNombre
            // 
            this.inpNombre.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpNombre.Location = new System.Drawing.Point(115, 51);
            this.inpNombre.Name = "inpNombre";
            this.inpNombre.Size = new System.Drawing.Size(156, 26);
            this.inpNombre.TabIndex = 1;
            // 
            // inpApellido
            // 
            this.inpApellido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpApellido.Location = new System.Drawing.Point(115, 106);
            this.inpApellido.Name = "inpApellido";
            this.inpApellido.Size = new System.Drawing.Size(156, 26);
            this.inpApellido.TabIndex = 2;
            // 
            // inpDireccion
            // 
            this.inpDireccion.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpDireccion.Location = new System.Drawing.Point(115, 271);
            this.inpDireccion.Name = "inpDireccion";
            this.inpDireccion.Size = new System.Drawing.Size(156, 26);
            this.inpDireccion.TabIndex = 5;
            // 
            // inpNumero
            // 
            this.inpNumero.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpNumero.Location = new System.Drawing.Point(332, 271);
            this.inpNumero.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inpNumero.Name = "inpNumero";
            this.inpNumero.Size = new System.Drawing.Size(70, 26);
            this.inpNumero.TabIndex = 6;
            // 
            // cmbPartido
            // 
            this.cmbPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartido.FormattingEnabled = true;
            this.cmbPartido.Items.AddRange(new object[] {
            "25 de Mayo",
            "9 de Julio",
            "Adolfo Alsina",
            "Adolfo Gonzales Chaves",
            "Alberti",
            "Almirante Brown",
            "Arrecifes",
            "Avellaneda",
            "Ayacucho",
            "Azul",
            "Bahía Blanca",
            "Balcarce",
            "Baradero",
            "Benito Juárez",
            "Berazategui",
            "Berisso",
            "Bolívar",
            "Bragado",
            "Brandsen",
            "Campana",
            "Cañuelas",
            "Capitán Sarmiento",
            "Carlos Casares",
            "Carlos Tejedor",
            "Carmen de Areco",
            "Castelli",
            "Chacabuco",
            "Chascomús",
            "Chivilcoy",
            "Ciudad de Buenos Aires",
            "Colón",
            "Coronel de Marina L. Rosales",
            "Coronel Dorrego",
            "Coronel Pringles",
            "Coronel Suárez",
            "Daireaux",
            "Dolores",
            "Ensenada",
            "Escobar",
            "Esteban Echeverría",
            "Exaltación de la Cruz",
            "Ezeiza",
            "Florencio Varela",
            "Florentino Ameghino",
            "General Alvarado",
            "General Alvear",
            "General Arenales",
            "General Belgrano",
            "General Guido",
            "General Juan Madariaga",
            "General La Madrid",
            "General Las Heras",
            "General Lavalle",
            "General Paz",
            "General Pinto",
            "General Pueyrredón",
            "General Rodríguez",
            "General San Martín",
            "General Viamonte",
            "General Villegas",
            "Guaminí",
            "Hipólito Yrigoyen",
            "Hurlingham",
            "Ituzaingó",
            "José C. Paz",
            "Junín",
            "La Costa",
            "La Matanza",
            "La Plata",
            "Lanús",
            "Laprida",
            "Las Flores",
            "Leandro N. Alem",
            "Lincoln",
            "Lobería",
            "Lobos",
            "Lomas de Zamora",
            "Luján",
            "Magdalena",
            "Maipú",
            "Malvinas Argentinas",
            "Mar Chiquita",
            "Marcos Paz",
            "Mercedes",
            "Merlo",
            "Monte",
            "Monte Hermoso",
            "Moreno",
            "Morón",
            "Navarro",
            "Necochea",
            "Olavarría",
            "Patagones",
            "Pehuajó",
            "Pellegrini",
            "Pergamino",
            "Pila",
            "Pilar",
            "Pinamar ",
            "Presidente Perón",
            "Puán",
            "Punta Indio",
            "Quilmes",
            "Ramallo",
            "Rauch",
            "Rivadavia",
            "Rojas",
            "Roque Pérez",
            "Saavedra",
            "Saladillo",
            "Salliqueló",
            "Salto",
            "San Andrés de Giles",
            "San Antonio de Areco",
            "San Cayetano",
            "San Fernando",
            "San Isidro",
            "San Miguel",
            "San Nicolás",
            "San Pedro",
            "San Vicente",
            "Suipacha",
            "Tandil",
            "Tapalqué",
            "Tigre",
            "Tordillo",
            "Tornquist",
            "Trenque Lauquen",
            "Tres Arroyos",
            "Tres de Febrero",
            "Tres Lomas ",
            "Vicente López",
            "Villa Gesell",
            "Villarino",
            "Zárate"});
            this.cmbPartido.Location = new System.Drawing.Point(115, 333);
            this.cmbPartido.Name = "cmbPartido";
            this.cmbPartido.Size = new System.Drawing.Size(156, 26);
            this.cmbPartido.TabIndex = 7;
            this.cmbPartido.SelectedIndexChanged += new System.EventHandler(this.cmbPartido_SelectedIndexChanged);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(115, 392);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(156, 26);
            this.cmbLocalidad.TabIndex = 8;
            // 
            // btnCrearSocio
            // 
            this.btnCrearSocio.Location = new System.Drawing.Point(196, 431);
            this.btnCrearSocio.Name = "btnCrearSocio";
            this.btnCrearSocio.Size = new System.Drawing.Size(75, 26);
            this.btnCrearSocio.TabIndex = 11;
            this.btnCrearSocio.Text = "Crear Socio";
            this.btnCrearSocio.UseVisualStyleBackColor = true;
            this.btnCrearSocio.Click += new System.EventHandler(this.btnCrearSocio_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.ErrorImage = null;
            this.pbImagen.Location = new System.Drawing.Point(302, 51);
            this.pbImagen.MaximumSize = new System.Drawing.Size(100, 100);
            this.pbImagen.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(100, 100);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 18;
            this.pbImagen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nuevo Socio";
            // 
            // inpDni
            // 
            this.inpDni.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpDni.Location = new System.Drawing.Point(115, 214);
            this.inpDni.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inpDni.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.inpDni.Name = "inpDni";
            this.inpDni.Size = new System.Drawing.Size(111, 26);
            this.inpDni.TabIndex = 4;
            this.inpDni.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.inpDni.TabIndexChanged += new System.EventHandler(this.inpDni_TabIndexChanged);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(115, 158);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(156, 26);
            this.dtpNacimiento.TabIndex = 3;
            this.dtpNacimiento.Value = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dtpNacimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpNacimiento_KeyDown);
            this.dtpNacimiento.Leave += new System.EventHandler(this.dtpNacimiento_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Cornsilk;
            this.label10.Location = new System.Drawing.Point(12, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nacimiento:";
            // 
            // ofdImagen
            // 
            this.ofdImagen.Filter = "Imágenes (*png;*jpg;*jpeg)|*.png;*.jpg;*.jpeg";
            this.ofdImagen.InitialDirectory = "C:\\Users\\Public\\Pictures";
            // 
            // btnCargaImagen
            // 
            this.btnCargaImagen.Location = new System.Drawing.Point(303, 158);
            this.btnCargaImagen.Name = "btnCargaImagen";
            this.btnCargaImagen.Size = new System.Drawing.Size(99, 26);
            this.btnCargaImagen.TabIndex = 9;
            this.btnCargaImagen.Text = "Agregar Imagen";
            this.btnCargaImagen.UseVisualStyleBackColor = true;
            this.btnCargaImagen.Click += new System.EventHandler(this.btnCargaImagen_Click);
            // 
            // FrmRegistroSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gimnasio.Properties.Resources.fondo_tecnologico_preferido_selectores;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 465);
            this.Controls.Add(this.btnCargaImagen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.inpDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnCrearSocio);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.cmbPartido);
            this.Controls.Add(this.inpNumero);
            this.Controls.Add(this.inpDireccion);
            this.Controls.Add(this.inpApellido);
            this.Controls.Add(this.inpNombre);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.MaximumSize = new System.Drawing.Size(437, 503);
            this.MinimumSize = new System.Drawing.Size(437, 503);
            this.Name = "FrmRegistroSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Socio";
            ((System.ComponentModel.ISupportInitialize)(this.inpNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpDni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox inpNombre;
        private System.Windows.Forms.TextBox inpApellido;
        private System.Windows.Forms.TextBox inpDireccion;
        private System.Windows.Forms.NumericUpDown inpNumero;
        private System.Windows.Forms.ComboBox cmbPartido;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Button btnCrearSocio;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inpDni;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.Button btnCargaImagen;
    }
}