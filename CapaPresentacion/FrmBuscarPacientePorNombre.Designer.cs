namespace CapaPresentacion
{
    partial class FrmBuscarPacientePorNombre
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
            this.grpBuscarPacienteID = new System.Windows.Forms.GroupBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPacienteDatos = new System.Windows.Forms.GroupBox();
            this.btnRebuscar = new System.Windows.Forms.Button();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpBuscarPacienteID.SuspendLayout();
            this.grpPacienteDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBuscarPacienteID
            // 
            this.grpBuscarPacienteID.Controls.Add(this.btnBuscarNombre);
            this.grpBuscarPacienteID.Controls.Add(this.txtNombre);
            this.grpBuscarPacienteID.Controls.Add(this.label5);
            this.grpBuscarPacienteID.Location = new System.Drawing.Point(129, 277);
            this.grpBuscarPacienteID.Name = "grpBuscarPacienteID";
            this.grpBuscarPacienteID.Size = new System.Drawing.Size(570, 128);
            this.grpBuscarPacienteID.TabIndex = 34;
            this.grpBuscarPacienteID.TabStop = false;
            this.grpBuscarPacienteID.Text = "Busqueda De Pacientes";
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(65, 66);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(333, 36);
            this.btnBuscarNombre.TabIndex = 8;
            this.btnBuscarNombre.Text = "Buscar El Paciente";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 30);
            this.txtNombre.MaxLength = 12;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(341, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre";
            // 
            // grpPacienteDatos
            // 
            this.grpPacienteDatos.Controls.Add(this.btnRebuscar);
            this.grpPacienteDatos.Controls.Add(this.txtLocalidad);
            this.grpPacienteDatos.Controls.Add(this.lblLocalidad);
            this.grpPacienteDatos.Controls.Add(this.txtDireccion);
            this.grpPacienteDatos.Controls.Add(this.lblDireccion);
            this.grpPacienteDatos.Controls.Add(this.txtTelefono);
            this.grpPacienteDatos.Controls.Add(this.lblTelefono);
            this.grpPacienteDatos.Controls.Add(this.txtID);
            this.grpPacienteDatos.Controls.Add(this.lblNombre);
            this.grpPacienteDatos.Location = new System.Drawing.Point(129, 38);
            this.grpPacienteDatos.Name = "grpPacienteDatos";
            this.grpPacienteDatos.Size = new System.Drawing.Size(591, 233);
            this.grpPacienteDatos.TabIndex = 33;
            this.grpPacienteDatos.TabStop = false;
            this.grpPacienteDatos.Text = "Busqueda De Pacientes";
            this.grpPacienteDatos.Visible = false;
            // 
            // btnRebuscar
            // 
            this.btnRebuscar.Location = new System.Drawing.Point(61, 177);
            this.btnRebuscar.Name = "btnRebuscar";
            this.btnRebuscar.Size = new System.Drawing.Size(333, 36);
            this.btnRebuscar.TabIndex = 34;
            this.btnRebuscar.Text = "Buscar otro paciente";
            this.btnRebuscar.UseVisualStyleBackColor = true;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(165, 135);
            this.txtLocalidad.MaxLength = 12;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(341, 20);
            this.txtLocalidad.TabIndex = 33;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(19, 135);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 32;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(165, 98);
            this.txtDireccion.MaxLength = 12;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(341, 20);
            this.txtDireccion.TabIndex = 31;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(19, 98);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(165, 62);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(341, 20);
            this.txtTelefono.TabIndex = 29;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 62);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 28;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 27);
            this.txtID.MaxLength = 12;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(341, 20);
            this.txtID.TabIndex = 27;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(18, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "ID";
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::CapaPresentacion.Properties.Resources.atras;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtras.Location = new System.Drawing.Point(56, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(28, 28);
            this.btnAtras.TabIndex = 32;
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
            this.btnMinimizar.TabIndex = 31;
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
            this.btnSalir.TabIndex = 30;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBuscarPacientePorNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 436);
            this.Controls.Add(this.grpBuscarPacienteID);
            this.Controls.Add(this.grpPacienteDatos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarPacientePorNombre";
            this.Text = "FrmBuscarPacientePorNombre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBuscarPacientePorNombre_Load);
            this.grpBuscarPacienteID.ResumeLayout(false);
            this.grpBuscarPacienteID.PerformLayout();
            this.grpPacienteDatos.ResumeLayout(false);
            this.grpPacienteDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscarPacienteID;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpPacienteDatos;
        private System.Windows.Forms.Button btnRebuscar;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
    }
}