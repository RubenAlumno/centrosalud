namespace CapaPresentacion
{
    partial class FrmModificarEspecialidad
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
            this.grpModificarEspecialidad = new System.Windows.Forms.GroupBox();
            this.cboEspecialidades = new System.Windows.Forms.ComboBox();
            this.btnModificarEspecialidad = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpModificarEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModificarEspecialidad
            // 
            this.grpModificarEspecialidad.Controls.Add(this.cboEspecialidades);
            this.grpModificarEspecialidad.Controls.Add(this.btnModificarEspecialidad);
            this.grpModificarEspecialidad.Controls.Add(this.txtTelefono);
            this.grpModificarEspecialidad.Controls.Add(this.lblPaciente);
            this.grpModificarEspecialidad.Controls.Add(this.lblTelefono);
            this.grpModificarEspecialidad.Location = new System.Drawing.Point(78, 34);
            this.grpModificarEspecialidad.Name = "grpModificarEspecialidad";
            this.grpModificarEspecialidad.Size = new System.Drawing.Size(591, 156);
            this.grpModificarEspecialidad.TabIndex = 28;
            this.grpModificarEspecialidad.TabStop = false;
            this.grpModificarEspecialidad.Text = "Modificar Especialidad";
            // 
            // cboEspecialidades
            // 
            this.cboEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidades.FormattingEnabled = true;
            this.cboEspecialidades.Location = new System.Drawing.Point(168, 33);
            this.cboEspecialidades.Name = "cboEspecialidades";
            this.cboEspecialidades.Size = new System.Drawing.Size(374, 21);
            this.cboEspecialidades.TabIndex = 10;
            this.cboEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cboMedicos_SelectedIndexChanged);
            // 
            // btnModificarEspecialidad
            // 
            this.btnModificarEspecialidad.Location = new System.Drawing.Point(78, 104);
            this.btnModificarEspecialidad.Name = "btnModificarEspecialidad";
            this.btnModificarEspecialidad.Size = new System.Drawing.Size(333, 36);
            this.btnModificarEspecialidad.TabIndex = 8;
            this.btnModificarEspecialidad.Text = "Modificar el nombre de la Especialidad";
            this.btnModificarEspecialidad.UseVisualStyleBackColor = true;
            this.btnModificarEspecialidad.Click += new System.EventHandler(this.btnModificarEspecialidad_Click);
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
            this.lblPaciente.Size = new System.Drawing.Size(67, 13);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Especialidad";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 67);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(77, 13);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Nuevo nombre";
            this.lblTelefono.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::CapaPresentacion.Properties.Resources.atras;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtras.Location = new System.Drawing.Point(56, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(28, 28);
            this.btnAtras.TabIndex = 27;
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
            this.btnMinimizar.TabIndex = 26;
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
            this.btnSalir.TabIndex = 25;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmModificarEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.grpModificarEspecialidad);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarEspecialidad";
            this.Text = "FrmModificarEspecialidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmModificarEspecialidad_Load);
            this.grpModificarEspecialidad.ResumeLayout(false);
            this.grpModificarEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarEspecialidad;
        private System.Windows.Forms.ComboBox cboEspecialidades;
        private System.Windows.Forms.Button btnModificarEspecialidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
    }
}