using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasasModel.DAL
{
    public class MasasDALDB : IMasasDAL
    {
        private MasasDBEntities masasDB = new MasasDBEntities();
        public void Agregar(Masa masa)
        {
            List<Masa> masas = this.masasDB.Masas.ToList();
            bool existe = false;
            foreach (Masa m in masas)
            {
                if (m.Codigo == masa.Codigo)
                {
                    existe = true;
                }
            }
            if (existe == false)
            {
                this.masasDB.Masas.Add(masa);
                this.masasDB.SaveChanges();
            }
        }
        public void Eliminar(int codigo)
        {
            Masa masa = this.masasDB.Masas.Find(codigo);
            this.masasDB.Masas.Remove(masa);
            this.masasDB.SaveChanges();
        }
        public List<Masa> ObtenerMasas()
        {
            return this.masasDB.Masas.ToList();
        }
        public void Actualizar(Masa m)
        {
            Masa mOriginal = this.masasDB.Masas.Find(m.Codigo);
            mOriginal.Tipo = m.Tipo;
            this.masasDB.SaveChanges();
        }
    }
}
