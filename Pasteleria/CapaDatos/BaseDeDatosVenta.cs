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
        public string IngresaVenta(Venta v)
        {
            CommandSet("IngresaVenta", CommandType.StoredProcedure);

            if (_command != null)
            {
                _command.Parameters.Add(new SqlParameter("@Monto", v.Monto));
                _command.Parameters.Add(new SqlParameter("@idEmpleado", v.idEmpleado));
            }

            ExecuteQuery();
            return "La venta se ha capturado.";
        }

        public string EditaVenta(int idVenta, Venta v)
        {
            CommandSet("EditaVenta", CommandType.StoredProcedure);

            if (_command != null)
            {
                _command.Parameters.Add(new SqlParameter("@idVenta", idVenta));
                _command.Parameters.Add(new SqlParameter("@Monto", v.Monto));
            }

            ExecuteQuery();
            return "Se ha actualizado la venta.";
        }

        public DataTable DGVVentas()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Venta", _connection);
            DataTable tabla = new DataTable();

            try
            {
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                string debug = ex.Message;
            }

            return tabla;
        }

        public DataTable ObtenerVentasEmpleado(int idEmpleado)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Venta WHERE idEmpleado = '" + idEmpleado + "'", _connection);
            DataTable tabla = new DataTable();

            try
            {
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                string debug = ex.Message;
            }

            return tabla;
        }

        public Venta ObtenerVentas(int idVenta)
        {
            Venta venta = null;
            CommandSet("SELECT * FROM Venta WHERE idVenta = '" + idVenta + "'", CommandType.Text);

            DataSet results = ExecuteDataSet();
            if (results.Tables[0].Rows.Count > 0)
            {
                venta = new Venta()
                {
                    idVenta = Convert.ToInt32(results.Tables[0].Rows[0]["idVenta"]),
                    idEmpleado = Convert.ToInt32(results.Tables[0].Rows[0]["idEmpleado"]),
                    Monto = Convert.ToInt32(results.Tables[0].Rows[0]["Monto"])
                };
            };
            return venta;
        }
    }
}
