using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaComunes;

namespace CapaDatos
{
    public class BaseDatos
    {
        private static readonly string Connectionstring = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
        private readonly SqlConnection _connection;
        private SqlCommand _command;

        public BaseDatos()
        {
            _connection = new SqlConnection(Connectionstring);
        }

        private void CommandSet(string query, CommandType type)
        {
            _command = new SqlCommand();
            _command.CommandText = query;
            _command.CommandType = type;
            _command.Connection = _connection;
        }

        private DataSet ExecuteDataSet()
        {
            DataSet results = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = _command;
                _connection.Open();
                adapter.Fill(results);
            }
            catch (SqlException exception)
            {
                string debug = exception.Message;
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
            return results;
        }

        private void ExecuteQuery()
        {
            try
            {
                _connection.Open();
                _command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                string debug = exception.Message;
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
        }

        #region Empleado
        public string IngresarEmpleado(Empleado e)
        {
            CommandSet("IngresarEmpleado", CommandType.StoredProcedure);

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
        public string EditarEmpleado(int idEmpleado, Empleado e)
        {

            CommandSet("EditarEmpleado", CommandType.StoredProcedure);

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
        public string BorrarEmpleado(int idEmpleado)
        {
            CommandSet("BorrarEmpleado", CommandType.StoredProcedure);

            if (_command != null)
            {
                _command.Parameters.Add(new SqlParameter("@idEmpleado", idEmpleado));
            }

            ExecuteQuery();
            return "El empleado se ha dado de baja.";
        }
        public Empleado ObtenerEmpleado(int idEmpleado)
        {
            Empleado empleado = null;
            CommandSet("SELECT * FROM Empleado WHERE idEmpleado = '" + idEmpleado + "'", CommandType.Text);

            DataSet results = ExecuteDataSet();
            if (results.Tables[0].Rows.Count > 0)
            {
                empleado = new Empleado()
                {
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
        #endregion Empleado

        #region Venta
        public string IngresarVenta(Venta v)
        {
            CommandSet("IngresarVenta", CommandType.StoredProcedure);

            if (_command != null)
            {
                _command.Parameters.Add(new SqlParameter("@Monto", v.Monto));
                _command.Parameters.Add(new SqlParameter("@idEmpleado", v.idEmpleado));
            }

            ExecuteQuery();
            return "La venta se ha capturado.";
        }
        #endregion Venta

        #region Contrasena
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
        #endregion Contrasena

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

        //public List<Persona> ObtenerPersonas()
        //{
        //    List<Persona> lista = null;
        //    CommandSet("SELECT * FROM Personas", CommandType.Text);
        //    DataSet results = ExecuteDataSet();
        //    if (results.Tables[0].Rows.Count > 0)
        //    {
        //        lista = new List<Persona>();
        //        foreach (DataRow row in results.Tables[0].Rows)
        //        {
        //            Persona obj = new Persona()
        //            {
        //                Nombre = row["Persona_Nombre"].ToString(),
        //                Edad = int.Parse(row["Persona_Edad"].ToString())
        //            };
        //            lista.Add(obj);
        //        }
        //    }
        //    return lista;
        //}
    }
}