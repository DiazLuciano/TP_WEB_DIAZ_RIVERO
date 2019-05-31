using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using NEGOCIO;


namespace WEB
{
    public partial class PasoUno : System.Web.UI.Page
    {
        GestionDatos gestionDatos = new GestionDatos();
        public Voucher voucherI { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void setvoucher(Voucher voucher)
        {
            this.voucherI = voucher;
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Voucher voucherI = new Voucher();
            VoucherNegocio VoucherN = new VoucherNegocio();
            try
            {
                voucherI.Codigo = txtVoucher.Text.Trim();

                if (VoucherN.ValidarVoucher(voucherI))
                {

                    setvoucher(voucherI);
                    
                    
                    
                    Response.Redirect("~/PasoDos.aspx");

                }
                else
                {
                    lblMensaje.Text = "No existe voucher";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "No existe voucher";
            }

            //string codigo = txtVoucher.Text;
            //Voucher voucher = gestionDatos.validarSiExiste(codigo);
            //if(voucher != null)
            //{
            //    Response.Redirect("~/PasoDos.aspx");
            //}
            //else
            //{
            //    lblMensaje.Text = "No existe voucher";
            //}

        }

    }
}