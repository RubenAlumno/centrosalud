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
    public partial class FrmModificarPaciente : Form
    {
        public FrmModificarPaciente()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario modificar Paciente?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmModificarPaciente_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearCita
            grpModificarPaciente.Left = ((this.Width - grpModificarPaciente.Width) / 2);
            grpModificarPaciente.Top = ((this.Height - grpModificarPaciente.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            List<paciente> pacientes = Program.gestion.AllPacientes();
            if (pacientes.Count() <= 0)
            {
                MessageBox.Show("No hay pacientes en la BD, por favor cree un paciente para usar este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < pacientes.Count(); i++)
            {
                cboPacientes.Items.Add(pacientes[i].nombreCompleto);
            }
        }
        public paciente pacienteElegido;
        private void cboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione un paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            pacienteElegido = Program.gestion.buscarPacientePorNombre(cboPacientes.SelectedItem.ToString());
            txtDireccion.Text = pacienteElegido.direccion;
            txtLocalidad.Text = pacienteElegido.localidad;
            txtTelefono.Text = pacienteElegido.telefono;
            lblDireccion.Visible = true;
            lblLocalidad.Visible = true;
            lblTelefono.Visible = true;
            txtTelefono.Visible = true;
            txtDireccion.Visible = true;
            txtLocalidad.Visible = true;
            btnModificarPaciente.Visible = true;
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            if(txtDireccion.Text == pacienteElegido.direccion && txtLocalidad.Text == pacienteElegido.localidad && txtTelefono.Text == pacienteElegido.telefono)
            {
                MessageBox.Show("No ha modificado nada en este paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult result = MessageBox.Show("¿Desea modificarlo o quiere salir de este formulario?", "Volver al menú o seguir aquí", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                pacienteElegido.direccion = txtDireccion.Text;
                pacienteElegido.localidad = txtLocalidad.Text;
                pacienteElegido.telefono = txtTelefono.Text;
                string mensaje = Program.gestion.updatePaciente(pacienteElegido);
                if (String.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show("Paciente modificado con exicto");
                    DialogResult result = MessageBox.Show("¿Desea modificar otro paciente si o no?", "Volver al menú", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        txtDireccion.Text = "";
                        txtLocalidad.Text = "";
                        txtTelefono.Text = "";
                        lblDireccion.Visible = false;
                        lblLocalidad.Visible = false;
                        lblTelefono.Visible = false;
                        txtTelefono.Visible = false;
                        txtDireccion.Visible = false;
                        txtLocalidad.Visible = false;
                        btnModificarPaciente.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
