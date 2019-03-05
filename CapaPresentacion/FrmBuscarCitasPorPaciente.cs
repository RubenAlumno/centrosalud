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
    public partial class FrmBuscarCitasPorPaciente : Form
    {
        public FrmBuscarCitasPorPaciente()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir de la busqueda de citas de un Paciente?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmBuscarCitasPorPaciente_Load(object sender, EventArgs e)
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
            List<paciente> pacientes = Program.gestion.AllPacientes();
            if (pacientes.Count() <= 0)
            {
                MessageBox.Show("No hay pacientes en la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < pacientes.Count(); i++)
            {
                cboPacientes.Items.Add(pacientes[i].nombreCompleto);
            }
            dgvMedicos.Columns.Add("id", "ID Medico");
            dgvMedicos.Columns.Add("nombreMedico", "Nombre");
            dgvMedicos.Columns.Add("telefonoMedico", "Telefono");
            dgvCitas.Columns.Add("fechaPaciente", "Fecha");
            dgvCitas.Columns.Add("horaPaciente", "Hora");
            dgvCitas.Columns.Add("medico", "ID Medico");
        }

        private void btnBuscarCitas_Click(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedItem == null)
            {
                MessageBox.Show("No ha selecionado ningun paciente para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                txtNombre.Text = cboPacientes.SelectedItem.ToString();
                List<cita> citasPaciente = Program.gestion.buscarCitasPorPaciente(txtNombre.Text);
                if(citasPaciente == null)
                {
                    MessageBox.Show("Error en la BD por favor contacte con un Administrador del Programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (citasPaciente.Count() <= 0)
                {
                    MessageBox.Show("No hay citas en la BD para este paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                List<especialista> medicos = new List<especialista>();
                Boolean correcto;
                correcto = true;
                for (int i = 0; i < citasPaciente.Count(); i++)
                {
                    especialista especialista = Program.gestion.buscarDatosMedico(citasPaciente[i].especialistashacenespecialidade.idespecialista.ToString());
                    if (citasPaciente == null)
                    {
                        correcto = false;
                        break;
                    }
                    Boolean valorTrue = false;
                    for (int j = 0; j < medicos.Count(); j++)
                    {
                        if (medicos[j].id == especialista.id)
                        {
                            valorTrue = true;
                            break;
                        }
                    }
                    if (valorTrue == false)
                    {
                        medicos.Add(especialista);
                    }       
                }
                if (correcto == false)
                {
                    MessageBox.Show("Error en la BD por favor contacte con un Administrador del Programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (medicos.Count() <= 0)
                {
                    MessageBox.Show("Los medicos de este paciente han sido borrados misteriosamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                dgvCitas.Rows.Clear();
                for (int i = 0; i < citasPaciente.Count(); i++)
                {
                    String fecha = citasPaciente[i].fecha.Day.ToString()+"/"+ citasPaciente[i].fecha.Month.ToString()+"/"+ citasPaciente[i].fecha.Year.ToString();
                    dgvCitas.Rows.Add(fecha, citasPaciente[i].hora.ToString(), citasPaciente[i].especialistashacenespecialidade.idespecialista.ToString());
                }
                
                dgvMedicos.Rows.Clear();
                for (int i = 0; i < medicos.Count(); i++)
                {
                    dgvMedicos.Rows.Add(medicos[i].id.ToString(), medicos[i].nombre, medicos[i].telefono);
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
