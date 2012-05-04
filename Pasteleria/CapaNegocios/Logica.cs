using System;
using System.Collections.Generic;
using CapaDatos;
using CapaComunes;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class Logica
    {
        BaseDatos bd = new BaseDatos();

        public Logica()
        { 
        }

        #region Empleado 
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
        #endregion

        #region Venta
        public string CapturarVenta(Venta v)
        {
            return bd.IngresaVenta(v);        
        }

        public string ActualizarVenta(string idVenta, Venta ven)
        {
            return bd.EditaVenta(Convert.ToInt32(idVenta), ven);
        }

        public Venta ObtenerVentas(int idVenta)
        {
            return bd.ObtenerVentas(idVenta);
        }

        public DataTable ObtenerVentasEmpleado(int idEmpleado)
        {
            return bd.ObtenerVentasEmpleado(idEmpleado);
        }

        public DataTable MostrarDGVVentas()
        {
            return bd.DGVVentas();
        }

        #endregion

        #region Contrasena
        public string ObtenerContrasena(string correo)
        {
            return bd.ObtenerContrasena(correo);
        }
        #endregion

        #region Login
        public bool Login(int idEmpleado, string contraseña)
        {
            bool confirmado = bd.Login(idEmpleado, contraseña);
            return confirmado;
        }
        #endregion

        //public Persona ObtenerPersona(int p)
        //{
        //    Persona obj = bd.ObtenerPersona(p);
        //    obj.Nombre = obj.Nombre.ToUpper();
        //    return obj;
        //}

        //public List<Persona> ObtenerPersonas()
        //{
        //    return bd.ObtenerPersonas();
        //}

    }
}
