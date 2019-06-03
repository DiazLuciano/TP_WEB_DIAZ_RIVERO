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
        public Voucher voucherI { get; set; }
        public void setvoucher(Voucher voucher)
        {
            this.voucherI = voucher;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Voucher voucherI = new Voucher();
            VoucherNegocio VoucherN = new VoucherNegocio();

            try
            {
                voucherI.Codigo = txtVoucher.Text;

                if (VoucherN.ValidarVoucher(voucherI)==true)
                {

                    setvoucher(voucherI);
                    Response.Redirect("~/PasoDos.aspx");

                }
                else
                {
                    lblMensaje.Text = "No existe voucher";
                }
            }
            catch (Exception)
            {
                lblMensaje.Text = "NO CARGO NINGUN VOUCHER";
            }

        }

    }
}