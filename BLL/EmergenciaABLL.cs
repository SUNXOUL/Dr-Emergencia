using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class EmergenciaABLL
    {
        private Contexto _contexto;
        public EmergenciaABLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(EmergenciaA EmergenciaA)
        {
            if (!Existe(EmergenciaA.OrdenID))
                return Insertar(EmergenciaA);
            else
                return Modificar(EmergenciaA);
        }

        public bool Existe(int EmergenciaAId)
        {
            return _contexto.EmergenciaAs.Any(o => o.OrdenID == EmergenciaAId);
        }

        private bool Insertar(EmergenciaA EmergenciaA)
        {
            _contexto.EmergenciaAs.Add(EmergenciaA);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public bool Modificar(EmergenciaA EmergenciaA)
        {
            _contexto.Entry(EmergenciaA).State = EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            _contexto.Entry(EmergenciaA).State = EntityState.Detached;
            return cantidad > 0;
        }

        public List<EmergenciaA> GetEmergenciaAsDetalles()
        {
            return _contexto.EmergenciaAs.ToList();
        }

        public bool Eliminar(EmergenciaA EmergenciaA)
        {
            _contexto.Entry(EmergenciaA).State = EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM EmergenciaA WHERE OrdenID={EmergenciaA.OrdenID};");
            _contexto.Entry(EmergenciaA).State = EntityState.Detached;
            return _contexto.SaveChanges() > 0;
        }

        public EmergenciaA? Buscar(int EmergenciaAID)
        {
            return _contexto.EmergenciaAs
                    .Where(o => o.OrdenID == EmergenciaAID).AsNoTracking().SingleOrDefault();

        }
        public List<EmergenciaA> GetList()
        {
            return _contexto.EmergenciaAs.Where(o => o.Visible == true).AsNoTracking().ToList();
        }
        public bool hidden(EmergenciaA EmergenciaA)
        {
            _contexto.Entry(EmergenciaA).State = EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            _contexto.Database.ExecuteSqlRaw($"UPDATE EmergenciaAs SET Visible = false  WHERE EmergenciaAID={EmergenciaA.OrdenID}");
            _contexto.Entry(EmergenciaA).State = EntityState.Detached;
            return cantidad > 0;
        }
    }
}