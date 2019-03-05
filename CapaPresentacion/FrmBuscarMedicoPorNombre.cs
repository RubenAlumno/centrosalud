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
    public partial class FrmBuscarMedicoPorNombre : Form
    {
        public FrmBuscarMedicoPorNombre()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del busqueda de Medico por Nombre?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmBuscarMedicoPorNombre_Load(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------------------------------------------------------------------------
            //grpBuscarMedicoID
            grpBuscarMedicoID.Left = ((this.Width - grpBuscarMedicoID.Width) / 2);
            grpBuscarMedicoID.Top = ((this.Height - grpBuscarMedicoID.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpMedicoDatos
            grpMedicoDatos.Left = ((this.Width - grpMedicoDatos.Width) / 2);
            grpMedicoDatos.Top = ((this.Height - grpMedicoDatos.Height) / 2);
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("No ha puesto ninguna nombre para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string mensaje = Program.gestion.buscarMedicoPorNombreBuscador(txtNombre.Text);
                if (String.IsNullOrWhiteSpace(mensaje))
                {
                    especialista especialistaBuscado = Program.gestion.encontradoMedicoPorNombre(txtNombre.Text);
                    txtNombre.Text = "";
                    txtID.Text = especialistaBuscado.id.ToString();
                    txtTelefono.Text = especialistaBuscado.telefono;
                    grpMedicoDatos.Visible = true;
                    grpBuscarMedicoID.Visible = false;
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRebuscar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTelefono.Text = "";
            grpMedicoDatos.Visible = false;
            grpBuscarMedicoID.Visible = true;
        }
    }
}
