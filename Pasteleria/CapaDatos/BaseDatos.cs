using System;
using System.Collections.Generic;
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

        //public void CapturarPersona(Persona p)
        //{
        //    CommandSet("sp_Personas", CommandType.StoredProcedure);
        //    if (_command != null)
        //    {
        //        _command.Parameters.Add(new SqlParameter("@Nombre", p.Nombre));
        //        _command.Parameters.Add(new SqlParameter("@Edad", p.Edad));
        //    }
        //    ExecuteQuery();
        //}

        //public Persona ObtenerPersona(int p)
        //{
        //    Persona obj = null;
        //    CommandSet("SELECT * FROM Personas WHERE Persona_ID = '" + p + "'", CommandType.Text);

        //    DataSet results = ExecuteDataSet();
        //    if (results.Tables[0].Rows.Count > 0)
        //    {
        //        obj = new Persona()
        //        {
        //            Nombre = results.Tables[0].Rows[0]["Persona_Nombre"].ToString(),
        //            Edad = int.Parse(results.Tables[0].Rows[0]["Persona_Edad"].ToString())
        //        };
        //    }
        //    return obj;
        //}

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
