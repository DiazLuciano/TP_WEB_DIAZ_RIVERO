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
    public partial class PasoDos : System.Web.UI.Page
    {
        private List<Producto> ListaProductos = new List<Producto>();
        ProductoNegocio PN = new ProductoNegocio();
        long id;
        protected void Page_Load(object sender, EventArgs e)
        {
            ListaProductos= (new ProductoNegocio().ListarProductos());

            ImagenBotonMochila.ImageUrl = ListaProductos[0].URLImagen;
            lblNombreMochila.Text = ListaProductos[0].Titulo;
            lblDescripcionMochila.Text = ListaProductos[0].Descripcion;

            ImagenBotonCelular.ImageUrl = ListaProductos[1].URLImagen;
            lblNombreCelular.Text = ListaProductos[1].Titulo;
            lblDescripcionCelular.Text = ListaProductos[1].Descripcion;

            ImagenBotonNotebook.ImageUrl = ListaProductos[2].URLImagen;
            lblNombreNotebook.Text = ListaProductos[2].Titulo;
            lblDescripcionNotebook.Text = ListaProductos[2].Descripcion;


        }

        //private void CargarProductos()
        //{

        //    ProductoNegocio proN = new ProductoNegocio();
        //    try
        //    {
        //        ListaProductos = proN.ListarProductos();
        //        //dgvArticulos.DataSource = ListarProductos;
        //    }
        //    catch (Exception )
        //    {
        //        //MessageBox.Show(ex.ToString());
        //        throw;
        //    }
        //}

        protected void ImagenBotonMochila_Click(object sender, ImageClickEventArgs e)
        {
           
             id = 1;
            PN.CargarPro(id);
            Response.Redirect("~/PasoTres.aspx");
        }

        protected void ImagenBotonNotebook_Click(object sender, ImageClickEventArgs e)
        {
            
            id = 3;
            PN.CargarPro(id);
            Response.Redirect("~/PasoTres.aspx");
        }

        protected void ImagenBotonCelular_Click(object sender, ImageClickEventArgs e)
        {
            
            id = 2;
            PN.CargarPro(id);
            Response.Redirect("~/PasoTres.aspx");
        }
    }
}