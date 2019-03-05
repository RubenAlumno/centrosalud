namespace CapaPresentacion
{
    partial class FrmCrearCita
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
            this.grpCrearCita = new System.Windows.Forms.GroupBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboMedicos = new System.Windows.Forms.ComboBox();
            this.cboEspecialidades = new System.Windows.Forms.ComboBox();
            this.cboPacientes = new System.Windows.Forms.ComboBox();
            this.btnCrearCita = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.grpCrearCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::CapaPresentacion.Properties.Resources.atras;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtras.Location = new System.Drawing.Point(56, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(28, 28);
            this.btnAtras.TabIndex = 17;
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
            this.btnMinimizar.TabIndex = 16;
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
            this.btnSalir.TabIndex = 15;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpCrearCita
            // 
            this.grpCrearCita.Controls.Add(this.dtpHora);
            this.grpCrearCita.Controls.Add(this.dtpFecha);
            this.grpCrearCita.Controls.Add(this.lblHora);
            this.grpCrearCita.Controls.Add(this.lblFecha);
            this.grpCrearCita.Controls.Add(this.cboMedicos);
            this.grpCrearCita.Controls.Add(this.cboEspecialidades);
            this.grpCrearCita.Controls.Add(this.cboPacientes);
            this.grpCrearCita.Controls.Add(this.btnCrearCita);
            this.grpCrearCita.Controls.Add(this.lblMedico);
            this.grpCrearCita.Controls.Add(this.lblEspecialidad);
            this.grpCrearCita.Controls.Add(this.lblPaciente);
            this.grpCrearCita.Location = new System.Drawing.Point(118, 51);
            this.grpCrearCita.Name = "grpCrearCita";
            this.grpCrearCita.Size = new System.Drawing.Size(591, 259);
            this.grpCrearCita.TabIndex = 18;
            this.grpCrearCita.TabStop = false;
            this.grpCrearCita.Text = "Crear Cita";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(168, 161);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(374, 20);
            this.dtpHora.TabIndex = 16;
            this.dtpHora.Value = new System.DateTime(2019, 2, 8, 12, 43, 0, 0);
            this.dtpHora.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(168, 129);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(374, 20);
            this.dtpFecha.TabIndex = 15;
            this.dtpFecha.Value = new System.DateTime(2019, 2, 8, 0, 0, 0, 0);
            this.dtpFecha.Visible = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(22, 161);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "Hora";
            this.lblHora.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 135);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Visible = false;
            // 
            // cboMedicos
            // 
            this.cboMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicos.FormattingEnabled = true;
            this.cboMedicos.Location = new System.Drawing.Point(168, 94);
            this.cboMedicos.Name = "cboMedicos";
            this.cboMedicos.Size = new System.Drawing.Size(374, 21);
            this.cboMedicos.TabIndex = 12;
            this.cboMedicos.Visible = false;
            this.cboMedicos.SelectedIndexChanged += new System.EventHandler(this.cboMedicos_SelectedIndexChanged);
            // 
            // cboEspecialidades
            // 
            this.cboEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidades.FormattingEnabled = true;
            this.cboEspecialidades.Location = new System.Drawing.Point(168, 64);
            this.cboEspecialidades.Name = "cboEspecialidades";
            this.cboEspecialidades.Size = new System.Drawing.Size(374, 21);
            this.cboEspecialidades.TabIndex = 11;
            this.cboEspecialidades.Visible = false;
            this.cboEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cboEspecialidades_SelectedIndexChanged);
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
            // btnCrearCita
            // 
            this.btnCrearCita.Location = new System.Drawing.Point(85, 198);
            this.btnCrearCita.Name = "btnCrearCita";
            this.btnCrearCita.Size = new System.Drawing.Size(333, 36);
            this.btnCrearCita.TabIndex = 8;
            this.btnCrearCita.Text = "Crear Cita";
            this.btnCrearCita.UseVisualStyleBackColor = true;
            this.btnCrearCita.Visible = false;
            this.btnCrearCita.Click += new System.EventHandler(this.btnCrearCita_Click);
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(22, 94);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(42, 13);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Medico";
            this.lblMedico.Visible = false;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(22, 64);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad";
            this.lblEspecialidad.Visible = false;
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
            // FrmCrearCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.grpCrearCita);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearCita";
            this.Text = "FrmCrearCita";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCrearCita_Load);
            this.grpCrearCita.ResumeLayout(false);
            this.grpCrearCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpCrearCita;
        private System.Windows.Forms.Button btnCrearCita;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cboEspecialidades;
        private System.Windows.Forms.ComboBox cboPacientes;
        private System.Windows.Forms.ComboBox cboMedicos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}