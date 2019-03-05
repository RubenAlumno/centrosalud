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
    public partial class FrmAddEspecialidad : Form
    {
        public FrmAddEspecialidad()
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario añadir especialidad a otro paciente?", "Volver al menú", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmAddEspecialidad_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpAddEspecialidad
            grpAddEspecialidad.Left = ((this.Width - grpAddEspecialidad.Width) / 2);
            grpAddEspecialidad.Top = ((this.Height - grpAddEspecialidad.Height) / 2);
            //------------------------------------------------------------------------------------------------------------------------------------------
            List<especialista> medicos = Program.gestion.AllEspecialistas();
            if (medicos.Count() <= 0)
            {
                MessageBox.Show("No hay medicos en la BD, por favor cree medicos para usar este formulario","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < medicos.Count(); i++)
            {
                cboMedicos.Items.Add(medicos[i].nombre);
            }
            List<especialidad> especialidades = Program.gestion.AllEspecialidades();
            if (especialidades.Count() <= 0)
            {
                MessageBox.Show("No hay especialidades en la BD, por favor cree una especialidad para usar este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < especialidades.Count(); i++)
            {
                cboEspecialidades.Items.Add(especialidades[i].nombre);
            }
        }

        private void btnAddEspecialidad_Click(object sender, EventArgs e)
        {
            if (cboMedicos.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione un medico","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione una especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            especialista medico = Program.gestion.selectMedicoID(cboMedicos.SelectedItem.ToString());
            especialidad especialidad = Program.gestion.selectEspecialidadID(cboEspecialidades.SelectedItem.ToString());
            // todo: queda pendiente
            string mensaje = Program.gestion.addEspecialidadMedico(new especialistashacenespecialidade(especialidad, medico));
            if (String.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show("Especialidad añadida al medico con exicto");
                DialogResult result = MessageBox.Show("¿Desea añadir otra especialidad a algún medico si o no?", "Volver al menú", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
