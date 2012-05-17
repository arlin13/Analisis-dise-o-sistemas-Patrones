using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaComunes;

namespace CapaDatos
{
    public partial class BaseDeDatos
    {
        public string IngresaEmpleado(Empleado e)
        {
            CommandSet("IngresaEmpleado", CommandType.StoredProcedure);

            if (_command != null)
            {
                _command.Parameters.Add(new SqlParameter("@Usuario", e.Usuario));
                _command.Parameters.Add(new SqlParameter("@Nombre", e.Nombre));
                _command.Parameters.Add(new SqlParameter("@Apellido", e.Apellido));
                _command.Parameters.Add(new SqlParameter("@Correo", e.Correo));
                _command.Parameters.Add(new SqlParameter("@Contraseña", e.Contraseña));
                _command.Parameters.Add(new SqlParameter("@Genero", e.Genero));
            }

            ExecuteQuery();
            return "El empleado se ha agregado.";
        }

        public string EditaEmpleado(int idEmpleado, Empleado e)
        {
            CommandSet("EditaEmpleado", CommandType.StoredProcedure);

            if (_command != null)
            {
                _command.Parameters.Add(new SqlParameter("@idEmpleado", idEmpleado));
                _command.Parameters.Add(new SqlParameter("@Usuario", e.Usuario));
                _command.Parameters.Add(new SqlParameter("@Nombre", e.Nombre));
                _command.Parameters.Add(new SqlParameter("@Apellido", e.Apellido));
                _command.Parameters.Add(new SqlParameter("@Correo", e.Correo));
                _command.Parameters.Add(new SqlParameter("@Contraseña", e.Contraseña));
                _command.Parameters.Add(new SqlParameter("@Genero", e.Genero));
            }

            ExecuteQuery();
            return "La información del empleado se ha actualizado.";
        }

        public string BorraEmpleado(int idEmpleado)
        {
            CommandSet("BorraEmpleado", CommandType.StoredProcedure);

            if (_command != null)
            {
                _command.Parameters.Add(new SqlParameter("@idEmpleado", idEmpleado));
            }

            ExecuteQuery();
            return "El empleado se ha dado de baja.";
        }

        public Empleado ObtenerEmpleado(int idEmpleado)
        {
            CommandSet("SELECT * FROM Empleado WHERE idEmpleado = '" + idEmpleado + "'", CommandType.Text);

            DataSet results = ExecuteDataSet();
            if (results.Tables[0].Rows.Count > 0)
            {
                empleado = new Empleado()
                {
                    idEmpleado = Convert.ToInt32(results.Tables[0].Rows[0]["idEmpleado"]),
                    Usuario = results.Tables[0].Rows[0]["Usuario"].ToString(),
                    Nombre = results.Tables[0].Rows[0]["Nombre"].ToString(),
                    Apellido = results.Tables[0].Rows[0]["Apellido"].ToString(),
                    Correo = results.Tables[0].Rows[0]["Correo"].ToString(),
                    Contraseña = results.Tables[0].Rows[0]["Contraseña"].ToString(),
                    Genero = results.Tables[0].Rows[0]["Genero"].ToString()
                };
            };

            return empleado;
        }
    }
}
