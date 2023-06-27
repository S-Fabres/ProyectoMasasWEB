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
    public partial class AgregarMasa : System.Web.UI.Page
    {
        private IMasasDAL masasDAL = new MasasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            List<Masa> masas = masasDAL.ObtenerMasas();
            if (this.codTxt != null || this.tipoRbl.SelectedItem.Value != null)
            {
                bool existe = false;
                foreach (Masa m in masas)
                {
                    if (m.Tipo == this.tipoRbl.Text.Trim())
                    {
                        existe = true;
                    }

                }
                if (existe == false)
                {
                    /**Masa masa = new Masa();
                    masa.Codigo = Convert.ToInt32(this.codTxt.Text.Trim());
                    masa.Tipo = this.tipoRbl.Text.Trim();
                    this.masasDAL.Agregar(masa);**/
                    Response.Redirect("VerMasas.aspx");
                }
                else
                {
                    Response.Redirect("VerMasas.aspx");
                }
                

            }
        }
    }
}