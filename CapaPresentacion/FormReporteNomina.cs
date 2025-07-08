using CapaNegocio;
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
    public partial class FormReporteNomina : Form
    {
        private readonly EmpleadoService empleadoService;
        private List<EmpleadoNegocio> empleados;
        public FormReporteNomina()
        {
            InitializeComponent();
            empleadoService = new EmpleadoService();
            CargarReporte();
        }

        private void CargarReporte()
        {
            empleados = empleadoService.ObtenerEmpleados();

            var tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Cedula", typeof(string));
            tabla.Columns.Add("SueldoBase", typeof(decimal));
            tabla.Columns.Add("HorasExtra", typeof(int));
            tabla.Columns.Add("HorasNocturnas", typeof(int));
            tabla.Columns.Add("SalarioHora", typeof(decimal));
            tabla.Columns.Add("AFP", typeof(decimal));
            tabla.Columns.Add("ARS", typeof(decimal));
            tabla.Columns.Add("PagoExtra", typeof(decimal));
            tabla.Columns.Add("PagoNocturna", typeof(decimal));
            tabla.Columns.Add("SueldoTotal", typeof(decimal));

            foreach (var e in empleados)
            {
                decimal salarioHora = e.SueldoBase / 176m;
                decimal afp = e.SueldoBase * 0.0287m;
                decimal ars = e.SueldoBase * 0.0304m;
                decimal pagoExtra = salarioHora * e.HorasExtra * 2;
                decimal pagoNocturna = salarioHora * e.HorasNocturnas * 1.15m;
                decimal sueldoTotal = e.SueldoBase + pagoExtra + pagoNocturna - afp - ars;

                tabla.Rows.Add(
                    e.Id,
                    e.Nombre,
                    e.Cedula,
                    e.SueldoBase,
                    e.HorasExtra,
                    e.HorasNocturnas,
                    Math.Round(salarioHora, 2),
                    Math.Round(afp, 2),
                    Math.Round(ars, 2),
                    Math.Round(pagoExtra, 2),
                    Math.Round(pagoNocturna, 2),
                    Math.Round(sueldoTotal, 2)
                );
            }

            dgvNomina.DataSource = tabla;
            dgvNomina.Columns["Id"].Visible = false;

            lblTotalNomina.Text = $"Total Nómina: {tabla.AsEnumerable().Sum(r => r.Field<decimal>("SueldoTotal")):C}";

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporteNomina_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvNomina.Rows)
            {
                if (fila.IsNewRow) continue;

                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                int horasExtra = Convert.ToInt32(fila.Cells["HorasExtra"].Value);
                int horasNocturnas = Convert.ToInt32(fila.Cells["HorasNocturnas"].Value);

                // Buscar empleado original y actualizarlo
                var emp = empleados.FirstOrDefault(x => x.Id == id);
                if (emp != null)
                {
                    emp.HorasExtra = horasExtra;
                    emp.HorasNocturnas = horasNocturnas;
                    empleadoService.ActualizarHoras(emp);
                }
            }

            MessageBox.Show("Horas actualizadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarReporte(); // Recargar cálculos
        }
    }
}
