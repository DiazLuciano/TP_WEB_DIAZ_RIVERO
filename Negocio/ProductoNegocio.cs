using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dominio;

namespace NEGOCIO
{
    public class ProductoNegocio
    {
        public List<Producto> ListarProductos()
        {

            AccesoDatos AD = new AccesoDatos();
            List<Producto> listado = new List<Producto>();

            try
            {
                AD.setearConsulta("Select * From Productos");
                AD.Comando.Parameters.Clear();
                AD.abrirConexion();
                AD.ejecutarConsulta();

                while (AD.Lector.Read())
                {
                    Producto pro = new Producto();

                    pro.ID = (long)AD.Lector["Id"];
                    pro.Titulo = (string)AD.Lector["Titulo"];
                    pro.Descripcion = (string)AD.Lector["Descripcion"];
                    pro.URLImagen = (string)AD.Lector["URLImagen"];
                    //pro.Titulo = AD.Lector.GetString(1);
                    //pro.Descripcion = AD.Lector.GetString(2);
                    //pro.URLImagen = AD.Lector.GetString(3);
                    listado.Add(pro);
                }
                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AD.cerrarConexion();
            }
        }
    }
}
