namespace CapaPresentacion
{
    partial class FrmBuscarMedicoPorID
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
            this.grpBuscarMedicoID = new System.Windows.Forms.GroupBox();
            this.btnBuscarMedico = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpMedicoDatos = new System.Windows.Forms.GroupBox();
            this.btnRebuscar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpBuscarMedicoID.SuspendLayout();
            this.grpMedicoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBuscarMedicoID
            // 
            this.grpBuscarMedicoID.Controls.Add(this.btnBuscarMedico);
            this.grpBuscarMedicoID.Controls.Add(this.txtID);
            this.grpBuscarMedicoID.Controls.Add(this.label5);
            this.grpBuscarMedicoID.Location = new System.Drawing.Point(139, 310);
            this.grpBuscarMedicoID.Name = "grpBuscarMedicoID";
            this.grpBuscarMedicoID.Size = new System.Drawing.Size(570, 128);
            this.grpBuscarMedicoID.TabIndex = 34;
            this.grpBuscarMedicoID.TabStop = false;
            this.grpBuscarMedicoID.Text = "Busqueda De Medicos";
            // 
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.Location = new System.Drawing.Point(65, 66);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(333, 36);
            this.btnBuscarMedico.TabIndex = 8;
            this.btnBuscarMedico.Text = "Buscar El Medico";
            this.btnBuscarMedico.UseVisualStyleBackColor = true;
            this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscarMedico_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(169, 30);
            this.txtID.MaxLength = 12;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(341, 20);
            this.txtID.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID";
            // 
            // grpMedicoDatos
            // 
            this.grpMedicoDatos.Controls.Add(this.btnRebuscar);
            this.grpMedicoDatos.Controls.Add(this.txtTelefono);
            this.grpMedicoDatos.Controls.Add(this.lblTelefono);
            this.grpMedicoDatos.Controls.Add(this.txtNombre);
            this.grpMedicoDatos.Controls.Add(this.lblNombre);
            this.grpMedicoDatos.Location = new System.Drawing.Point(139, 60);
            this.grpMedicoDatos.Name = "grpMedicoDatos";
            this.grpMedicoDatos.Size = new System.Drawing.Size(591, 161);
            this.grpMedicoDatos.TabIndex = 33;
            this.grpMedicoDatos.TabStop = false;
            this.grpMedicoDatos.Text = "Busqueda De Medicos";
            this.grpMedicoDatos.Visible = false;
            // 
            // btnRebuscar
            // 
            this.btnRebuscar.Location = new System.Drawing.Point(65, 110);
            this.btnRebuscar.Name = "btnRebuscar";
            this.btnRebuscar.Size = new System.Drawing.Size(333, 36);
            this.btnRebuscar.TabIndex = 34;
            this.btnRebuscar.Text = "Buscar otro medico";
            this.btnRebuscar.UseVisualStyleBackColor = true;
            this.btnRebuscar.Click += new System.EventHandler(this.btnRebuscar_Click);
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 27);
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
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre y Apellidos";
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
            // FrmBuscarMedicoPorID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBuscarMedicoID);
            this.Controls.Add(this.grpMedicoDatos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarMedicoPorID";
            this.Text = "FrmBuscarMedicoPorID";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBuscarMedicoPorID_Load);
            this.grpBuscarMedicoID.ResumeLayout(false);
            this.grpBuscarMedicoID.PerformLayout();
            this.grpMedicoDatos.ResumeLayout(false);
            this.grpMedicoDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscarMedicoID;
        private System.Windows.Forms.Button btnBuscarMedico;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpMedicoDatos;
        private System.Windows.Forms.Button btnRebuscar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
    }
}