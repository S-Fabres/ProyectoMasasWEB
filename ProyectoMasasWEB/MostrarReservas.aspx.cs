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
    public partial class MostrarReservas : System.Web.UI.Page
    {
        private IReservasDAL reservasDAL = new ReservasDALDB();

        private void cargarGrilla(List<Reserva> reservas)
        {
            this.grillaReservas.DataSource = reservas;
            this.grillaReservas.DataBind();
        }

        private void cargarGrilla()
        {
            List<Reserva> reservas;
            reservas = this.reservasDAL.ObtenerReservas();
            this.cargarGrilla(reservas);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla();
            }
        }

        protected void grillaReservas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int idReserva = Convert.ToInt32(e.CommandArgument);
                this.reservasDAL.Eliminar(idReserva);
                this.cargarGrilla();
            }
            if (e.CommandName == "modificar")
            {
                Session["Parametro"] = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("ModificarReserva.aspx");
            }
        }
    }
}