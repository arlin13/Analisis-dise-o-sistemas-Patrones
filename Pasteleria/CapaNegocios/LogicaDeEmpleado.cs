using System;
using System.Collections.Generic;
using CapaDatos;
using CapaComunes;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public partial class Logica
    {
        BaseDeDatos bd = new BaseDeDatos();

        public Logica()
        {
        }

        public string CapturarEmpleado(Empleado e)
        {
            return bd.IngresaEmpleado(e);
        }

        public string ActualizarEmpleado(string idEmpleado, Empleado emp)
        {
            return bd.EditaEmpleado(Convert.ToInt32(idEmpleado), emp);
        }

        public string BorraEmpleado(int idEmpleado)
        {
            return bd.BorraEmpleado(idEmpleado);
        }

        public Empleado ObtenerEmpleado(string idEmpleado)
        {
            Empleado emp = bd.ObtenerEmpleado(Convert.ToInt32(idEmpleado));
            return emp;
        }

        public int ObtenerEmpleadoID(string correo)
        {
            return bd.ObtenerEmpleadoID(correo);
        }
    }
}
