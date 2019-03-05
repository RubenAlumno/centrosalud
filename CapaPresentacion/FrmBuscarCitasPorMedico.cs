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
    public partial class FrmBuscarCitasPorMedico : Form
    {
        public FrmBuscarCitasPorMedico()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir de la busqueda de citas de un Medico?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmBuscarCitasPorMedico_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearCita
            grpBuscarPacienteID.Left = ((this.Width - grpBuscarPacienteID.Width) / 2);
            grpBuscarPacienteID.Top = ((this.Height - grpBuscarPacienteID.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearCita
            grpPacienteDatos.Left = ((this.Width - grpPacienteDatos.Width) / 2);
            grpPacienteDatos.Top = ((this.Height - grpPacienteDatos.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            List<especialista> medicos = Program.gestion.AllEspecialistas();
            if (medicos.Count() <= 0)
            {
                MessageBox.Show("No hay medicos en la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < medicos.Count(); i++)
            {
                cboMedicos.Items.Add(medicos[i].nombre);
            }
            dgvPacientes.Columns.Add("id", "ID Paciente");
            dgvPacientes.Columns.Add("nombrePaciente", "Nombre");
            dgvPacientes.Columns.Add("telefonoPaciente", "Telefono");
            dgvCitas.Columns.Add("fechaPaciente", "Fecha");
            dgvCitas.Columns.Add("horaPaciente", "Hora");
            dgvCitas.Columns.Add("especialidad", "Especialidad");
            dgvCitas.Columns.Add("paciente", "ID Paciente");
        }

        private void btnBuscarCitas_Click(object sender, EventArgs e)
        {
            if (cboMedicos.SelectedItem == null)
            {
                MessageBox.Show("No ha selecionado ningun medico para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                txtNombre.Text = cboMedicos.SelectedItem.ToString();
                DateTime time = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day);
                List<cita> citasMedico = Program.gestion.buscarCitasPorMedico(txtNombre.Text, time);
                if (citasMedico == null)
                {
                    MessageBox.Show("Error en la BD por favor contacte con un Administrador del Programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (citasMedico.Count() <= 0)
                {
                    MessageBox.Show("No hay citas en la BD para este medico, este dia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                List<paciente> pacientes = new List<paciente>();
                Boolean correcto;
                correcto = true;
                for (int i = 0; i < citasMedico.Count(); i++)
                {
                    paciente paciente = Program.gestion.buscarDatosPaciente(citasMedico[i].idpaciente.ToString());
                    if (citasMedico == null)
                    {
                        correcto = false;
                        break;
                    }
                    Boolean valorTrue = false;
                    for (int j = 0; j < pacientes.Count(); j++)
                    {
                        if (pacientes[j].id == paciente.id)
                        {
                            valorTrue = true;
                            break;
                        }
                    }
                    if (valorTrue == false)
                    {
                        pacientes.Add(paciente);
                    }
                }
                if (correcto == false)
                {
                    MessageBox.Show("Error en la BD por favor contacte con un Administrador del Programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (pacientes.Count() <= 0)
                {
                    MessageBox.Show("No hay pacientes este dia para este medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvCitas.Rows.Clear();
                for (int i = 0; i < citasMedico.Count(); i++)
                {
                    String fecha = citasMedico[i].fecha.Day.ToString() + "/" + citasMedico[i].fecha.Month.ToString() + "/" + citasMedico[i].fecha.Year.ToString();
                    dgvCitas.Rows.Add(fecha, citasMedico[i].hora.ToString(),citasMedico[i].especialistashacenespecialidade.especialidad.nombre, citasMedico[i].idpaciente.ToString());
                }

                dgvPacientes.Rows.Clear();
                for (int i = 0; i < pacientes.Count(); i++)
                {
                    dgvPacientes.Rows.Add(pacientes[i].id.ToString(), pacientes[i].nombreCompleto, pacientes[i].telefono);
                }
                grpPacienteDatos.Visible = true;
                grpBuscarPacienteID.Visible = false;
            }
        }

        private void btnRebuscar_Click(object sender, EventArgs e)
        {
            grpPacienteDatos.Visible = false;
            grpBuscarPacienteID.Visible = true;
        }
    }
}
