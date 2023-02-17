using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class DetalleEmergenciaABLL
    {
    private Contexto _contexto;
    public DetalleEmergenciaABLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(DetalleEmergenciaA DetalleEmergenciaA)
    {
        if (!Existe(DetalleEmergenciaA.OrdenID))
            return Insertar(DetalleEmergenciaA);
        else
            return Modificar(DetalleEmergenciaA);
    }

    public bool Existe(int DetalleId)
    {
        return _contexto.DetallesEmergenciasA.Any(o => o.DetalleId== DetalleId);
    }

    private bool Insertar(DetalleEmergenciaA DetalleEmergenciaA)
    {
        _contexto.DetallesEmergenciasA.Add(DetalleEmergenciaA);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(DetalleEmergenciaA DetalleEmergenciaA)
    {
        _contexto.Entry(DetalleEmergenciaA).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(DetalleEmergenciaA).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<DetalleEmergenciaA> GetDetalleEmergenciaAsDetalles()
    {
        return _contexto.DetallesEmergenciasA.ToList();
    }

        public bool Eliminar(DetalleEmergenciaA DetalleEmergenciaA)
        {
            _contexto.Entry(DetalleEmergenciaA).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM DetalleEmergenciaA WHERE DetalleId={DetalleEmergenciaA.DetalleId};");
            _contexto.Entry(DetalleEmergenciaA).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public DetalleEmergenciaA? Buscar(int DetalleEmergenciaAID)
        {
            return _contexto.DetallesEmergenciasA
                    .Where(o => o.OrdenID==DetalleEmergenciaAID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<DetalleEmergenciaA> GetList()
        {
            return _contexto.DetallesEmergenciasA.AsNoTracking().ToList();
        }
    }
}