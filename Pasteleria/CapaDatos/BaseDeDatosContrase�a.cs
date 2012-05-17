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
        public int ObtenerEmpleadoID(string correo)
        {
            Empleado empleado = null;
            CommandSet("SELECT * FROM Empleado WHERE correo = '" + correo + "'", CommandType.Text);

            DataSet results = ExecuteDataSet();
            if (results.Tables[0].Rows.Count > 0)
            {
                empleado = new Empleado()
                {
                    idEmpleado = int.Parse(results.Tables[0].Rows[0]["idEmpleado"].ToString())
                };
            };

            return empleado.idEmpleado;
        }
        public string ObtenerContrasena(string correo)
        {
            Empleado empleado = null;
            CommandSet("SELECT Contraseña FROM Empleado WHERE correo = '" + correo + "'", CommandType.Text);

            DataSet results = ExecuteDataSet();
            if (results.Tables[0].Rows.Count > 0)
            {
                empleado = new Empleado()
                {
                    Contraseña = results.Tables[0].Rows[0]["Contraseña"].ToString()
                };
            };

            return empleado.Contraseña;
        }
    }
}
