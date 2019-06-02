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
                conexion.setearConsulta("select CodigoVoucher from Vouchers Where CodigoVoucher=@codigo");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@codigo", voucher.Codigo);
                
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {
                    
                    voucher.Codigo = (string)conexion.Lector["CodigoVoucher"];
                    
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
    }

}
