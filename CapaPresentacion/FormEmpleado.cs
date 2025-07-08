using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormEmpleado : Form
    {
        private readonly EmpleadoService empleadoService;
        public FormEmpleado()
        {
            InitializeComponent();
            empleadoService = new EmpleadoService();
            CargarEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string cedula = txtCedula.Text.Trim();
                string cargo = txtCargo.Text.Trim();
                string sueldoTexto = txtSueldoBase.Text.Trim();

                if (!decimal.TryParse(sueldoTexto, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal sueldoBase))
                {
                    MessageBox.Show("Sueldo inválido. Usa formato decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaIngreso = dtpFechaIngreso.Value;

                EmpleadoNegocio empleado = new EmpleadoNegocio(nombre, cedula, cargo, sueldoBase, fechaIngreso);

                bool exito = empleadoService.AgregarEmpleado(empleado);

                if (exito)
                {
                    MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarEmpleados(); // Recarga la lista
                }
                else
                {
                    MessageBox.Show("Error al registrar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleadoService.ObtenerEmpleados();

            dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre";
            dgvEmpleados.Columns["Cedula"].HeaderText = "Cédula";
            dgvEmpleados.Columns["Cargo"].HeaderText = "Cargo";
            dgvEmpleados.Columns["SueldoBase"].HeaderText = "Sueldo Base";
            dgvEmpleados.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";

            
            if (dgvEmpleados.Columns.Contains("Id"))
                dgvEmpleados.Columns["Id"].Visible = true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtCargo.Text = "";
            txtSueldoBase.Text = "";
            dtpFechaIngreso.Value = DateTime.Today;
        }
        private void FormEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
