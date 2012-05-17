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
        public bool Login(int idEmpleado, string Contraseña)
        {
            Empleado empleado = new Empleado();
            empleado = ObtenerEmpleado(idEmpleado);

            if (Contraseña == empleado.Contraseña)
            {
                return true;
            }
            else
                return false;
        }
    }
}
