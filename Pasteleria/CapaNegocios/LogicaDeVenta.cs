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
    }
}
