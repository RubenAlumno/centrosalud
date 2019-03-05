namespace CapaPresentacion
{
    partial class FrmBuscarCitasPorPaciente
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
            this.cboPacientes = new System.Windows.Forms.ComboBox();
            this.btnBuscarCitas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPacienteDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnRebuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpBuscarPacienteID.SuspendLayout();
            this.grpPacienteDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscarPacienteID
            // 
            this.grpBuscarPacienteID.Controls.Add(this.cboPacientes);
            this.grpBuscarPacienteID.Controls.Add(this.btnBuscarCitas);
            this.grpBuscarPacienteID.Controls.Add(this.label5);
            this.grpBuscarPacienteID.Location = new System.Drawing.Point(110, 438);
            this.grpBuscarPacienteID.Name = "grpBuscarPacienteID";
            this.grpBuscarPacienteID.Size = new System.Drawing.Size(570, 128);
            this.grpBuscarPacienteID.TabIndex = 34;
            this.grpBuscarPacienteID.TabStop = false;
            this.grpBuscarPacienteID.Text = "Busqueda De Citas por Pacientes";
            // 
            // cboPacientes
            // 
            this.cboPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacientes.FormattingEnabled = true;
            this.cboPacientes.Location = new System.Drawing.Point(100, 30);
            this.cboPacientes.Name = "cboPacientes";
            this.cboPacientes.Size = new System.Drawing.Size(432, 21);
            this.cboPacientes.TabIndex = 23;
            // 
            // btnBuscarCitas
            // 
            this.btnBuscarCitas.Location = new System.Drawing.Point(65, 66);
            this.btnBuscarCitas.Name = "btnBuscarCitas";
            this.btnBuscarCitas.Size = new System.Drawing.Size(333, 36);
            this.btnBuscarCitas.TabIndex = 8;
            this.btnBuscarCitas.Text = "Buscar citas de este Paciente";
            this.btnBuscarCitas.UseVisualStyleBackColor = true;
            this.btnBuscarCitas.Click += new System.EventHandler(this.btnBuscarCitas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Paciente";
            // 
            // grpPacienteDatos
            // 
            this.grpPacienteDatos.Controls.Add(this.label1);
            this.grpPacienteDatos.Controls.Add(this.dgvMedicos);
            this.grpPacienteDatos.Controls.Add(this.dgvCitas);
            this.grpPacienteDatos.Controls.Add(this.btnRebuscar);
            this.grpPacienteDatos.Controls.Add(this.txtNombre);
            this.grpPacienteDatos.Controls.Add(this.lblNombre);
            this.grpPacienteDatos.Location = new System.Drawing.Point(110, 56);
            this.grpPacienteDatos.Name = "grpPacienteDatos";
            this.grpPacienteDatos.Size = new System.Drawing.Size(1118, 376);
            this.grpPacienteDatos.TabIndex = 33;
            this.grpPacienteDatos.TabStop = false;
            this.grpPacienteDatos.Text = "Busqueda De Citas por Pacientes";
            this.grpPacienteDatos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Info Medicos (Que ha tenido o que va a tener por las Citas)";
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(544, 54);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(537, 257);
            this.dgvMedicos.TabIndex = 36;
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(22, 54);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(484, 257);
            this.dgvCitas.TabIndex = 35;
            // 
            // btnRebuscar
            // 
            this.btnRebuscar.Location = new System.Drawing.Point(382, 334);
            this.btnRebuscar.Name = "btnRebuscar";
            this.btnRebuscar.Size = new System.Drawing.Size(333, 36);
            this.btnRebuscar.TabIndex = 34;
            this.btnRebuscar.Text = "Buscar citas de otro Paciente";
            this.btnRebuscar.UseVisualStyleBackColor = true;
            this.btnRebuscar.Click += new System.EventHandler(this.btnRebuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 27);
            this.txtNombre.MaxLength = 12;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(341, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Citas de";
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
            // FrmBuscarCitasPorPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 582);
            this.Controls.Add(this.grpBuscarPacienteID);
            this.Controls.Add(this.grpPacienteDatos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarCitasPorPaciente";
            this.Text = "FrmBuscarCitasPorPaciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBuscarCitasPorPaciente_Load);
            this.grpBuscarPacienteID.ResumeLayout(false);
            this.grpBuscarPacienteID.PerformLayout();
            this.grpPacienteDatos.ResumeLayout(false);
            this.grpPacienteDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscarPacienteID;
        private System.Windows.Forms.Button btnBuscarCitas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpPacienteDatos;
        private System.Windows.Forms.Button btnRebuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.ComboBox cboPacientes;
    }
}