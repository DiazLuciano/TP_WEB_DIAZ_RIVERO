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

        public void CargarPro(long n)
        {
            AccesoDatos AD = new AccesoDatos();
            Producto pro = new Producto();
            try
            {
                AD.setearConsulta("Select * From Productos where Id= " + n);
                AD.Comando.Parameters.Clear();
                AD.Comando.Parameters.AddWithValue("@id", n);
                AD.abrirConexion();
                AD.ejecutarConsulta();
               
                
                while (AD.Lector.Read())
                {
                    pro.ID = (long)AD.Lector["Id"];
                    pro.Titulo = (string)AD.Lector["Titulo"];
                    pro.Descripcion = (string)AD.Lector["Descripcion"];
                    pro.URLImagen = (string)AD.Lector["URLImagen"];
                    Producto.productoelegido = pro;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
