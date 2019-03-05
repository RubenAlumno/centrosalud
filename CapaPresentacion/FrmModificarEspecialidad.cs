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
    public partial class FrmModificarEspecialidad : Form
    {
        public FrmModificarEspecialidad()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario modificar Especialidad?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmModificarEspecialidad_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpCrearCita
            grpModificarEspecialidad.Left = ((this.Width - grpModificarEspecialidad.Width) / 2);
            grpModificarEspecialidad.Top = ((this.Height - grpModificarEspecialidad.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            List<especialidad> especialidades = Program.gestion.AllEspecialidades();
            if (especialidades.Count() <= 0)
            {
                MessageBox.Show("No hay especialidades en la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < especialidades.Count(); i++)
            {
                cboEspecialidades.Items.Add(especialidades[i].nombre);
            }
        }
        public especialidad especialidadElegida;
        private void btnModificarEspecialidad_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == especialidadElegida.nombre)
            {
                MessageBox.Show("No ha modificado nada en esta especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult result = MessageBox.Show("¿Desea modificarlo o quiere salir de este formulario?", "Volver al menú o seguir aquí", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                especialidadElegida.nombre = txtTelefono.Text;
                string mensaje = Program.gestion.updateEspecialidad(especialidadElegida);
                if (String.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show("Especialidad modificada con exicto");
                    DialogResult result = MessageBox.Show("¿Desea modificar otra especialidad si o no?", "Volver al menú", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        List<especialidad> especialidades = Program.gestion.AllEspecialidades();
                        if (especialidades.Count() <= 0)
                        {
                            MessageBox.Show("No hay especialidades en la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        cboEspecialidades.Items.Clear();
                        for (int i = 0; i < especialidades.Count(); i++)
                        {
                            cboEspecialidades.Items.Add(especialidades[i].nombre);
                        }
                        txtTelefono.Text = "";
                        lblTelefono.Visible = false;
                        txtTelefono.Visible = false;
                        btnModificarEspecialidad.Visible = false;
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
            if (cboEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione una especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            especialidadElegida = Program.gestion.buscarEspecialidadPorNombre(cboEspecialidades.SelectedItem.ToString());
            txtTelefono.Text = especialidadElegida.nombre;
            lblTelefono.Visible = true;
            txtTelefono.Visible = true;
            btnModificarEspecialidad.Visible = true;
        }
    }
}
