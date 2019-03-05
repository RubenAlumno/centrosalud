namespace CapaPresentacion
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenuCrearPaciente = new System.Windows.Forms.Button();
            this.btnMenuModificarPaciente = new System.Windows.Forms.Button();
            this.grpMenuPacientes = new System.Windows.Forms.GroupBox();
            this.btnMenuBuscarPacienteId = new System.Windows.Forms.Button();
            this.btnMenuBuscarPacienteNombre = new System.Windows.Forms.Button();
            this.grpMenuEspecialidades = new System.Windows.Forms.GroupBox();
            this.btnMenuAñadirEspecialidad = new System.Windows.Forms.Button();
            this.btnMenuCrearEspecialidad = new System.Windows.Forms.Button();
            this.grpMenuMedico = new System.Windows.Forms.GroupBox();
            this.btnMenuBuscarMedicoId = new System.Windows.Forms.Button();
            this.btnMenuBuscarMedicoNombre = new System.Windows.Forms.Button();
            this.btnMenuCrearMedico = new System.Windows.Forms.Button();
            this.btnMenuModificarMedico = new System.Windows.Forms.Button();
            this.grpMenuCitas = new System.Windows.Forms.GroupBox();
            this.btnMenuBuscarCitaMedico = new System.Windows.Forms.Button();
            this.btnMenuBuscarCitaPaciente = new System.Windows.Forms.Button();
            this.btnMenuCrearCita = new System.Windows.Forms.Button();
            this.btnMenuEliminarCita = new System.Windows.Forms.Button();
            this.btnMenuModificarEspecialidad = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpMenuPacientes.SuspendLayout();
            this.grpMenuEspecialidades.SuspendLayout();
            this.grpMenuMedico.SuspendLayout();
            this.grpMenuCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuCrearPaciente
            // 
            this.btnMenuCrearPaciente.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuCrearPaciente.Location = new System.Drawing.Point(6, 28);
            this.btnMenuCrearPaciente.Name = "btnMenuCrearPaciente";
            this.btnMenuCrearPaciente.Size = new System.Drawing.Size(186, 35);
            this.btnMenuCrearPaciente.TabIndex = 0;
            this.btnMenuCrearPaciente.Text = "Crear Paciente";
            this.btnMenuCrearPaciente.UseVisualStyleBackColor = false;
            this.btnMenuCrearPaciente.Click += new System.EventHandler(this.btnMenuCrearPaciente_Click);
            // 
            // btnMenuModificarPaciente
            // 
            this.btnMenuModificarPaciente.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuModificarPaciente.Location = new System.Drawing.Point(6, 69);
            this.btnMenuModificarPaciente.Name = "btnMenuModificarPaciente";
            this.btnMenuModificarPaciente.Size = new System.Drawing.Size(186, 35);
            this.btnMenuModificarPaciente.TabIndex = 1;
            this.btnMenuModificarPaciente.Text = "Modificar Paciente";
            this.btnMenuModificarPaciente.UseVisualStyleBackColor = false;
            this.btnMenuModificarPaciente.Click += new System.EventHandler(this.btnMenuModificarPaciente_Click);
            // 
            // grpMenuPacientes
            // 
            this.grpMenuPacientes.Controls.Add(this.btnMenuBuscarPacienteId);
            this.grpMenuPacientes.Controls.Add(this.btnMenuBuscarPacienteNombre);
            this.grpMenuPacientes.Controls.Add(this.btnMenuCrearPaciente);
            this.grpMenuPacientes.Controls.Add(this.btnMenuModificarPaciente);
            this.grpMenuPacientes.Location = new System.Drawing.Point(28, 44);
            this.grpMenuPacientes.Name = "grpMenuPacientes";
            this.grpMenuPacientes.Size = new System.Drawing.Size(203, 205);
            this.grpMenuPacientes.TabIndex = 2;
            this.grpMenuPacientes.TabStop = false;
            this.grpMenuPacientes.Text = "Pacientes";
            // 
            // btnMenuBuscarPacienteId
            // 
            this.btnMenuBuscarPacienteId.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuBuscarPacienteId.Location = new System.Drawing.Point(6, 112);
            this.btnMenuBuscarPacienteId.Name = "btnMenuBuscarPacienteId";
            this.btnMenuBuscarPacienteId.Size = new System.Drawing.Size(186, 35);
            this.btnMenuBuscarPacienteId.TabIndex = 3;
            this.btnMenuBuscarPacienteId.Text = "Buscar Paciente por id";
            this.btnMenuBuscarPacienteId.UseVisualStyleBackColor = false;
            this.btnMenuBuscarPacienteId.Click += new System.EventHandler(this.btnMenuBuscarPacienteId_Click);
            // 
            // btnMenuBuscarPacienteNombre
            // 
            this.btnMenuBuscarPacienteNombre.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuBuscarPacienteNombre.Location = new System.Drawing.Point(6, 153);
            this.btnMenuBuscarPacienteNombre.Name = "btnMenuBuscarPacienteNombre";
            this.btnMenuBuscarPacienteNombre.Size = new System.Drawing.Size(186, 35);
            this.btnMenuBuscarPacienteNombre.TabIndex = 2;
            this.btnMenuBuscarPacienteNombre.Text = "Buscar Paciente por Nombre";
            this.btnMenuBuscarPacienteNombre.UseVisualStyleBackColor = false;
            this.btnMenuBuscarPacienteNombre.Click += new System.EventHandler(this.btnMenuBuscarPacienteNombre_Click);
            // 
            // grpMenuEspecialidades
            // 
            this.grpMenuEspecialidades.Controls.Add(this.btnMenuModificarEspecialidad);
            this.grpMenuEspecialidades.Controls.Add(this.btnMenuAñadirEspecialidad);
            this.grpMenuEspecialidades.Controls.Add(this.btnMenuCrearEspecialidad);
            this.grpMenuEspecialidades.Location = new System.Drawing.Point(487, 44);
            this.grpMenuEspecialidades.Name = "grpMenuEspecialidades";
            this.grpMenuEspecialidades.Size = new System.Drawing.Size(203, 205);
            this.grpMenuEspecialidades.TabIndex = 4;
            this.grpMenuEspecialidades.TabStop = false;
            this.grpMenuEspecialidades.Text = "Especialidades";
            // 
            // btnMenuAñadirEspecialidad
            // 
            this.btnMenuAñadirEspecialidad.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuAñadirEspecialidad.Location = new System.Drawing.Point(6, 110);
            this.btnMenuAñadirEspecialidad.Name = "btnMenuAñadirEspecialidad";
            this.btnMenuAñadirEspecialidad.Size = new System.Drawing.Size(186, 35);
            this.btnMenuAñadirEspecialidad.TabIndex = 4;
            this.btnMenuAñadirEspecialidad.Text = "Añadir una Especialidad a un Medico";
            this.btnMenuAñadirEspecialidad.UseVisualStyleBackColor = false;
            this.btnMenuAñadirEspecialidad.Click += new System.EventHandler(this.btnMenuAñadirEspecialidad_Click);
            // 
            // btnMenuCrearEspecialidad
            // 
            this.btnMenuCrearEspecialidad.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuCrearEspecialidad.Location = new System.Drawing.Point(6, 28);
            this.btnMenuCrearEspecialidad.Name = "btnMenuCrearEspecialidad";
            this.btnMenuCrearEspecialidad.Size = new System.Drawing.Size(186, 35);
            this.btnMenuCrearEspecialidad.TabIndex = 0;
            this.btnMenuCrearEspecialidad.Text = "Crear Especialidad";
            this.btnMenuCrearEspecialidad.UseVisualStyleBackColor = false;
            this.btnMenuCrearEspecialidad.Click += new System.EventHandler(this.btnMenuCrearEspecialidad_Click);
            // 
            // grpMenuMedico
            // 
            this.grpMenuMedico.Controls.Add(this.btnMenuBuscarMedicoId);
            this.grpMenuMedico.Controls.Add(this.btnMenuBuscarMedicoNombre);
            this.grpMenuMedico.Controls.Add(this.btnMenuCrearMedico);
            this.grpMenuMedico.Controls.Add(this.btnMenuModificarMedico);
            this.grpMenuMedico.Location = new System.Drawing.Point(262, 44);
            this.grpMenuMedico.Name = "grpMenuMedico";
            this.grpMenuMedico.Size = new System.Drawing.Size(203, 205);
            this.grpMenuMedico.TabIndex = 4;
            this.grpMenuMedico.TabStop = false;
            this.grpMenuMedico.Text = "Medicos";
            // 
            // btnMenuBuscarMedicoId
            // 
            this.btnMenuBuscarMedicoId.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuBuscarMedicoId.Location = new System.Drawing.Point(6, 112);
            this.btnMenuBuscarMedicoId.Name = "btnMenuBuscarMedicoId";
            this.btnMenuBuscarMedicoId.Size = new System.Drawing.Size(186, 35);
            this.btnMenuBuscarMedicoId.TabIndex = 3;
            this.btnMenuBuscarMedicoId.Text = "Buscar Medico por id";
            this.btnMenuBuscarMedicoId.UseVisualStyleBackColor = false;
            this.btnMenuBuscarMedicoId.Click += new System.EventHandler(this.btnMenuBuscarMedicoId_Click);
            // 
            // btnMenuBuscarMedicoNombre
            // 
            this.btnMenuBuscarMedicoNombre.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuBuscarMedicoNombre.Location = new System.Drawing.Point(6, 153);
            this.btnMenuBuscarMedicoNombre.Name = "btnMenuBuscarMedicoNombre";
            this.btnMenuBuscarMedicoNombre.Size = new System.Drawing.Size(186, 35);
            this.btnMenuBuscarMedicoNombre.TabIndex = 2;
            this.btnMenuBuscarMedicoNombre.Text = "Buscar Medico por Nombre";
            this.btnMenuBuscarMedicoNombre.UseVisualStyleBackColor = false;
            this.btnMenuBuscarMedicoNombre.Click += new System.EventHandler(this.btnMenuBuscarMedicoNombre_Click);
            // 
            // btnMenuCrearMedico
            // 
            this.btnMenuCrearMedico.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuCrearMedico.Location = new System.Drawing.Point(6, 28);
            this.btnMenuCrearMedico.Name = "btnMenuCrearMedico";
            this.btnMenuCrearMedico.Size = new System.Drawing.Size(186, 35);
            this.btnMenuCrearMedico.TabIndex = 0;
            this.btnMenuCrearMedico.Text = "Crear Medico";
            this.btnMenuCrearMedico.UseVisualStyleBackColor = false;
            this.btnMenuCrearMedico.Click += new System.EventHandler(this.btnMenuCrearMedico_Click);
            // 
            // btnMenuModificarMedico
            // 
            this.btnMenuModificarMedico.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuModificarMedico.Location = new System.Drawing.Point(6, 69);
            this.btnMenuModificarMedico.Name = "btnMenuModificarMedico";
            this.btnMenuModificarMedico.Size = new System.Drawing.Size(186, 35);
            this.btnMenuModificarMedico.TabIndex = 1;
            this.btnMenuModificarMedico.Text = "Modificar Medico";
            this.btnMenuModificarMedico.UseVisualStyleBackColor = false;
            this.btnMenuModificarMedico.Click += new System.EventHandler(this.btnMenuModificarMedico_Click);
            // 
            // grpMenuCitas
            // 
            this.grpMenuCitas.Controls.Add(this.btnMenuEliminarCita);
            this.grpMenuCitas.Controls.Add(this.btnMenuBuscarCitaMedico);
            this.grpMenuCitas.Controls.Add(this.btnMenuBuscarCitaPaciente);
            this.grpMenuCitas.Controls.Add(this.btnMenuCrearCita);
            this.grpMenuCitas.Location = new System.Drawing.Point(696, 44);
            this.grpMenuCitas.Name = "grpMenuCitas";
            this.grpMenuCitas.Size = new System.Drawing.Size(203, 205);
            this.grpMenuCitas.TabIndex = 5;
            this.grpMenuCitas.TabStop = false;
            this.grpMenuCitas.Text = "Citas";
            // 
            // btnMenuBuscarCitaMedico
            // 
            this.btnMenuBuscarCitaMedico.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuBuscarCitaMedico.Location = new System.Drawing.Point(6, 153);
            this.btnMenuBuscarCitaMedico.Name = "btnMenuBuscarCitaMedico";
            this.btnMenuBuscarCitaMedico.Size = new System.Drawing.Size(186, 35);
            this.btnMenuBuscarCitaMedico.TabIndex = 5;
            this.btnMenuBuscarCitaMedico.Text = "Buscar citas por Medicos";
            this.btnMenuBuscarCitaMedico.UseVisualStyleBackColor = false;
            this.btnMenuBuscarCitaMedico.Click += new System.EventHandler(this.btnMenuBuscarCitaMedico_Click);
            // 
            // btnMenuBuscarCitaPaciente
            // 
            this.btnMenuBuscarCitaPaciente.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuBuscarCitaPaciente.Location = new System.Drawing.Point(6, 112);
            this.btnMenuBuscarCitaPaciente.Name = "btnMenuBuscarCitaPaciente";
            this.btnMenuBuscarCitaPaciente.Size = new System.Drawing.Size(186, 35);
            this.btnMenuBuscarCitaPaciente.TabIndex = 3;
            this.btnMenuBuscarCitaPaciente.Text = "Buscar citas por Paciente";
            this.btnMenuBuscarCitaPaciente.UseVisualStyleBackColor = false;
            this.btnMenuBuscarCitaPaciente.Click += new System.EventHandler(this.btnMenuBuscarCitaPaciente_Click);
            // 
            // btnMenuCrearCita
            // 
            this.btnMenuCrearCita.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuCrearCita.Location = new System.Drawing.Point(6, 28);
            this.btnMenuCrearCita.Name = "btnMenuCrearCita";
            this.btnMenuCrearCita.Size = new System.Drawing.Size(186, 35);
            this.btnMenuCrearCita.TabIndex = 0;
            this.btnMenuCrearCita.Text = "Crear Cita";
            this.btnMenuCrearCita.UseVisualStyleBackColor = false;
            this.btnMenuCrearCita.Click += new System.EventHandler(this.btnMenuCrearCita_Click);
            // 
            // btnMenuEliminarCita
            // 
            this.btnMenuEliminarCita.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuEliminarCita.Location = new System.Drawing.Point(6, 69);
            this.btnMenuEliminarCita.Name = "btnMenuEliminarCita";
            this.btnMenuEliminarCita.Size = new System.Drawing.Size(186, 35);
            this.btnMenuEliminarCita.TabIndex = 6;
            this.btnMenuEliminarCita.Text = "Eliminar Cita";
            this.btnMenuEliminarCita.UseVisualStyleBackColor = false;
            this.btnMenuEliminarCita.Click += new System.EventHandler(this.btnMenuEliminarCita_Click);
            // 
            // btnMenuModificarEspecialidad
            // 
            this.btnMenuModificarEspecialidad.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMenuModificarEspecialidad.Location = new System.Drawing.Point(6, 69);
            this.btnMenuModificarEspecialidad.Name = "btnMenuModificarEspecialidad";
            this.btnMenuModificarEspecialidad.Size = new System.Drawing.Size(186, 35);
            this.btnMenuModificarEspecialidad.TabIndex = 5;
            this.btnMenuModificarEspecialidad.Text = "Modificar Especialidad";
            this.btnMenuModificarEspecialidad.UseVisualStyleBackColor = false;
            this.btnMenuModificarEspecialidad.Click += new System.EventHandler(this.btnMenuModificarEspecialidad_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMinimizar.Location = new System.Drawing.Point(28, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 11;
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
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "CENTRO SALUD SOTWARE CON ENTITY FRAMEWORK Y MYSQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Versión del Software: 1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Creado por: Rubén Castañeda Matute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Página web:  https://rubencm.tk";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpMenuCitas);
            this.Controls.Add(this.grpMenuMedico);
            this.Controls.Add(this.grpMenuEspecialidades);
            this.Controls.Add(this.grpMenuPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "Menu Centro Salud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.grpMenuPacientes.ResumeLayout(false);
            this.grpMenuEspecialidades.ResumeLayout(false);
            this.grpMenuMedico.ResumeLayout(false);
            this.grpMenuCitas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuCrearPaciente;
        private System.Windows.Forms.Button btnMenuModificarPaciente;
        private System.Windows.Forms.GroupBox grpMenuPacientes;
        private System.Windows.Forms.Button btnMenuBuscarPacienteId;
        private System.Windows.Forms.Button btnMenuBuscarPacienteNombre;
        private System.Windows.Forms.GroupBox grpMenuEspecialidades;
        private System.Windows.Forms.Button btnMenuAñadirEspecialidad;
        private System.Windows.Forms.Button btnMenuCrearEspecialidad;
        private System.Windows.Forms.GroupBox grpMenuMedico;
        private System.Windows.Forms.Button btnMenuBuscarMedicoId;
        private System.Windows.Forms.Button btnMenuBuscarMedicoNombre;
        private System.Windows.Forms.Button btnMenuCrearMedico;
        private System.Windows.Forms.Button btnMenuModificarMedico;
        private System.Windows.Forms.GroupBox grpMenuCitas;
        private System.Windows.Forms.Button btnMenuBuscarCitaPaciente;
        private System.Windows.Forms.Button btnMenuCrearCita;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMenuBuscarCitaMedico;
        private System.Windows.Forms.Button btnMenuEliminarCita;
        private System.Windows.Forms.Button btnMenuModificarEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

