using CapaDatos;

namespace CapaNegocio
{
    public class LoginService
    {
        private readonly UsuarioDatos usuarioDatos;

        public LoginService()
        {
            usuarioDatos = new UsuarioDatos();
        }

        public bool ValidarAcceso(string usuario, string clave, out string rol)
        {
            return usuarioDatos.ValidarUsuario(usuario, clave, out rol);
        }

        public bool RegistrarUsuario(string usuario, string clave, string rol)
        {
            return usuarioDatos.CrearUsuario(usuario, clave, rol);
        }
    }
}