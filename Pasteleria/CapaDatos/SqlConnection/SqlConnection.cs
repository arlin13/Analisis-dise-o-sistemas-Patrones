using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    class SqlConnection
    {
        private static SqlConnection _sqlConnectionInstance;

        protected SqlConnection()
        { 
        }

        public static SqlConnection Instance()
        {
            if (_sqlConnectionInstance == null)
            {
                _sqlConnectionInstance = new SqlConnection();
            }
            return _sqlConnectionInstance;
        }
    }
}
