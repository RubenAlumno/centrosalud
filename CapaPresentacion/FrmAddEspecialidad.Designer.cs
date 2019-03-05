namespace CapaPresentacion
{
    partial class FrmAddEspecialidad
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
            this.grpAddEspecialidad = new System.Windows.Forms.GroupBox();
            this.cboEspecialidades = new System.Windows.Forms.ComboBox();
            this.cboMedicos = new System.Windows.Forms.ComboBox();
            this.btnAddEspecialidad = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpAddEspecialidad.SuspendLayout();
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
            // grpAddEspecialidad
            // 
            this.grpAddEspecialidad.Controls.Add(this.cboEspecialidades);
            this.grpAddEspecialidad.Controls.Add(this.cboMedicos);
            this.grpAddEspecialidad.Controls.Add(this.btnAddEspecialidad);
            this.grpAddEspecialidad.Controls.Add(this.lblTelefono);
            this.grpAddEspecialidad.Controls.Add(this.lblNombre);
            this.grpAddEspecialidad.Location = new System.Drawing.Point(94, 73);
            this.grpAddEspecialidad.Name = "grpAddEspecialidad";
            this.grpAddEspecialidad.Size = new System.Drawing.Size(532, 159);
            this.grpAddEspecialidad.TabIndex = 18;
            this.grpAddEspecialidad.TabStop = false;
            this.grpAddEspecialidad.Text = "Añadir especialidad a un Medico";
            // 
            // cboEspecialidades
            // 
            this.cboEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidades.FormattingEnabled = true;
            this.cboEspecialidades.Location = new System.Drawing.Point(130, 61);
            this.cboEspecialidades.Name = "cboEspecialidades";
            this.cboEspecialidades.Size = new System.Drawing.Size(374, 21);
            this.cboEspecialidades.TabIndex = 10;
            // 
            // cboMedicos
            // 
            this.cboMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicos.FormattingEnabled = true;
            this.cboMedicos.Location = new System.Drawing.Point(130, 28);
            this.cboMedicos.Name = "cboMedicos";
            this.cboMedicos.Size = new System.Drawing.Size(374, 21);
            this.cboMedicos.TabIndex = 9;
            // 
            // btnAddEspecialidad
            // 
            this.btnAddEspecialidad.Location = new System.Drawing.Point(92, 102);
            this.btnAddEspecialidad.Name = "btnAddEspecialidad";
            this.btnAddEspecialidad.Size = new System.Drawing.Size(333, 36);
            this.btnAddEspecialidad.TabIndex = 8;
            this.btnAddEspecialidad.Text = "Añadir Especialidad al medico";
            this.btnAddEspecialidad.UseVisualStyleBackColor = true;
            this.btnAddEspecialidad.Click += new System.EventHandler(this.btnAddEspecialidad_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 64);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Especialidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Medico";
            // 
            // FrmAddEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAddEspecialidad);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEspecialidad";
            this.Text = "FrmAddEspecialidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAddEspecialidad_Load);
            this.grpAddEspecialidad.ResumeLayout(false);
            this.grpAddEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpAddEspecialidad;
        private System.Windows.Forms.Button btnAddEspecialidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboEspecialidades;
        private System.Windows.Forms.ComboBox cboMedicos;
    }
}