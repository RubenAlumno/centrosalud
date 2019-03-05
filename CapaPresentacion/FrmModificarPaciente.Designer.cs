namespace CapaPresentacion
{
    partial class FrmModificarPaciente
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
            this.grpModificarPaciente = new System.Windows.Forms.GroupBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cboPacientes = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpModificarPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModificarPaciente
            // 
            this.grpModificarPaciente.Controls.Add(this.txtLocalidad);
            this.grpModificarPaciente.Controls.Add(this.cboPacientes);
            this.grpModificarPaciente.Controls.Add(this.txtDireccion);
            this.grpModificarPaciente.Controls.Add(this.btnModificarPaciente);
            this.grpModificarPaciente.Controls.Add(this.txtTelefono);
            this.grpModificarPaciente.Controls.Add(this.lblPaciente);
            this.grpModificarPaciente.Controls.Add(this.lblLocalidad);
            this.grpModificarPaciente.Controls.Add(this.lblTelefono);
            this.grpModificarPaciente.Controls.Add(this.lblDireccion);
            this.grpModificarPaciente.Location = new System.Drawing.Point(47, 48);
            this.grpModificarPaciente.Name = "grpModificarPaciente";
            this.grpModificarPaciente.Size = new System.Drawing.Size(591, 226);
            this.grpModificarPaciente.TabIndex = 21;
            this.grpModificarPaciente.TabStop = false;
            this.grpModificarPaciente.Text = "Modificar Paciente";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(168, 128);
            this.txtLocalidad.MaxLength = 100;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(341, 20);
            this.txtLocalidad.TabIndex = 27;
            this.txtLocalidad.Visible = false;
            // 
            // cboPacientes
            // 
            this.cboPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacientes.FormattingEnabled = true;
            this.cboPacientes.Location = new System.Drawing.Point(168, 33);
            this.cboPacientes.Name = "cboPacientes";
            this.cboPacientes.Size = new System.Drawing.Size(374, 21);
            this.cboPacientes.TabIndex = 10;
            this.cboPacientes.SelectedIndexChanged += new System.EventHandler(this.cboPacientes_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(168, 97);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(341, 20);
            this.txtDireccion.TabIndex = 26;
            this.txtDireccion.Visible = false;
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.Location = new System.Drawing.Point(77, 169);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(333, 36);
            this.btnModificarPaciente.TabIndex = 8;
            this.btnModificarPaciente.Text = "Modificar Los Datos Del Paciente";
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(168, 67);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(341, 20);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.Visible = false;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(22, 33);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(22, 128);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 24;
            this.lblLocalidad.Text = "Localidad";
            this.lblLocalidad.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 67);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 97);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::CapaPresentacion.Properties.Resources.atras;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtras.Location = new System.Drawing.Point(56, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(28, 28);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMinimizar.Location = new System.Drawing.Point(28, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 19;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 28);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmModificarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.grpModificarPaciente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarPaciente";
            this.Text = "FrmModificarPaciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmModificarPaciente_Load);
            this.grpModificarPaciente.ResumeLayout(false);
            this.grpModificarPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpModificarPaciente;
        private System.Windows.Forms.ComboBox cboPacientes;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
    }
}