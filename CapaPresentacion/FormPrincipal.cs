namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        private string _usuario;
        private string _rol;
        public FormPrincipal(string usuario, string rol)
        {
            InitializeComponent();
            _usuario = usuario;
            _rol = rol;

            lblBienvenida.Text = $"Bienvenido: {_usuario} - Rol: {_rol}";
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            FormEmpleado form = new FormEmpleado();
            form.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporteNomina form = new FormReporteNomina();
            form.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
