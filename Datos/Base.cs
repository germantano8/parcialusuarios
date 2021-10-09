using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class Base
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["NetGenerica"].ConnectionString;
        public SqlConnection conexion = new SqlConnection(connectionString);
    }
}