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
        AccesoDatos AD;
        public bool ExisteDNI(long dni)
        {
            try
            {
                Cliente cliente = new Cliente();

                AD = new AccesoDatos();
                
                AD.setearConsulta("select DNI from Clientes  Where Dni=@Dni");
                AD.Comando.Parameters.Clear();
                AD.Comando.Parameters.AddWithValue("@Dni", dni);
                AD.abrirConexion();
                AD.ejecutarConsulta();

                if (AD.Lector.Read())
                {
                   
                    cliente.DNI= (int)AD.Lector["DNI"];

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

        public Cliente CargarDatosCliente(Cliente cli,int dni)
        {
            AD = new AccesoDatos();

            try
            {
                AD.setearConsulta("select * from Clientes  Where Dni=@Dni");
                AD.Comando.Parameters.Clear();
                AD.Comando.Parameters.AddWithValue("@Dni", dni);
                AD.abrirConexion();
                AD.ejecutarConsulta();
                
                while(AD.Lector.Read())
                {
                    cli.ID = (long)AD.Lector["Id"];
                    cli.DNI = (int)AD.Lector["DNI"];
                    cli.Nombre = AD.Lector["Nombre"].ToString();
                    cli.Apellido = AD.Lector["Apellido"].ToString();
                    cli.Direccion = AD.Lector["Direccion"].ToString();
                    cli.Email = AD.Lector["Email"].ToString();
                    cli.Ciudad = AD.Lector["Ciudad"].ToString();
                    cli.CP = AD.Lector["CodigoPostal"].ToString();
                    cli.FechaRegistro = (DateTime)AD.Lector["FechaRegistro"];
                }
               
   
                return cli;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                AD.cerrarConexion();
            }

        }

        public Cliente leerCliente(int dni)
        {
            AD = new AccesoDatos();
            try
            {
                Cliente cli = new Cliente();

                AD.setearConsulta("select * from Clientes  Where Dni=" + dni);
                AD.abrirConexion();
                AD.ejecutarConsulta();

               while (AD.Lector.Read())
                {
                    cli.ID = (long)AD.Lector["Id"];
                    cli.DNI = (int) AD.Lector["DNI"];
                    cli.Nombre = AD.Lector["Nombre"].ToString();
                    cli.Apellido = AD.Lector["Apellido"].ToString();
                    cli.Direccion = AD.Lector["Direccion"].ToString();
                    cli.Email = AD.Lector["Email"].ToString();
                    cli.Ciudad = AD.Lector["Ciudad"].ToString();
                    cli.CP = AD.Lector["CodigoPostal"].ToString();
                    cli.FechaRegistro = (DateTime)AD.Lector["FechaRegistro"];
                    Cliente.clienteelegido = cli;

                    
                }
                return cli;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void GuardarCliente (Cliente cli)
        {
            AccesoDatos AD = new AccesoDatos();
            DateTime fecha = DateTime.Today;

            try
            {
                AD.setearConsulta("insert into Clientes Values ('" + cli.DNI + "','" + cli.Nombre + "','" + cli.Apellido + "','" + cli.Email + "','" + cli.Direccion + "','" + cli.Ciudad + "','" + cli.CP + "','" + fecha + "')");
                AD.abrirConexion();
                AD.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
