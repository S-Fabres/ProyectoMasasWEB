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
    public partial class ModificarReserva : System.Web.UI.Page
    {
        private IReservasDAL reservasDAL = new ReservasDALDB();
        private IMasasDAL masasDAL = new MasasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Parametro"] != null)
                {
                    this.idReservaTxt.Text = Convert.ToString(Session["Parametro"]);
                }
                List<Masa> masas = masasDAL.ObtenerMasas();
                this.tipoMasaDdl.DataSource = masas;
                this.tipoMasaDdl.DataTextField = "Tipo";
                this.tipoMasaDdl.DataBind();
            }
        }

        protected void modificarBtn_Click(object sender, EventArgs e)
        {
            if (this.cantidadTxt.Text != null || this.horaEntregaTxt.Text != null)
            {
                Reserva reserva = new Reserva();
                reserva.IdReserva = Convert.ToInt32(this.idReservaTxt.Text.Trim());
                reserva.TipoMasa = this.tipoMasaDdl.SelectedItem.Value;
                reserva.Cantidad = Convert.ToInt32(this.cantidadTxt.Text.Trim());
                reserva.FechaIngreso = this.CalendarFechaReserva.SelectedDate.ToString("dd-MM-yyyy");
                reserva.FechaEntrega = this.CalendarFechaEntrega.SelectedDate.ToString("dd-MM-yyyy");
                reserva.HoraEntrega = this.horaEntregaTxt.Text.Trim();
                reserva.TipoEntrega = this.tipoEntregaRbl.SelectedItem.Value;

                this.reservasDAL.Actualizar(reserva);
                Response.Redirect("MostrarReservas.aspx");
            }
        }
    }
}