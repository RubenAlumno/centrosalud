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
    public partial class FrmBuscarPacientePorID : Form
    {
        public FrmBuscarPacientePorID()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del busqueda de Paciente por ID?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmBuscarPacientePorID_Load(object sender, EventArgs e)
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
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("No ha puesto ninguna ID para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string mensaje = Program.gestion.buscarPacientoPorID(txtID.Text);
                if (String.IsNullOrWhiteSpace(mensaje))
                {
                    paciente pacienteBuscado = Program.gestion.encontradoPacientoPorID(txtID.Text);
                    txtID.Text = "";
                    txtLocalidad.Text = pacienteBuscado.localidad;
                    txtNombre.Text = pacienteBuscado.nombreCompleto;
                    txtTelefono.Text = pacienteBuscado.telefono;
                    txtDireccion.Text = pacienteBuscado.direccion;
                    grpPacienteDatos.Visible = true;
                    grpBuscarPacienteID.Visible = false;
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRebuscar_Click(object sender, EventArgs e)
        {
            txtLocalidad.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            grpPacienteDatos.Visible = false;
            grpBuscarPacienteID.Visible = true;
        }
    }
}
