using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCrearCita : Form
    {
        public FrmCrearCita()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir de la Aplicación?", "Salir de la Aplicación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario crear Cita?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmCrearCita_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearCita
            grpCrearCita.Left = ((this.Width - grpCrearCita.Width) / 2);
            grpCrearCita.Top = ((this.Height - grpCrearCita.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            List<especialidad> especialidades = Program.gestion.AllEspecialidades();
            if (especialidades.Count() <= 0)
            {
                MessageBox.Show("No hay especialidades en la BD, por favor cree una especialidad para usar este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < especialidades.Count(); i++)
            {
                cboEspecialidades.Items.Add(especialidades[i].nombre);
            }
            List<paciente> pacientes = Program.gestion.AllPacientes();
            if (pacientes.Count() <= 0)
            {
                MessageBox.Show("No hay pacientes en la BD, por favor cree una especialidad para usar este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < pacientes.Count(); i++)
            {
                cboPacientes.Items.Add(pacientes[i].nombreCompleto);
            }
            dtpFecha.MinDate = DateTime.Today; //Esto hace que el dia minimo se hoy
        }

        private void cboEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione una especialidad","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            especialidad especialidadElegida = Program.gestion.buscarEspecialidadPorNombre(cboEspecialidades.SelectedItem.ToString());
            List<String> medicos = Program.gestion.buscarMedicos(especialidadElegida);
            if (medicos.Count() <= 0)
            {
                cboMedicos.Visible = false;
                lblMedico.Visible = false;
                lblFecha.Visible = false;
                dtpFecha.Visible = false;
                lblHora.Visible = false;
                dtpHora.Visible = false;
                btnCrearCita.Visible = false;
                MessageBox.Show("No hay medicos en esta especialidad","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cboMedicos.Items.Clear();
                for (int i = 0; i < medicos.Count(); i++)
                {
                    cboMedicos.Items.Add(medicos[i]);
                }
                cboMedicos.Visible = true;
                lblMedico.Visible = true;
                lblFecha.Visible = true;
                dtpFecha.Visible = true;
                lblHora.Visible = true;
                dtpHora.Visible = true;
            }
        }

        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day);
            int idMedico = Program.gestion.buscarIdMedico(cboMedicos.SelectedItem.ToString());
            int idEspecialidad = Program.gestion.buscarIdEspecialidad(cboEspecialidades.SelectedItem.ToString());
            int idPaciente = Program.gestion.buscarIdPaciente(cboPacientes.SelectedItem.ToString());
            TimeSpan horaTime = new TimeSpan(dtpHora.Value.Hour, dtpHora.Value.Minute, dtpHora.Value.Second);
            String mensaje = Program.gestion.comprobarFecha(time, idMedico, horaTime);
            if (String.IsNullOrWhiteSpace(mensaje))
            {
                especialistashacenespecialidade medico = Program.gestion.buscarEspecialitasHacenEspecialidadesPorID(idMedico,idEspecialidad);
                cita nueva = new cita(idPaciente, medico, horaTime, time);
                String respuesta = Program.gestion.addCita(nueva);
                if (string.IsNullOrWhiteSpace(respuesta))
                {
                    MessageBox.Show("Cita agregada con exicto");
                    DialogResult result = MessageBox.Show("¿Desea añadir otro cita si o no?", "Volver al menú", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        cboMedicos.Visible = false;
                        lblMedico.Visible = false;
                        lblFecha.Visible = false;
                        dtpFecha.Visible = false;
                        lblHora.Visible = false;
                        dtpHora.Visible = false;
                        btnCrearCita.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCrearCita.Visible = true;
        }

        private void cboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedItem == null)
            {
                cboMedicos.Visible = false;
                lblMedico.Visible = false;
                lblFecha.Visible = false;
                dtpFecha.Visible = false;
                lblHora.Visible = false;
                dtpHora.Visible = false;
                btnCrearCita.Visible = false;
                cboEspecialidades.Visible = false;
                lblEspecialidad.Visible = false;
                return;
            }
            cboEspecialidades.Visible = true;
            lblEspecialidad.Visible = true;
        }
    }
}
