using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public decimal SueldoBase { get; set; }
        public DateTime FechaIngreso { get; set; }
    }

    public class EmpleadoDatos
    {
        private readonly Conexion conexion;

        public EmpleadoDatos()
        {
            conexion = new Conexion();
        }

        public bool InsertarEmpleado(EmpleadoDTO empleado)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Empleados (Nombre, Cedula, Cargo, SueldoBase, FechaIngreso) 
                                 VALUES (@Nombre, @Cedula, @Cargo, @SueldoBase, @FechaIngreso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                cmd.Parameters.AddWithValue("@SueldoBase", empleado.SueldoBase);
                cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<EmpleadoDTO> ObtenerEmpleados()
        {
            var lista = new List<EmpleadoDTO>();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Empleados";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new EmpleadoDTO
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
                        Cargo = reader["Cargo"].ToString(),
                        SueldoBase = Convert.ToDecimal(reader["SueldoBase"]),
                        FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"])
                    });
                }
            }

            return lista;
        }
    }
}