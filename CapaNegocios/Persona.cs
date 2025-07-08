using System;

namespace CapaNegocio
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        // Constructor
        protected Persona(string nombre, string cedula)
        {
            Nombre = nombre;
            Cedula = cedula;
        }

        // Método abstracto (obligatorio de implementar)
        public abstract decimal CalcularSueldo();

        // Método virtual (puede ser sobreescrito)
        public virtual string MostrarInformacion()
        {
            return $"Nombre: {Nombre} - Cédula: {Cedula}";
        }
    }
}

