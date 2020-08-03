namespace Gimnasio
{
    partial class FrmRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.inpNombre = new System.Windows.Forms.TextBox();
            this.inpApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpUsuario = new System.Windows.Forms.TextBox();
            this.inpContrasenia1 = new System.Windows.Forms.TextBox();
            this.inpContrasenia2 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EtqClave = new System.Windows.Forms.Label();
            this.btnBaseUsuarios = new System.Windows.Forms.Button();
            this.EtqUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo usuario";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(481, 316);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 25);
            this.btnRegistrarse.TabIndex = 8;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // inpNombre
            // 
            this.inpNombre.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpNombre.Location = new System.Drawing.Point(210, 73);
            this.inpNombre.Name = "inpNombre";
            this.inpNombre.Size = new System.Drawing.Size(168, 25);
            this.inpNombre.TabIndex = 1;
            // 
            // inpApellido
            // 
            this.inpApellido.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpApellido.Location = new System.Drawing.Point(210, 122);
            this.inpApellido.Name = "inpApellido";
            this.inpApellido.Size = new System.Drawing.Size(168, 25);
            this.inpApellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido:";
            // 
            // inpUsuario
            // 
            this.inpUsuario.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpUsuario.Location = new System.Drawing.Point(210, 222);
            this.inpUsuario.Name = "inpUsuario";
            this.inpUsuario.Size = new System.Drawing.Size(168, 25);
            this.inpUsuario.TabIndex = 4;
            this.inpUsuario.TextChanged += new System.EventHandler(this.inpUsuario_TextChanged);
            // 
            // inpContrasenia1
            // 
            this.inpContrasenia1.CausesValidation = false;
            this.inpContrasenia1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpContrasenia1.Location = new System.Drawing.Point(210, 271);
            this.inpContrasenia1.Name = "inpContrasenia1";
            this.inpContrasenia1.PasswordChar = '*';
            this.inpContrasenia1.Size = new System.Drawing.Size(168, 25);
            this.inpContrasenia1.TabIndex = 5;
            this.inpContrasenia1.UseSystemPasswordChar = true;
            this.inpContrasenia1.TextChanged += new System.EventHandler(this.inpContrasenia1_TextChanged);
            // 
            // inpContrasenia2
            // 
            this.inpContrasenia2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpContrasenia2.Location = new System.Drawing.Point(210, 316);
            this.inpContrasenia2.Name = "inpContrasenia2";
            this.inpContrasenia2.PasswordChar = '*';
            this.inpContrasenia2.Size = new System.Drawing.Size(168, 25);
            this.inpContrasenia2.TabIndex = 6;
            this.inpContrasenia2.TextChanged += new System.EventHandler(this.inpContrasenia2_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(400, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirme su contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 173);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 6, 11, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 25);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(1985, 6, 24, 0, 0, 0, 0);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // EtqClave
            // 
            this.EtqClave.AutoSize = true;
            this.EtqClave.BackColor = System.Drawing.Color.Transparent;
            this.EtqClave.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtqClave.Location = new System.Drawing.Point(397, 298);
            this.EtqClave.Name = "EtqClave";
            this.EtqClave.Size = new System.Drawing.Size(82, 16);
            this.EtqClave.TabIndex = 0;
            this.EtqClave.Text = "Contraseña";
            this.EtqClave.Visible = false;
            // 
            // btnBaseUsuarios
            // 
            this.btnBaseUsuarios.Location = new System.Drawing.Point(400, 73);
            this.btnBaseUsuarios.Name = "btnBaseUsuarios";
            this.btnBaseUsuarios.Size = new System.Drawing.Size(156, 25);
            this.btnBaseUsuarios.TabIndex = 9;
            this.btnBaseUsuarios.Text = "Base de Usuarios";
            this.btnBaseUsuarios.UseVisualStyleBackColor = true;
            this.btnBaseUsuarios.Click += new System.EventHandler(this.btnBaseUsuarios_Click);
            // 
            // EtqUsuario
            // 
            this.EtqUsuario.AutoSize = true;
            this.EtqUsuario.BackColor = System.Drawing.Color.Transparent;
            this.EtqUsuario.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtqUsuario.Location = new System.Drawing.Point(397, 230);
            this.EtqUsuario.Name = "EtqUsuario";
            this.EtqUsuario.Size = new System.Drawing.Size(59, 17);
            this.EtqUsuario.TabIndex = 0;
            this.EtqUsuario.Text = "Usuario";
            this.EtqUsuario.Visible = false;
            // 
            // FrmRegistro
            // 
            this.AcceptButton = this.btnRegistrarse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gimnasio.Properties.Resources.unicornio_fondo_con_arco_iris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(589, 370);
            this.Controls.Add(this.EtqUsuario);
            this.Controls.Add(this.btnBaseUsuarios);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EtqClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpContrasenia2);
            this.Controls.Add(this.inpContrasenia1);
            this.Controls.Add(this.inpUsuario);
            this.Controls.Add(this.inpApellido);
            this.Controls.Add(this.inpNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(605, 404);
            this.MinimumSize = new System.Drawing.Size(605, 404);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox inpNombre;
        private System.Windows.Forms.TextBox inpApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpUsuario;
        private System.Windows.Forms.TextBox inpContrasenia1;
        private System.Windows.Forms.TextBox inpContrasenia2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label EtqClave;
        private System.Windows.Forms.Button btnBaseUsuarios;
        private System.Windows.Forms.Label EtqUsuario;
    }
}