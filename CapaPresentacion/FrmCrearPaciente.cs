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
    public partial class FrmCrearPaciente : Form
    {
        public FrmCrearPaciente()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario crear Paciente?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmCrearPaciente_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearPaciente
            grpCrearPaciente.Left = ((this.Width - grpCrearPaciente.Width) / 2);
            grpCrearPaciente.Top = ((this.Height - grpCrearPaciente.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            string mensaje = Program.gestion.addPaciente(new paciente(txtNombre.Text,txtTelefono.Text,txtDireccion.Text,txtLocalidad.Text));
            if (String.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show("Paciente añadido con exicto");
                DialogResult result = MessageBox.Show("¿Desea añadir otro paciente si o no?", "Volver al menú", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtDireccion.Text = "";
                    txtLocalidad.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                }
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
