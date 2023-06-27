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
    public partial class IngresarReserva : System.Web.UI.Page
    {
        private IReservasDAL reservasDAL = new ReservasDALDB();
        private IMasasDAL masasDAL = new MasasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Masa> masas = masasDAL.ObtenerMasas();
                this.tipoMasaDdl.DataSource = masas;
                this.tipoMasaDdl.DataTextField = "Tipo";
                this.tipoMasaDdl.DataBind();
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            if (this.cantidadTxt.Text != null || this.horaEntregaTxt.Text != null)
            {
                int id = 0;
                List<Reserva> reservas = reservasDAL.ObtenerReservas();
                foreach (Reserva reserva in reservas)
                {
                    id = id + 1;
                }
                if (id != 0)
                {
                    Reserva reserva = new Reserva();
                    reserva.IdReserva = id;
                    reserva.TipoMasa = this.tipoMasaDdl.SelectedItem.Value;
                    reserva.Cantidad = Convert.ToInt32(this.cantidadTxt.Text.Trim());
                    reserva.FechaIngreso = this.CalendarFechaReserva.SelectedDate.ToString("dd-MM-yyyy");
                    reserva.FechaEntrega = this.CalendarFechaEntrega.SelectedDate.ToString("dd-MM-yyyy");
                    reserva.HoraEntrega = this.horaEntregaTxt.Text.Trim();
                    reserva.TipoEntrega = this.tipoEntregaRbl.SelectedItem.Value;
                    this.reservasDAL.Ingresar(reserva);
                    Response.Redirect("MostrarReservas.aspx");
                }
            }
        }
    }
}