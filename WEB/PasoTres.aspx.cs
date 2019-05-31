using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WEB
{
    public partial class PasoTres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static string GuardarCliente(string DNI, string Nombre, string Apellido, string Email, string Direccion, string Ciudad, string CP)
        {
            string resultado = string.Empty;

            try
            {
                //Cliente cli = new Cliente();

                //cli.DNI = DNI;
                //cli.Nombre = Nombre;
                //cli.Apellido = Apellido;
                //cli.Email = Email;
                //cli.Direccion = Direccion;
                //cli.Ciudad = Ciudad;
                //cli.CP = CP;
            }
            catch (Exception ex)
            {
                resultado = "Error, " + ex.Message;
            }
            return resultado;
        }
    }
}