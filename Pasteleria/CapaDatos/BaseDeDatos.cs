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
        private static readonly string Connectionstring = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
        private readonly SqlConnection _connection;
        private SqlCommand _command;
        Empleado empleado = null;

        public BaseDeDatos()
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
    }
}
