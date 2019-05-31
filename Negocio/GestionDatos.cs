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
    public class GestionDatos
    {
        public SqlConnection conexion { get; set; }
        public string error;

        public GestionDatos()
        {
            
        }

        public bool agregarCliente(Cliente nuevo)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into Clientes values (@dni,@nombre,@apellido,@email,@direccion,@ciudad,@cp)";
            comando.Parameters.AddWithValue("@dni", nuevo.DNI);
            comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
            comando.Parameters.AddWithValue("@email", nuevo.Email);
            comando.Parameters.AddWithValue("@direccion", nuevo.Direccion);
            comando.Parameters.AddWithValue("@ciudad", nuevo.Ciudad);
            comando.Parameters.AddWithValue("@cp", nuevo.CP);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public Voucher validarSiExiste(string codigo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select *from Vouchers Where CodigoVoucher=@codigo";
            comando.Parameters.AddWithValue("@codigo", codigo);
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                Voucher vou = new Voucher();
                
                vou.Codigo = lector.GetString(1);
                vou.Estado = lector.GetBoolean(2);
                vou.IDCliente = lector.GetInt32(3);
                vou.IDProducto = lector.GetInt32(4);
                lector.Close();
                return vou;
            }
            else
            {
                lector.Close();
                return null;
            }
        }
    }
}
