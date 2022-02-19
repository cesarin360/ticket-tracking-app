using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Bdl_Grupo2_ProyectoFinal_A.Conexion
{
    public class ClsConexion
    {
        public SqlConnection con;
        private String _conexion { get; }

        public ClsConexion()
        {
            _conexion = "data source=LAPTOP-U1E9MIOS\\CGARCIA; database=Bdl_ProyectoFinal_A; integrated security=True";
        }   

        public SqlDataReader ConsultaBd(String query)
        {
            abrirConexion();
            SqlCommand connection = new SqlCommand(query);
            connection.Connection = con;
            SqlDataReader oReader = connection.ExecuteReader();
            return oReader;
        }

        public void abrirConexion()
        {
            con = new SqlConnection(_conexion);
            con.Open();
        }

        public void cerrarConexion()
        {
            con.Close();
        }

    }

}
