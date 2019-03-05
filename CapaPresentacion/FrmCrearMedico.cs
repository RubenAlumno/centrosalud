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
    public partial class FrmCrearMedico : Form
    {
        public FrmCrearMedico()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario crear Medico?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmCrearMedico_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearMedico
            grpCrearMedico.Left = ((this.Width - grpCrearMedico.Width) / 2);
            grpCrearMedico.Top = ((this.Height - grpCrearMedico.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            string mensaje = Program.gestion.addMedico(new especialista(txtNombre.Text, txtTelefono.Text));
            if (String.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show("Medico añadido con exicto");
                DialogResult result = MessageBox.Show("¿Desea añadir otro medico si o no?", "Volver al menú", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
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
