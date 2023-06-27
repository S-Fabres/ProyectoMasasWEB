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
    public partial class ModificarMasa : System.Web.UI.Page
    {
        private IMasasDAL masasDAL = new MasasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Parametro"] != null)
                {
                    this.codigoTxt.Text = Convert.ToString(Session["Parametro"]);
                }


            }
        }

        protected void modificarBtn_Click(object sender, EventArgs e)
        {
            if (this.codigoTxt.Text != null || this.tipoRbl.SelectedItem.Value != null)
            {
                Masa masa = new Masa();
                masa.Codigo = Convert.ToInt32(this.codigoTxt.Text.Trim());
                masa.Tipo = this.tipoRbl.SelectedItem.Value;

                this.masasDAL.Actualizar(masa);
                Response.Redirect("VerMasas.aspx");
            }
            else
            {
                Response.Redirect("VerMasas.aspx");
            }
            
         
            
        }
    }
}