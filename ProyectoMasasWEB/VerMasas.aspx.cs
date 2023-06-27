using MasasModel;
using MasasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoMasasWEB
{
    public partial class VerMasas : System.Web.UI.Page
    {
        private IMasasDAL masasDAL = new MasasDALDB();

        private void cargarGrilla(List<Masa> masas)
        {
            this.grillaMasas.DataSource = masas;
            this.grillaMasas.DataBind();
        }

        private void cargarGrilla()
        {
            List<Masa> masas;
            masas = this.masasDAL.ObtenerMasas();
            this.cargarGrilla(masas);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla();
            }
        }

        protected void grillaMasas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int codigo = Convert.ToInt32(e.CommandArgument);
                this.masasDAL.Eliminar(codigo);
                this.cargarGrilla();
            }
            if (e.CommandName == "modificar")
            {
                Session["Parametro"] = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("ModificarMasa.aspx");
            }
        }
    }
}