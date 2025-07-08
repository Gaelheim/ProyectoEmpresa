using CapaDatos;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class EmpleadoService
    {
        private readonly EmpleadoDatos empleadoDatos;

        public EmpleadoService()
        {
            empleadoDatos = new EmpleadoDatos();
        }

        public bool AgregarEmpleado(EmpleadoNegocio empleado)
        {
            var dto = new EmpleadoDTO
            {
                Nombre = empleado.Nombre,
                Cedula = empleado.Cedula,
                Cargo = empleado.Cargo,
                SueldoBase = empleado.SueldoBase,
                FechaIngreso = empleado.FechaIngreso,
                HorasExtra = empleado.HorasExtra,
                HorasNocturnas = empleado.HorasNocturnas
            };

            return empleadoDatos.InsertarEmpleado(dto);
        }

        public List<EmpleadoNegocio> ObtenerEmpleados()
        {
            var lista = new List<EmpleadoNegocio>();
            var empleados = empleadoDatos.ObtenerEmpleados();

            foreach (var dto in empleados)
            {
                var emp = new EmpleadoNegocio(
                    dto.Nombre,
                    dto.Cedula,
                    dto.Cargo,
                    dto.SueldoBase,
                    dto.FechaIngreso
                );
                lista.Add(emp);
            }

            return lista;
        }
    }
}