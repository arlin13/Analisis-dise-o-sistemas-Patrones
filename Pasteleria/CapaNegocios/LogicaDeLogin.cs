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
        public string ObtenerContrasena(string correo)
        {
            return bd.ObtenerContrasena(correo);
        }

        public bool Login(int idEmpleado, string contraseña)
        {
            bool confirmado = bd.Login(idEmpleado, contraseña);
            return confirmado;
        }
    }
}
