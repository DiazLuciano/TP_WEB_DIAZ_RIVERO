using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace NEGOCIO
{
    public class ClienteNegocio
    {
        public bool ExisteDNI(long dni)
        {
            AccesoDatos AD;
            try
            {
                Cliente cliente = new Cliente();

                AD = new AccesoDatos();
                AD.setearConsulta("select * from Clientes  Where Dni=@Dni");
                AD.Comando.Parameters.Clear();
                AD.Comando.Parameters.AddWithValue("@Dni", dni);
                AD.abrirConexion();
                AD.ejecutarConsulta();

                if (AD.Lector.Read())
                {
                    cliente.ID = (long)AD.Lector["Id"];
                    cliente.Nombre = AD.Lector["DNI"].ToString();
                    cliente.Apellido = AD.Lector["Apellido"].ToString();
                    cliente.Direccion = AD.Lector["Direccion"].ToString();
                    cliente.Email = AD.Lector["Email"].ToString();
                    cliente.Ciudad = AD.Lector["Ciudad"].ToString();
                    cliente.CP = AD.Lector["CodigoPostal"].ToString();
                    //cliente.FechaRegistro = (DateTime)conexion.Lector["FechaRegistro"];
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
