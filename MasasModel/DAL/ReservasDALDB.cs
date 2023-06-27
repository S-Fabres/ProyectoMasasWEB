using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasasModel.DAL
{
    public class ReservasDALDB : IReservasDAL
    {
        private MasasDBEntities masasDB = new MasasDBEntities();

        public void Ingresar(Reserva reserva)
        {
            List<Reserva> reservas = this.masasDB.Reservas.ToList();
            bool existe = false;
            foreach (Reserva r in reservas)
            {
                if (r.IdReserva == reserva.IdReserva)
                {
                    existe = true;
                }
            }
            if (existe == false)
            {
                this.masasDB.Reservas.Add(reserva);
                this.masasDB.SaveChanges();
            }
        }
        public void Eliminar(int idReserva)
        {
            Reserva reserva = this.masasDB.Reservas.Find(idReserva);
            this.masasDB.Reservas.Remove(reserva);
            this.masasDB.SaveChanges();

        }

        public List<Reserva> ObtenerReservas()
        {
            return this.masasDB.Reservas.ToList();
        } 

        public void Actualizar(Reserva r)
        {
            Reserva rOriginal = this.masasDB.Reservas.Find(r.IdReserva);
            rOriginal.TipoMasa = r.TipoMasa;
            rOriginal.Cantidad = r.Cantidad;
            rOriginal.FechaIngreso = r.FechaIngreso;
            rOriginal.FechaEntrega = r.FechaEntrega;
            rOriginal.HoraEntrega = r.HoraEntrega;
            rOriginal.TipoEntrega = r.TipoEntrega;
            this.masasDB.SaveChanges();
        }
    }
}
