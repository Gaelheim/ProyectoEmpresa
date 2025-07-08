using System;

namespace CapaNegocio
{
    public class EmpleadoNegocio : Persona
    {
        public string Cargo { get; set; }
        public decimal SueldoBase { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int HorasExtra { get; set; }
        public int HorasNocturnas { get; set; }

        // Constructor personalizado
        public EmpleadoNegocio(string nombre, string cedula, string cargo, decimal sueldoBase, DateTime fechaIngreso)
            : base(nombre, cedula)
        {
            Cargo = cargo;
            SueldoBase = sueldoBase;
            FechaIngreso = fechaIngreso;

            HorasExtra = 0;
            HorasNocturnas = 0;
        }

        // Implementación del método abstracto
        public override decimal CalcularSueldo()
        {
            // Ejemplo: Sueldo + bonificación por antigüedad
            int años = DateTime.Now.Year - FechaIngreso.Year;
            decimal bono = años * 1000;
            return SueldoBase + bono;
        }

        // Sobrescribimos el método virtual
        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $" - Cargo: {Cargo} - Sueldo base: {SueldoBase:C}";
        }
    }
}