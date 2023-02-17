using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class DetalleEmergenciaBLL
    {
    private Contexto _contexto;
    public DetalleEmergenciaBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(DetalleEmergencia DetalleEmergencia)
    {
        if (!Existe(DetalleEmergencia.OrdenID))
            return Insertar(DetalleEmergencia);
        else
            return Modificar(DetalleEmergencia);
    }

    public bool Existe(int DetalleId)
    {
        return _contexto.DetallesEmergencias.Any(o => o.DetalleId== DetalleId);
    }

    private bool Insertar(DetalleEmergencia DetalleEmergencia)
    {
        _contexto.DetallesEmergencias.Add(DetalleEmergencia);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(DetalleEmergencia DetalleEmergencia)
    {
        _contexto.Entry(DetalleEmergencia).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(DetalleEmergencia).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<DetalleEmergencia> GetDetalleEmergenciasDetalles()
    {
        return _contexto.DetallesEmergencias.ToList();
    }

        public bool Eliminar(DetalleEmergencia DetalleEmergencia)
        {
            _contexto.Entry(DetalleEmergencia).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM DetalleEmergencia WHERE DetalleId={DetalleEmergencia.DetalleId};");
            _contexto.Entry(DetalleEmergencia).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public DetalleEmergencia? Buscar(int DetalleEmergenciaID)
        {
            return _contexto.DetallesEmergencias
                    .Where(o => o.OrdenID==DetalleEmergenciaID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<DetalleEmergencia> GetList()
        {
            return _contexto.DetallesEmergencias.AsNoTracking().ToList();
        }
    }
}