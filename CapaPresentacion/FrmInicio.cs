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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
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

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //GrpPacientes
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpMenuPacientes
            grpMenuPacientes.Left = ((this.Width - grpMenuPacientes.Width) / 2) -440;
            grpMenuPacientes.Top = ((this.Height - grpMenuPacientes.Height) / 2) - 50;
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpMenuMedico
            grpMenuMedico.Left = ((this.Width - grpMenuMedico.Width) / 2 - 220);
            grpMenuMedico.Top = ((this.Height - grpMenuMedico.Height) / 2) - 50;
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpMenuEspecialidades
            grpMenuEspecialidades.Left = ((this.Width - grpMenuEspecialidades.Width) / 2);
            grpMenuEspecialidades.Top = ((this.Height - grpMenuEspecialidades.Height) / 2) - 50;
            //------------------------------------------------------------------------------------------------------------------------------------------
            //grpMenuCitas
            grpMenuCitas.Left = ((this.Width - grpMenuCitas.Width) / 2) + 220;
            grpMenuCitas.Top = ((this.Height - grpMenuCitas.Height) / 2) - 50;
            //------------------------------------------------------------------------------------------------------------------------------------------
        }

        private void btnMenuCrearPaciente_Click(object sender, EventArgs e)
        {
            FrmCrearPaciente frmCrearPaciente = new FrmCrearPaciente();
            frmCrearPaciente.ShowDialog();
        }

        private void btnMenuCrearMedico_Click(object sender, EventArgs e)
        {
            FrmCrearMedico frmCrearMedico = new FrmCrearMedico();
            frmCrearMedico.ShowDialog();
        }

        private void btnMenuCrearEspecialidad_Click(object sender, EventArgs e)
        {
            FrmCrearEspecialidad frmCrearEspecialidad = new FrmCrearEspecialidad();
            frmCrearEspecialidad.ShowDialog();
        }

        private void btnMenuAñadirEspecialidad_Click(object sender, EventArgs e)
        {
            FrmAddEspecialidad frmAddEspecialidad = new FrmAddEspecialidad();
            frmAddEspecialidad.ShowDialog();
        }

        private void btnMenuCrearCita_Click(object sender, EventArgs e)
        {
            FrmCrearCita frmCrearCita = new FrmCrearCita();
            frmCrearCita.ShowDialog();
        }

        private void btnMenuModificarPaciente_Click(object sender, EventArgs e)
        {
            FrmModificarPaciente frmModificarPaciente = new FrmModificarPaciente();
            frmModificarPaciente.ShowDialog();
        }

        private void btnMenuModificarMedico_Click(object sender, EventArgs e)
        {
            FrmModificarMedico frmModificarMedico = new FrmModificarMedico();
            frmModificarMedico.ShowDialog();
        }

        private void btnMenuBuscarPacienteId_Click(object sender, EventArgs e)
        {
            FrmBuscarPacientePorID frmBuscarPacientePorID = new FrmBuscarPacientePorID();
            frmBuscarPacientePorID.ShowDialog();
        }

        private void btnMenuBuscarPacienteNombre_Click(object sender, EventArgs e)
        {
            FrmBuscarPacientePorNombre frmBuscarPacientePorNombre = new FrmBuscarPacientePorNombre();
            frmBuscarPacientePorNombre.ShowDialog();
        }

        private void btnMenuBuscarMedicoId_Click(object sender, EventArgs e)
        {
            FrmBuscarMedicoPorID frmBuscarMedicoPorID = new FrmBuscarMedicoPorID();
            frmBuscarMedicoPorID.ShowDialog();
        }

        private void btnMenuBuscarMedicoNombre_Click(object sender, EventArgs e)
        {
            FrmBuscarMedicoPorNombre frmBuscarMedicoPorNombre = new FrmBuscarMedicoPorNombre();
            frmBuscarMedicoPorNombre.ShowDialog();
        }

        private void btnMenuBuscarCitaPaciente_Click(object sender, EventArgs e)
        {
            FrmBuscarCitasPorPaciente frmBuscarCitasPorPaciente = new FrmBuscarCitasPorPaciente();
            frmBuscarCitasPorPaciente.ShowDialog();
        }

        private void btnMenuBuscarCitaMedico_Click(object sender, EventArgs e)
        {
            FrmBuscarCitasPorMedico frmBuscarCitasPorMedico = new FrmBuscarCitasPorMedico();
            frmBuscarCitasPorMedico.ShowDialog();
        }

        private void btnMenuModificarEspecialidad_Click(object sender, EventArgs e)
        {
            FrmModificarEspecialidad frmModificarEspecialidad = new FrmModificarEspecialidad();
            frmModificarEspecialidad.ShowDialog();
        }

        private void btnMenuEliminarCita_Click(object sender, EventArgs e)
        {
            FrmEliminarCita frmEliminarCita = new FrmEliminarCita();
            frmEliminarCita.ShowDialog();
        }
    }
}
