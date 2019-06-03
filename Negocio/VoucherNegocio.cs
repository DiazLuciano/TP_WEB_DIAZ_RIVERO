using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace NEGOCIO
{
    public class VoucherNegocio
    {
        private Voucher vou;
        public void setvoucher(Voucher voucher)
        {
            this.vou = voucher;
        }

        public bool ValidarVoucher(Voucher voucher)
        {

            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select * from Vouchers Where CodigoVoucher=@codigo");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@codigo", voucher.Codigo);
                
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                if (conexion.Lector.Read())
                {
                    DateTime fecha = DateTime.Today;
                    voucher.ID = (long)conexion.Lector["Id"];
                    voucher.Codigo = (string)conexion.Lector["CodigoVoucher"];
                    voucher.Estado = (bool)conexion.Lector["Estado"];
                    voucher.Fecharegistro = fecha.ToLocalTime();
                    Voucher.voucherelegido = voucher;
                    

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarVoucher(Cliente cli)
        {
            AccesoDatos AD = new AccesoDatos();
            try
            {
                DateTime fecha = DateTime.Today;
                AD.setearConsulta("insert into Vouchers  IdCliente=@IdCliente, IdProducto=@IdProducto, Estado=@Estado, FechaRegistro=@FechaRegistro where Id=" + Voucher.voucherelegido.ID);
                AD.Comando.Parameters.Clear();
                AD.Comando.Parameters.AddWithValue("@IdCliente", cli.ID);
                AD.Comando.Parameters.AddWithValue("@IdProducto", Producto.productoelegido.ID);
                
                AD.Comando.Parameters.AddWithValue("@Estado", true);
                AD.Comando.Parameters.AddWithValue("@FechaRegistro", fecha);

                AD.abrirConexion();
                AD.ejecutarAccion();

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
