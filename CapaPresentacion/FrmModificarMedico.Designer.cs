namespace CapaPresentacion
{
    partial class FrmModificarMedico
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpModificarMedico = new System.Windows.Forms.GroupBox();
            this.cboMedicos = new System.Windows.Forms.ComboBox();
            this.btnModificarMedico = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.grpModificarMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::CapaPresentacion.Properties.Resources.atras;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtras.Location = new System.Drawing.Point(56, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(28, 28);
            this.btnAtras.TabIndex = 23;
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
            this.btnMinimizar.TabIndex = 22;
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
            this.btnSalir.TabIndex = 21;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpModificarMedico
            // 
            this.grpModificarMedico.Controls.Add(this.cboMedicos);
            this.grpModificarMedico.Controls.Add(this.btnModificarMedico);
            this.grpModificarMedico.Controls.Add(this.txtTelefono);
            this.grpModificarMedico.Controls.Add(this.lblPaciente);
            this.grpModificarMedico.Controls.Add(this.lblTelefono);
            this.grpModificarMedico.Location = new System.Drawing.Point(56, 52);
            this.grpModificarMedico.Name = "grpModificarMedico";
            this.grpModificarMedico.Size = new System.Drawing.Size(591, 156);
            this.grpModificarMedico.TabIndex = 24;
            this.grpModificarMedico.TabStop = false;
            this.grpModificarMedico.Text = "Modificar Medico";
            // 
            // cboMedicos
            // 
            this.cboMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicos.FormattingEnabled = true;
            this.cboMedicos.Location = new System.Drawing.Point(168, 33);
            this.cboMedicos.Name = "cboMedicos";
            this.cboMedicos.Size = new System.Drawing.Size(374, 21);
            this.cboMedicos.TabIndex = 10;
            this.cboMedicos.SelectedIndexChanged += new System.EventHandler(this.cboMedicos_SelectedIndexChanged);
            // 
            // btnModificarMedico
            // 
            this.btnModificarMedico.Location = new System.Drawing.Point(78, 104);
            this.btnModificarMedico.Name = "btnModificarMedico";
            this.btnModificarMedico.Size = new System.Drawing.Size(333, 36);
            this.btnModificarMedico.TabIndex = 8;
            this.btnModificarMedico.Text = "Modificar Los Datos Del Medico";
            this.btnModificarMedico.UseVisualStyleBackColor = true;
            this.btnModificarMedico.Click += new System.EventHandler(this.btnModificarMedico_Click);
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
            this.lblPaciente.Size = new System.Drawing.Size(42, 13);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Medico";
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
            // FrmModificarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 341);
            this.Controls.Add(this.grpModificarMedico);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarMedico";
            this.Text = "FrmModificarMedico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmModificarMedico_Load);
            this.grpModificarMedico.ResumeLayout(false);
            this.grpModificarMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpModificarMedico;
        private System.Windows.Forms.ComboBox cboMedicos;
        private System.Windows.Forms.Button btnModificarMedico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblTelefono;
    }
}