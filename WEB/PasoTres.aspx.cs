using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using Dominio;



namespace WEB
{
    public partial class PasoTres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           // string cad = Producto.productoelegido.ID.ToString();

            
        }

        //[System.Web.Services.WebMethod]
        //public static string GuardarCliente(string DNI, string Nombre, string Apellido, string Email, string Direccion, string Ciudad, string CP)
        //{
        //    string resultado = string.Empty;

        //    try
        //    {
        //        //Cliente cli = new Cliente();


                //cli.DNI = DNI;
                //cli.Nombre = Nombre;
                //cli.Apellido = Apellido;
                //cli.Email = Email;
                //cli.Direccion = Direccion;
                //cli.Ciudad = Ciudad;
                //cli.CP = CP;
        //    }
        //    catch (Exception ex)
        //    {
        //        resultado = "Error, " + ex.Message;
        //    }
        //    return resultado;
        //}

        public void BorrarRegitros()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtEmail.Text = "";
            txtCP.Text = "";
        }

        public bool ValidarVacio()
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtCiudad.Text == "" || txtEmail.Text == "" || txtCP.Text == "" )
            { return false; }
            else { return true; }
        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            ClienteNegocio CN = new ClienteNegocio();
            Cliente cli = new Cliente();

            try
            {
                int dniconsulta = int.Parse(txtDNI.Text);
                

                if (CN.ExisteDNI(dniconsulta))
                {
                    lblMensaje.Text = "";
                    cli = CN.CargarDatosCliente(cli, dniconsulta);
                    txtDNI.Text = Convert.ToString(cli.DNI);
                    txtNombre.Text = cli.Nombre;
                    txtApellido.Text = cli.Apellido;
                    txtDireccion.Text = cli.Direccion;
                    txtCiudad.Text = cli.Ciudad;
                    txtEmail.Text = cli.Email;
                    txtCP.Text = cli.CP;
                    
                }
                else
                {
                    lblMensaje.Text = "EL DNI NO EXISTE";
                    BorrarRegitros();

                }
            }
            catch (Exception )
            {
                lblMensaje.Text = "NO ESCRIBIO NINGUN DNI";
                BorrarRegitros();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteNegocio CN = new ClienteNegocio();
            VoucherNegocio VN = new VoucherNegocio();
            Cliente cli = new Cliente();
            DateTime fecha = DateTime.Today;

            try
            {
                if (ValidarVacio())
                {
                    
                    
                    if (CN.ExisteDNI(int.Parse(txtDNI.Text)))
                    {
                        cli = CN.leerCliente(int.Parse(txtDNI.Text));
                        VN.GuardarVoucher(cli);
                    }
                    else
                    {
                        cli.DNI = int.Parse(txtDNI.Text);
                        cli.Nombre = txtNombre.Text;
                        cli.Apellido = txtApellido.Text;
                        cli.Direccion = txtDireccion.Text;
                        cli.Ciudad = txtCiudad.Text;
                        cli.Email = txtEmail.Text;
                        cli.CP = txtCP.Text;
                        cli.FechaRegistro = fecha;
                        CN.GuardarCliente(cli);
                        VN.GuardarVoucher(cli);
                    }
                    EnviarEmail EM = new EnviarEmail();
                    EM.EnviarCorreo(cli.Email);
                    lblMensaje.Text = "GUARDADO";
                    
                }
                else
                {
                    lblMensaje.Text = "DEBE COMPLETAR TODOS LOS CAMPOS";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}