using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasasModel.DAL
{
    public interface IReservasDAL
    {
        void Ingresar(Reserva reserva);
        void Eliminar(int idReserva);
        List<Reserva> ObtenerReservas();
        void Actualizar(Reserva r);
    }
}
