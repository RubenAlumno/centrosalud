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
    public partial class FrmModificarMedico : Form
    {
        public FrmModificarMedico()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario modificar Medico?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmModificarMedico_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearCita
            grpModificarMedico.Left = ((this.Width - grpModificarMedico.Width) / 2);
            grpModificarMedico.Top = ((this.Height - grpModificarMedico.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            List<especialista> especialistas = Program.gestion.AllEspecialistas();
            if (especialistas.Count() <= 0)
            {
                MessageBox.Show("No hay medicos en la BD, por favor cree un medico para usar este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < especialistas.Count(); i++)
            {
                cboMedicos.Items.Add(especialistas[i].nombre);
            }
        }
        public especialista especialistaElegido;
        private void btnModificarMedico_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == especialistaElegido.telefono)
            {
                MessageBox.Show("No ha modificado nada en este medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult result = MessageBox.Show("¿Desea modificarlo o quiere salir de este formulario?", "Volver al menú o seguir aquí", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                especialistaElegido.telefono = txtTelefono.Text;
                string mensaje = Program.gestion.updateEspecialista(especialistaElegido);
                if (String.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show("Medico modificado con exicto");
                    DialogResult result = MessageBox.Show("¿Desea modificar otro medico si o no?", "Volver al menú", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        txtTelefono.Text = "";
                        lblTelefono.Visible = false;
                        txtTelefono.Visible = false;
                        btnModificarMedico.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void cboMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedicos.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione un medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            especialistaElegido = Program.gestion.buscarMedicoPorNombre(cboMedicos.SelectedItem.ToString());
            txtTelefono.Text = especialistaElegido.telefono;
            lblTelefono.Visible = true;
            txtTelefono.Visible = true;
            btnModificarMedico.Visible = true;
        }
    }
}
