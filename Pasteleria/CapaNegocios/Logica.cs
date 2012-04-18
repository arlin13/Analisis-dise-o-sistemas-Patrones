using System;
using System.Collections.Generic;
using CapaDatos;
using CapaComunes;

namespace CapaNegocios
{
    public class Logica
    {
        BaseDatos bd = new BaseDatos();

        public Logica()
        { 
        }

        public string CapturarEmpleado(Empleado e)
        {
            return bd.IngresarEmpleado(e);
        }

        public string ActualizarEmpleado(string idEmpleado, Empleado emp)
        {
           return bd.EditarEmpleado(Convert.ToInt32(idEmpleado), emp);          
        }

        public string BorraEmpleado(int idEmpleado)
        {
           return bd.BorrarEmpleado(idEmpleado);         
        }

        public string CapturarVenta(Venta v)
        {
            return bd.IngresarVenta(v);        
        }

        public Empleado ObtenerEmpleado(string idEmpleado)
        {
            Empleado emp = bd.ObtenerEmpleado(Convert.ToInt32(idEmpleado));
            return emp;
        }

        public bool Login(int idEmpleado, string contraseña)
        {
            bool confirmado = bd.Login(idEmpleado, contraseña);
            return confirmado;
        }

        public int ObtenerEmpleadoID(string correo)
        {
            return bd.ObtenerEmpleadoID(correo);
        }

        public string ObtenerContrasena(string correo)
        {
            return bd.ObtenerContrasena(correo);
        }

        //public List<Persona> ObtenerPersonas()
        //{
        //    return bd.ObtenerPersonas();
        //}

    }
}
