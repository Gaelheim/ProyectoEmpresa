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
    public partial class FormLogin : Form
    {
        private readonly LoginService loginService;
        public FormLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void ptbVeo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (loginService.ValidarAcceso(usuario, clave, out string rol))
            {
                MessageBox.Show($"Bienvenido, rol: {rol}", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                FormPrincipal menu = new FormPrincipal(usuario, rol);
                menu.Show();
                this.Hide();
            }
            else
            {
                lblMensaje.Text = "Usuario o clave incorrectos";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
