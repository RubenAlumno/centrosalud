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
    public partial class FrmBuscarPacientePorNombre : Form
    {
        public FrmBuscarPacientePorNombre()
        {
            InitializeComponent();
        }

        private void FrmBuscarPacientePorNombre_Load(object sender, EventArgs e)
        {
            //grpBuscarPacienteID
            grpBuscarPacienteID.Left = ((this.Width - grpBuscarPacienteID.Width) / 2);
            grpBuscarPacienteID.Top = ((this.Height - grpBuscarPacienteID.Height) / 2);
            //grpPacienteDatos
            grpPacienteDatos.Left = ((this.Width - grpPacienteDatos.Width) / 2);
            grpPacienteDatos.Top = ((this.Height - grpPacienteDatos.Height) / 2);
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del busqueda de Paciente por Nombre?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("No ha puesto ninguna ID para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string mensaje = Program.gestion.buscarPacientoPorNombre(txtNombre.Text);
                if (String.IsNullOrWhiteSpace(mensaje))
                {
                    paciente pacienteBuscado = Program.gestion.encontradoPacientoPorNombre(txtNombre.Text);
                    txtNombre.Text = "";
                    txtLocalidad.Text = pacienteBuscado.localidad;
                    txtID.Text = pacienteBuscado.id.ToString();
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
    }
}
