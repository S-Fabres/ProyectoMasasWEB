using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasasModel.DAL
{
    public interface IMasasDAL
    {
        List<Masa> ObtenerMasas();
        void Agregar(Masa masa);
        void Eliminar(int codigo);
        void Actualizar(Masa m);
    }
}
