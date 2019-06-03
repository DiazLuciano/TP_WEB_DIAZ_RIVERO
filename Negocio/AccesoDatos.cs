using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class AccesoDatos
    {
        //private static SqlConnection objConexion;
        //private static string error;

        //public static SqlConnection getConexion()
        //{
        //    if (objConexion != null)
        //        return objConexion;
        //    objConexion = new SqlConnection();
        //    objConexion.ConnectionString = "Data Source=PROBOOK\\SQLEXPRESS;Initial Catalog=TP_WEB;Integrated Security=True";
        //    try
        //    {
        //        objConexion.Open();
        //        return objConexion;
        //    }
        //    catch (Exception e)
        //    {
        //        error = e.Message;
        //        return null;
        //    }
        //}

        //public static void cerrarConexion()
        //{
        //    if (objConexion != null)
        //        objConexion.Close();
        //}
        

            public static string cadenaConexion = "Data Source =.\\SQLEXPRESS;Initial Catalog = TP_WEB; Integrated Security = true";
            private SqlCommand comando;
            private SqlConnection conexion;
            private SqlDataReader lector;

            public SqlDataReader Lector
            {
                get { return lector; }
            }
            public SqlCommand Comando
            {
                get { return comando; }
            }

            public AccesoDatos()
            {
                conexion = new SqlConnection(cadenaConexion);
            }

            //setear consulta embebida.
            public void setearConsulta(string consulta)
            {
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }

            //esto para luego...
            public void setearSP(string sp)
            {
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = sp;
            }

            public void abrirConexion()
            {
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void cerrarConexion()
            {
                try
                {
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ejecutarAccion()
            {
                try
                {
                    comando.Connection = conexion;
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public int ejecutarAccionReturn()
            {
                try
                {
                    comando.Connection = conexion;
                    return (int)comando.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ejecutarConsulta()
            {
                try
                {
                    comando.Connection = conexion;
                    lector = comando.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        
    }
}
